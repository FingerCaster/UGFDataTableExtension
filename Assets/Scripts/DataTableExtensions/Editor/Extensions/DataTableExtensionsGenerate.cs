using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using GameFramework;
using UnityEditor;
using UnityEngine;
using UGFDataTableProcessor = UnityGameFramework.Editor.DataTableTools.DataTableProcessor;

namespace DE.Editor
{
    public static class DataTableExtensionsGenerate
    {
        private static string ExtensionDirectoryPath = "Assets/Scripts/DataTableExtensions/Runtime/Extensions";
        private static string NameSpace = "DE";

        [MenuItem("DatableTools/GenerateExtension")]
        private static void GenerateExtension()
        {
            IDictionary<string, UGFDataTableProcessor.DataProcessor> datableDataProcessors =
                new SortedDictionary<string, UGFDataTableProcessor.DataProcessor>();
            IDictionary<string, UGFDataTableProcessor.DataProcessor> binaryReaderDataProcessors =
                new SortedDictionary<string, UGFDataTableProcessor.DataProcessor>();
            System.Type dataProcessorBaseType = typeof(UGFDataTableProcessor.DataProcessor);
            List<System.Type> types = DataTableProcessorHelper.GetTypeNames(dataProcessorBaseType);
            for (int i = 0; i < types.Count; i++)
            {
                if (!types[i].IsClass || types[i].IsAbstract || types[i].ContainsGenericParameters)
                {
                    continue;
                }
                if (dataProcessorBaseType.IsAssignableFrom(types[i]))
                {
                    UGFDataTableProcessor.DataProcessor dataProcessor = null;
                    dataProcessor = (UGFDataTableProcessor.DataProcessor) Activator.CreateInstance(types[i]);
                    if (dataProcessor.IsComment || dataProcessor.IsId)
                    {
                        continue;
                    }
                    datableDataProcessors.Add(dataProcessor.LanguageKeyword, dataProcessor);
                    Debug.Log(dataProcessor.LanguageKeyword);
                }
            }

            GenerateDataTableExtensionArray(datableDataProcessors);
            GenerateDataTableExtensionList(datableDataProcessors);
            GenerateBinaryReaderExtensionList(datableDataProcessors);
            GenerateBinaryReaderExtensionArray(datableDataProcessors);

            AssetDatabase.Refresh();
        }


