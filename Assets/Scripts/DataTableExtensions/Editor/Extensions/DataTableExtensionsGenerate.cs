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
                    if (IsCustomType(dataProcessor.Type) && !(dataProcessor.IsId || dataProcessor.IsComment))
                    {
                        datableDataProcessors.Add(dataProcessor.LanguageKeyword, dataProcessor);
                        binaryReaderDataProcessors.Add(dataProcessor.LanguageKeyword, dataProcessor);
                    }

                    if (dataProcessor.Type == typeof(DateTime))
                    {
                        binaryReaderDataProcessors.Add(dataProcessor.LanguageKeyword, dataProcessor);
                    }
                }
            }

            GenerateDataTableExtensionArray(datableDataProcessors);
            GenerateDataTableExtensionList(datableDataProcessors);
            GenerateBinaryReaderExtensionList(binaryReaderDataProcessors);
            GenerateBinaryReaderExtensionArray(binaryReaderDataProcessors);

            AssetDatabase.Refresh();
        }


        private static void GenerateDataTableExtensionArray(
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
                sb.AppendLine($"\t\tpublic static {item.Key}[] Parse{item.Key}Array(string value)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value))");
                sb.AppendLine("\t\t\t\treturn null;");
                sb.AppendLine("\t\t\tstring[] splitValue = value.Split(',');");
                sb.AppendLine($"\t\t\t{item.Key}[] array = new {item.Key}[splitValue.Length];");
                sb.AppendLine("\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
                sb.AppendLine("\t\t\t{");
                sb.AppendLine($"\t\t\t\tarray[i] = Parse{item.Key}(splitValue[i]);");
                sb.AppendLine("\t\t\t}");
                sb.AppendLine();
                sb.AppendLine($"\t\t\treturn array;");
                sb.AppendLine("\t\t}");
            }

            sb.AppendLine("\t\tpublic static T[] ParseArray<T>(string value)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value))");
            sb.AppendLine("\t\t\t{");
            sb.AppendLine("\t\t\t\treturn null;");
            sb.AppendLine("\t\t\t}");
            sb.AppendLine("\t\t\tstring[] splitValue = value.Split(',');");
            sb.AppendLine("\t\t\tT[] array = new T[splitValue.Length];");
            sb.AppendLine("\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
            sb.AppendLine("\t\t\t{");
            sb.AppendLine("\t\t\t\tT t = DataTableExtensionHelper.Parse<T>(splitValue[i]);");
            sb.AppendLine("\t\t\t\tarray[i] = t;");
            sb.AppendLine("\t\t\t}");
            sb.AppendLine("\t\t\t return array;");
            sb.AppendLine("\t\t}");
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
                sb.AppendLine($"\t\tpublic static List<{item.Key}> Parse{item.Key}List(string value)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value))");
                sb.AppendLine("\t\t\t\treturn null;");
                sb.AppendLine("\t\t\tstring[] items = value.Split('|');");
                sb.AppendLine($"\t\t\tList<{item.Key}> list = new List<{item.Key}>(items.Length);");
                sb.AppendLine("\t\t\tforeach (string item in items)");
                sb.AppendLine("\t\t\t{");
                sb.AppendLine("\t\t\t\tstring[] splitValue = value.Split(',');");
                sb.AppendLine("\t\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
                sb.AppendLine("\t\t\t\t{");
                sb.AppendLine($"\t\t\t\t\tlist.Add(Parse{item.Key}(splitValue[i]));");
                sb.AppendLine("\t\t\t\t}");
                sb.AppendLine("\t\t\t}");
                sb.AppendLine("\t\t\treturn list;");
                sb.AppendLine("\t\t}");
            }

            sb.AppendLine("\t\tpublic static List<T> ParseList<T>(string value)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value))");
            sb.AppendLine("\t\t\t{");
            sb.AppendLine("\t\t\t\treturn null;");
            sb.AppendLine("\t\t\t}");
            sb.AppendLine("\t\t\tstring[] items = value.Split('|');");
            sb.AppendLine("\t\t\tList<T> list = new List<T>(items.Length);");
            sb.AppendLine("\t\t\tforeach (string item in items)");
            sb.AppendLine("\t\t\t{");
            sb.AppendLine("\t\t\t\tstring[] splitValue = value.Split(',');");
            sb.AppendLine("\t\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
            sb.AppendLine("\t\t\t\t{");
            sb.AppendLine("\t\t\t\t\tT t = DataTableExtensionHelper.Parse<T>(splitValue[i]);");
            sb.AppendLine("\t\t\t\t\tlist.Add(t);");
            sb.AppendLine("\t\t\t\t}");
            sb.AppendLine("\t\t\t}");
            sb.AppendLine("\t\t\treturn list;");
            sb.AppendLine("\t\t}");
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
                sb.AppendLine($"\t\tpublic static List<{item.Key}> Read{item.Key}List(this BinaryReader binaryReader)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tstring value = binaryReader.ReadString();");
                sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value))");
                sb.AppendLine("\t\t\t\treturn null;");
                if (item.Value.Type == typeof(DateTime))
                {
                    sb.AppendLine("\t\t\tstring[] splitValue = value.Split(',');");
                    sb.AppendLine($"\t\t\tList<DateTime> list = new List<DateTime>(splitValue.Length);");
                    sb.AppendLine("\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
                    sb.AppendLine("\t\t\t{");
                    sb.AppendLine($"\t\t\t\tlist.Add(new DateTime(Int64.Parse(splitValue[i])));");
                    sb.AppendLine("\t\t\t}");
                    sb.AppendLine("\t\t\treturn list;");
                }
                else
                {
                    sb.AppendLine($"\t\t\treturn DataTableExtension.Parse{item.Key}List(value);");
                }

                sb.AppendLine("\t\t}");
            }

            sb.AppendLine("\t\tpublic static List<T> ReadList<T>(this BinaryReader binaryReader)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tstring value = binaryReader.ReadString();");
            sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value))");
            sb.AppendLine("\t\t\t{");
            sb.AppendLine("\t\t\t\treturn null;");
            sb.AppendLine("\t\t\t}");
            sb.AppendLine("\t\t\treturn DataTableExtension.ParseList<T>(value);");
            sb.AppendLine("\t\t}");
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
                sb.AppendLine($"\t\tpublic static {item.Key}[] Read{item.Key}Array(this BinaryReader binaryReader)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tstring value = binaryReader.ReadString();");
                sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value))");
                sb.AppendLine("\t\t\t\treturn null;");
                if (item.Value.Type == typeof(DateTime))
                {
                    sb.AppendLine("\t\t\tstring[] splitValue = value.Split(',');");
                    sb.AppendLine($"\t\t\tDateTime[] array = new DateTime[splitValue.Length];");
                    sb.AppendLine("\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
                    sb.AppendLine("\t\t\t{");
                    sb.AppendLine($"\t\t\t\tarray[i] = new DateTime(Int64.Parse(splitValue[i]));");
                    sb.AppendLine("\t\t\t}");
                    sb.AppendLine("\t\t\treturn array;");
                }
                else
                {
                    sb.AppendLine($"\t\t\treturn DataTableExtension.Parse{item.Key}Array(value);");
                }

                sb.AppendLine("\t\t}");
            }

            sb.AppendLine("\t\tpublic static T[] ReadArray<T>(this BinaryReader binaryReader)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tstring value = binaryReader.ReadString();");
            sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value))");
            sb.AppendLine("\t\t\t{");
            sb.AppendLine("\t\t\t\treturn null;");
            sb.AppendLine("\t\t\t}");
            sb.AppendLine("\t\t\treturn DataTableExtension.ParseArray<T>(value);");
            sb.AppendLine("\t\t}");
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