        private static void GenerateDataTableExtensionArray(IDictionary<string, UGFDataTableProcessor.DataProcessor> dataProcessors)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class DataTableExtension");
            sb.AppendLine("\t{");
            foreach (KeyValuePair<string, UGFDataTableProcessor.DataProcessor> item in dataProcessors)
            {
                sb.AppendLine($"\t\tpublic static {item.Key}[] Parse{item.Value.Type.Name}Array(string value)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value))");
                sb.AppendLine("\t\t\t\treturn null;");
                sb.AppendLine("\t\t\tstring[] splitValue = value.Split('|');");
                sb.AppendLine($"\t\t\t{item.Key}[] array = new {item.Key}[splitValue.Length];");
                sb.AppendLine("\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
                sb.AppendLine("\t\t\t{");
                if (item.Value.IsSystem)
                {
                    if (item.Key == "string")
                    {
                        sb.AppendLine($"\t\t\t\tarray[i] = splitValue[i];");
                    }
                    else
                    {
                        sb.AppendLine($"\t\t\t\tarray[i] = {item.Value.Type.Name}.Parse(splitValue[i]);");
                    }
                }
                else
                {
                    sb.AppendLine($"\t\t\t\tarray[i] = Parse{item.Value.Type.Name}(splitValue[i]);");
                }

                sb.AppendLine("\t\t\t}");
                sb.AppendLine();
                sb.AppendLine($"\t\t\treturn array;");
                sb.AppendLine("\t\t}");
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            GenerateCodeFile("DataTableExtension.Array", sb.ToString());
        }

        private static void GenerateDataTableExtensionList(
            IDictionary<string, UGFDataTableProcessor.DataProcessor> dataProcessors)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class DataTableExtension");
            sb.AppendLine("\t{");
            foreach (KeyValuePair<string, UGFDataTableProcessor.DataProcessor> item in dataProcessors)
            {
                sb.AppendLine($"\t\tpublic static List<{item.Key}> Parse{item.Value.Type.Name}List(string value)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value))");
                sb.AppendLine("\t\t\t\treturn null;");
                sb.AppendLine("\t\t\tstring[] splitValue = value.Split('|');");
                sb.AppendLine($"\t\t\tList<{item.Key}> list = new List<{item.Key}>(splitValue.Length);");
                sb.AppendLine("\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
                sb.AppendLine("\t\t\t{");
                if (item.Value.IsSystem)
                {
                    if (item.Key == "string")
                    {
                        sb.AppendLine($"\t\t\t\tlist.Add(splitValue[i]);");
                    }
                    else
                    {
                        sb.AppendLine($"\t\t\t\tlist.Add({item.Value.Type.Name}.Parse(splitValue[i]));");
                    }
                }
                else
                {
                    sb.AppendLine($"\t\t\t\tlist.Add(Parse{item.Value.Type.Name}(splitValue[i]));");
                }
                sb.AppendLine("\t\t\t}");
                sb.AppendLine("\t\t\treturn list;");
                sb.AppendLine("\t\t}");
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            GenerateCodeFile("DataTableExtension.List", sb.ToString());
        }

        private static void GenerateBinaryReaderExtensionList(
            IDictionary<string, UGFDataTableProcessor.DataProcessor> dataProcessors)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class BinaryReaderExtension");
            sb.AppendLine("\t{");
            foreach (KeyValuePair<string, UGFDataTableProcessor.DataProcessor> item in dataProcessors)
            {
                sb.AppendLine($"\t\tpublic static List<{item.Key}> Read{item.Value.Type.Name}List(this BinaryReader binaryReader)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tint count = binaryReader.Read7BitEncodedInt32();");
                sb.AppendLine($"\t\t\tList<{item.Key}> list = new List<{item.Key}>(count);");
                sb.AppendLine("\t\t\tfor (int i = 0; i < count; i++)");
                sb.AppendLine("\t\t\t{");
                if (DataTableProcessorHelper.IsCustomType(item.Value.Type)|| item.Value.Type == typeof(DateTime))
                {
                    sb.AppendLine($"\t\t\t\tlist.Add(Read{item.Key}(binaryReader));");
                }
                else
                {
                    string languageKeyword = item.Key;
                    if (languageKeyword == "int" || languageKeyword == "uint" || languageKeyword == "long" ||
                        languageKeyword == "ulong")
                    {
                        sb.AppendLine($"\t\t\t\tlist.Add(binaryReader.Read7BitEncoded{item.Value.Type.Name}());");
                    }
                    else if (languageKeyword == "string")
                    {
                        sb.Replace($"\t\tpublic static List<{item.Key}> Read{item.Value.Type.Name}List(this BinaryReader binaryReader)",
                            $"\t\tpublic static List<{item.Key}> Read{item.Value.Type.Name}List(this BinaryReader binaryReader,string[] strings)");
                        sb.AppendLine("\t\t\t\tlist.Add(strings[binaryReader.Read7BitEncodedInt32()]);");
                    }
                    else
                    {
                        sb.AppendLine($"\t\t\t\tlist.Add(binaryReader.Read{item.Value.Type.Name}());");
                    }
                }

                sb.AppendLine("\t\t\t}");
                sb.AppendLine("\t\t\treturn list;");
                sb.AppendLine("\t\t}");
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            GenerateCodeFile("BinaryReaderExtension.List", sb.ToString());
        }

        private static void GenerateBinaryReaderExtensionArray(
            IDictionary<string, UGFDataTableProcessor.DataProcessor> dataProcessors)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class BinaryReaderExtension");
            sb.AppendLine("\t{");
            foreach (KeyValuePair<string, UGFDataTableProcessor.DataProcessor> item in dataProcessors)
            {
                sb.AppendLine($"\t\tpublic static {item.Key}[] Read{item.Value.Type.Name}Array(this BinaryReader binaryReader)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tint count = binaryReader.Read7BitEncodedInt32();");
                sb.AppendLine($"\t\t\t{item.Key}[] array = new {item.Key}[count];");
                sb.AppendLine("\t\t\tfor (int i = 0; i < count; i++)");
                sb.AppendLine("\t\t\t{");
                if (DataTableProcessorHelper.IsCustomType(item.Value.Type)|| item.Value.Type == typeof(DateTime))
                {
                    sb.AppendLine($"\t\t\t\tarray[i] = Read{item.Key}(binaryReader);");
                }
                else
                {
                    string languageKeyword = item.Key;
                    if (languageKeyword == "int" || languageKeyword == "uint" || languageKeyword == "long" ||
                        languageKeyword == "ulong")
                    {
                        sb.AppendLine($"\t\t\t\tarray[i] = binaryReader.Read7BitEncoded{item.Value.Type.Name}();");
                    }
                    else if (languageKeyword == "string")
                    {
                        sb.Replace($"\t\tpublic static {item.Key}[] Read{item.Value.Type.Name}Array(this BinaryReader binaryReader)",
                            $"\t\tpublic static {item.Key}[] Read{item.Value.Type.Name}Array(this BinaryReader binaryReader,string[] strings)");
                        sb.AppendLine("\t\t\t\tarray[i] = strings[binaryReader.Read7BitEncodedInt32()];");
                    }
                    else
                    {
                        sb.AppendLine($"\t\t\t\tarray[i] = binaryReader.Read{item.Value.Type.Name}();");
                    }
                }

                sb.AppendLine("\t\t\t}");
                sb.AppendLine("\t\t\treturn array;");
                sb.AppendLine("\t\t}");
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            GenerateCodeFile("BinaryReaderExtension.Array", sb.ToString());
        }

        private static void GenerateCodeFile(string fileName, string value)
        {
            string filePath = Utility.Path.GetRegularPath(Path.Combine(ExtensionDirectoryPath, fileName + ".cs"));
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter stream = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    stream.Write(value);
                }
            }
        }

        private static bool IsCustomType(Type type)
        {
            return (type != typeof(object) && Type.GetTypeCode(type) == TypeCode.Object);
        }
    }
}