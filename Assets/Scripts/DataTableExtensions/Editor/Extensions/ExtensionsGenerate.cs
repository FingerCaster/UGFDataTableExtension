using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using GameFramework;
using UnityEditor;

namespace DE.Editor.DataTableTools
{
    public static class ExtensionsGenerate
    {
        private static readonly string ExtensionDirectoryPath = "Assets/Scripts/DataTableExtensions/Runtime/Extensions";
        private static readonly string NameSpace = "DE";


        private static readonly string[] EditorAssemblyNames =
        {
#if UNITY_2017_3_OR_NEWER
            "UnityGameFramework.Editor",
            "DE.Editor",
#endif
            "Assembly-CSharp-Editor"
        };

        [MenuItem("DataTable/GenerateExtension")]
        private static void GenerateExtension()
        {
            IDictionary<string, DataTableProcessor.DataProcessor> datableDataProcessors =
                new SortedDictionary<string, DataTableProcessor.DataProcessor>();
            IDictionary<string, DataTableProcessor.DataProcessor> binaryReaderDataProcessors =
                new SortedDictionary<string, DataTableProcessor.DataProcessor>();
            var dataProcessorBaseType = typeof(DataTableProcessor.DataProcessor);
            var types = GetTypeNames(dataProcessorBaseType);
            for (var i = 0; i < types.Count; i++)
            {
                if (!types[i].IsClass || types[i].IsAbstract || types[i].ContainsGenericParameters) continue;

                if (dataProcessorBaseType.IsAssignableFrom(types[i]))
                {
                    DataTableProcessor.DataProcessor dataProcessor = null;
                    dataProcessor = (DataTableProcessor.DataProcessor) Activator.CreateInstance(types[i]);
                    if (dataProcessor.IsComment || dataProcessor.IsId) continue;
                    datableDataProcessors.Add(dataProcessor.LanguageKeyword, dataProcessor);
                }
            }

            GenerateDataTableExtensionArray(datableDataProcessors);
            GenerateDataTableExtensionList(datableDataProcessors);
            GenerateBinaryReaderExtensionList(datableDataProcessors);
            GenerateBinaryReaderExtensionArray(datableDataProcessors);
            GenerateDataTableExtensionDictionary(datableDataProcessors);
            GenerateBinaryReaderExtensionDictionary(datableDataProcessors);
            AssetDatabase.Refresh();
        }


        private static void GenerateDataTableExtensionArray(
            IDictionary<string, DataTableProcessor.DataProcessor> dataProcessors)
        {
            var sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class DataTableExtension");
            sb.AppendLine("\t{");
            foreach (var item in dataProcessors)
            {
                sb.AppendLine($"\t\tpublic static {item.Key}[] Parse{item.Value.Type.Name}Array(string value)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals(\"null\"))");
                sb.AppendLine("\t\t\t\treturn null;");
                if (item.Value.IsSystem)
                    sb.AppendLine("\t\t\tstring[] splitValue = value.Split(',');");
                else
                    sb.AppendLine("\t\t\tstring[] splitValue = value.Split('|');");
                sb.AppendLine($"\t\t\t{item.Key}[] array = new {item.Key}[splitValue.Length];");
                sb.AppendLine("\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
                sb.AppendLine("\t\t\t{");
                if (item.Value.IsSystem)
                {
                    if (item.Key == "string")
                        sb.AppendLine("\t\t\t\tarray[i] = splitValue[i];");
                    else
                        sb.AppendLine($"\t\t\t\tarray[i] = {item.Value.Type.Name}.Parse(splitValue[i]);");
                }
                else
                {
                    sb.AppendLine($"\t\t\t\tarray[i] = Parse{item.Value.Type.Name}(splitValue[i]);");
                }

                sb.AppendLine("\t\t\t}");
                sb.AppendLine();
                sb.AppendLine("\t\t\treturn array;");
                sb.AppendLine("\t\t}");
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");
            GenerateCodeFile("DataTableExtension.Array", sb.ToString());
        }

        private static void GenerateDataTableExtensionList(
            IDictionary<string, DataTableProcessor.DataProcessor> dataProcessors)
        {
            var sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class DataTableExtension");
            sb.AppendLine("\t{");
            foreach (var item in dataProcessors)
            {
                sb.AppendLine($"\t\tpublic static List<{item.Key}> Parse{item.Value.Type.Name}List(string value)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals(\"null\"))");
                sb.AppendLine("\t\t\t\treturn null;");
                if (item.Value.IsSystem)
                    sb.AppendLine("\t\t\tstring[] splitValue = value.Split(',');");
                else
                    sb.AppendLine("\t\t\tstring[] splitValue = value.Split('|');");
                sb.AppendLine($"\t\t\tList<{item.Key}> list = new List<{item.Key}>(splitValue.Length);");
                sb.AppendLine("\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
                sb.AppendLine("\t\t\t{");
                if (item.Value.IsSystem)
                {
                    if (item.Key == "string")
                        sb.AppendLine("\t\t\t\tlist.Add(splitValue[i]);");
                    else
                        sb.AppendLine($"\t\t\t\tlist.Add({item.Value.Type.Name}.Parse(splitValue[i]));");
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
            IDictionary<string, DataTableProcessor.DataProcessor> dataProcessors)
        {
            var sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class BinaryReaderExtension");
            sb.AppendLine("\t{");
            foreach (var item in dataProcessors)
            {
                sb.AppendLine(
                    $"\t\tpublic static List<{item.Key}> Read{item.Value.Type.Name}List(this BinaryReader binaryReader)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tint count = binaryReader.Read7BitEncodedInt32();");
                sb.AppendLine($"\t\t\tList<{item.Key}> list = new List<{item.Key}>(count);");
                sb.AppendLine("\t\t\tfor (int i = 0; i < count; i++)");
                sb.AppendLine("\t\t\t{");
                if (IsCustomType(item.Value.Type) || item.Value.Type == typeof(DateTime))
                {
                    sb.AppendLine($"\t\t\t\tlist.Add(Read{item.Key}(binaryReader));");
                }
                else
                {
                    var languageKeyword = item.Key;
                    if (languageKeyword == "int" || languageKeyword == "uint" || languageKeyword == "long" ||
                        languageKeyword == "ulong")
                        sb.AppendLine($"\t\t\t\tlist.Add(binaryReader.Read7BitEncoded{item.Value.Type.Name}());");
                    else
                        sb.AppendLine($"\t\t\t\tlist.Add(binaryReader.Read{item.Value.Type.Name}());");
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
            IDictionary<string, DataTableProcessor.DataProcessor> dataProcessors)
        {
            var sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class BinaryReaderExtension");
            sb.AppendLine("\t{");
            foreach (var item in dataProcessors)
            {
                sb.AppendLine(
                    $"\t\tpublic static {item.Key}[] Read{item.Value.Type.Name}Array(this BinaryReader binaryReader)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tint count = binaryReader.Read7BitEncodedInt32();");
                sb.AppendLine($"\t\t\t{item.Key}[] array = new {item.Key}[count];");
                sb.AppendLine("\t\t\tfor (int i = 0; i < count; i++)");
                sb.AppendLine("\t\t\t{");
                if (IsCustomType(item.Value.Type) || item.Value.Type == typeof(DateTime))
                {
                    sb.AppendLine($"\t\t\t\tarray[i] = Read{item.Key}(binaryReader);");
                }
                else
                {
                    var languageKeyword = item.Key;
                    if (languageKeyword == "int" || languageKeyword == "uint" || languageKeyword == "long" ||
                        languageKeyword == "ulong")
                        sb.AppendLine($"\t\t\t\tarray[i] = binaryReader.Read7BitEncoded{item.Value.Type.Name}();");
                    else
                        sb.AppendLine($"\t\t\t\tarray[i] = binaryReader.Read{item.Value.Type.Name}();");
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
            var filePath = Utility.Path.GetRegularPath(Path.Combine(ExtensionDirectoryPath, fileName + ".cs"));
            if (File.Exists(filePath)) File.Delete(filePath);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                using (var stream = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    stream.Write(value);
                }
            }
        }

        private static void GenerateDataTableExtensionDictionary(
            IDictionary<string, DataTableProcessor.DataProcessor> dataProcessors)
        {
            var keyValueList =
                PermutationAndCombination<DataTableProcessor.DataProcessor>
                    .GetCombination(dataProcessors.Values.ToArray(), 2).ToList();
            foreach (var dataProcessor in dataProcessors.Values) keyValueList.Add(new[] {dataProcessor, dataProcessor});

            var sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class DataTableExtension");
            sb.AppendLine("\t{");
            foreach (var item in keyValueList)
            {
                var dataProcessorT1 = item[0];
                var dataProcessorT2 = item[1];
                sb.AppendLine(
                    $"\t\tpublic static Dictionary<{dataProcessorT1.LanguageKeyword},{dataProcessorT2.LanguageKeyword}> Parse{dataProcessorT1.Type.Name}{dataProcessorT2.Type.Name}Dictionary(string value)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tif (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals(\"null\"))");
                sb.AppendLine("\t\t\t\treturn null;");
                sb.AppendLine("\t\t\tstring[] splitValue = value.Split('|');");
                sb.AppendLine(
                    $"\t\t\tDictionary<{dataProcessorT1.LanguageKeyword},{dataProcessorT2.LanguageKeyword}> dictionary = new Dictionary<{dataProcessorT1.LanguageKeyword},{dataProcessorT2.LanguageKeyword}>(splitValue.Length);");
                sb.AppendLine("\t\t\tfor (int i = 0; i < splitValue.Length; i++)");
                sb.AppendLine("\t\t\t{");
                sb.AppendLine("\t\t\t\tstring[] keyValue = splitValue[i].Split('#');");
                if (dataProcessorT1.IsSystem)
                {
                    if (dataProcessorT2.IsSystem)
                    {
                        if (dataProcessorT1.LanguageKeyword == "string" && dataProcessorT2.LanguageKeyword == "string")
                            sb.AppendLine(
                                "\t\t\t\tdictionary.Add(keyValue[0].Substring(1),keyValue[1].Substring(0, keyValue[1].Length - 1));");
                        else if (dataProcessorT1.LanguageKeyword == "string")
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add(keyValue[0].Substring(1),{dataProcessorT2.Type.Name}.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));");
                        else if (dataProcessorT2.LanguageKeyword == "string")
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add({dataProcessorT1.Type.Name}.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));");
                        else
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add({dataProcessorT1.Type.Name}.Parse(keyValue[0].Substring(1)),{dataProcessorT2.Type.Name}.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));");
                    }
                    else
                    {
                        if (dataProcessorT1.LanguageKeyword == "string")
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add(keyValue[0].Substring(1),Parse{dataProcessorT2.Type.Name}(keyValue[1].Substring(0, keyValue[1].Length - 1)));");
                        else
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add({dataProcessorT1.Type.Name}.Parse(keyValue[0].Substring(1)),Parse{dataProcessorT2.Type.Name}(keyValue[1].Substring(0, keyValue[1].Length - 1)));");
                    }
                }
                else
                {
                    if (dataProcessorT2.IsSystem)
                    {
                        if (dataProcessorT2.LanguageKeyword == "string")
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add(Parse{dataProcessorT1.Type.Name}(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));");
                        else
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add(Parse{dataProcessorT1.Type.Name}(keyValue[0].Substring(1)),{dataProcessorT2.Type.Name}.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));");
                    }
                    else
                    {
                        sb.AppendLine(
                            $"\t\t\t\tdictionary.Add(Parse{dataProcessorT1.Type.Name}(keyValue[0].Substring(1)),Parse{dataProcessorT2.Type.Name}(keyValue[1].Substring(0, keyValue[1].Length - 1)));");
                    }
                }

                sb.AppendLine("\t\t\t}");
                sb.AppendLine("\t\t\treturn dictionary;");
                sb.AppendLine("\t\t}");
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");
            GenerateCodeFile("DataTableExtension.Dictionary", sb.ToString());
        }


        private static void GenerateBinaryReaderExtensionDictionary(
            IDictionary<string, DataTableProcessor.DataProcessor> dataProcessors)
        {
            var keyValueList =
                PermutationAndCombination<DataTableProcessor.DataProcessor>
                    .GetCombination(dataProcessors.Values.ToArray(), 2).ToList();
            foreach (var dataProcessor in dataProcessors.Values) keyValueList.Add(new[] {dataProcessor, dataProcessor});

            var sb = new StringBuilder();
            sb.AppendLine("using UnityEngine;");
            sb.AppendLine("using System.IO;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class BinaryReaderExtension");
            sb.AppendLine("\t{");
            foreach (var item in keyValueList)
            {
                var dataProcessorT1 = item[0];
                var dataProcessorT2 = item[1];
                sb.AppendLine(
                    $"\t\tpublic static Dictionary<{dataProcessorT1.LanguageKeyword},{dataProcessorT2.LanguageKeyword}> Read{dataProcessorT1.Type.Name}{dataProcessorT2.Type.Name}Dictionary(this BinaryReader binaryReader)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tint count = binaryReader.Read7BitEncodedInt32();");
                sb.AppendLine(
                    $"\t\t\tDictionary<{dataProcessorT1.LanguageKeyword},{dataProcessorT2.LanguageKeyword}> dictionary = new Dictionary<{dataProcessorT1.LanguageKeyword},{dataProcessorT2.LanguageKeyword}>(count);");
                sb.AppendLine("\t\t\tfor (int i = 0; i < count; i++)");
                sb.AppendLine("\t\t\t{");
                var t1LanguageKeyword = dataProcessorT1.LanguageKeyword;
                var t2LanguageKeyword = dataProcessorT2.LanguageKeyword;

                if (dataProcessorT1.IsSystem && dataProcessorT1.Type != typeof(DateTime))
                {
                    if (dataProcessorT2.IsSystem && dataProcessorT2.Type != typeof(DateTime))
                    {
                        if (t1LanguageKeyword == "int" || t1LanguageKeyword == "uint" || t1LanguageKeyword == "long" ||
                            t1LanguageKeyword == "ulong")
                        {
                            if (t2LanguageKeyword == "int" || t2LanguageKeyword == "uint" ||
                                t2LanguageKeyword == "long" || t2LanguageKeyword == "ulong")
                                sb.AppendLine(
                                    $"\t\t\t\tdictionary.Add(binaryReader.Read7BitEncoded{dataProcessorT1.Type.Name}(),binaryReader.Read7BitEncoded{dataProcessorT2.Type.Name}());");
                            else
                                sb.AppendLine(
                                    $"\t\t\t\tdictionary.Add(binaryReader.Read7BitEncoded{dataProcessorT1.Type.Name}(),binaryReader.Read{dataProcessorT2.Type.Name}());");
                        }
                        else
                        {
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add(binaryReader.Read{dataProcessorT1.Type.Name}(),binaryReader.Read{dataProcessorT2.Type.Name}());");
                        }
                    }
                    else
                    {
                        if (t1LanguageKeyword == "int" || t1LanguageKeyword == "uint" || t1LanguageKeyword == "long" ||
                            t1LanguageKeyword == "ulong")
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add(binaryReader.Read7BitEncoded{dataProcessorT1.Type.Name}(), Read{dataProcessorT2.LanguageKeyword}(binaryReader));");
                        else
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add(binaryReader.Read{dataProcessorT1.Type.Name}(),Read{dataProcessorT2.LanguageKeyword}(binaryReader));");
                    }
                }
                else
                {
                    if (dataProcessorT2.IsSystem && dataProcessorT2.Type != typeof(DateTime))
                    {
                        if (t2LanguageKeyword == "int" || t2LanguageKeyword == "uint" ||
                            t2LanguageKeyword == "long" ||
                            t2LanguageKeyword == "ulong")
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add(Read{dataProcessorT1.LanguageKeyword}(binaryReader),binaryReader.Read7BitEncoded{dataProcessorT2.Type.Name}());");
                        else
                            sb.AppendLine(
                                $"\t\t\t\tdictionary.Add(Read{dataProcessorT1.LanguageKeyword}(binaryReader),binaryReader.Read{dataProcessorT2.Type.Name}());");
                    }
                    else
                    {
                        sb.AppendLine(
                            $"\t\t\t\tdictionary.Add(Read{dataProcessorT1.LanguageKeyword}(binaryReader),Read{dataProcessorT2.LanguageKeyword}(binaryReader));");
                    }
                }

                sb.AppendLine("\t\t\t}");
                sb.AppendLine("\t\t\treturn dictionary;");
                sb.AppendLine("\t\t}");
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");
            GenerateCodeFile("BinaryReaderExtension.Dictionary", sb.ToString());
        }

        public static List<Type> GetTypeNames(Type typeBase)
        {
            var typeNames = new List<Type>();
            foreach (var assemblyName in EditorAssemblyNames)
            {
                Assembly assembly = null;
                try
                {
                    assembly = Assembly.Load(assemblyName);
                }
                catch
                {
                    continue;
                }

                if (assembly == null) continue;

                var types = assembly.GetTypes();
                foreach (var type in types)
                    if (type.IsClass && !type.IsAbstract && typeBase.IsAssignableFrom(type))
                        typeNames.Add(type);
            }

            return typeNames;
        }

        public static bool IsCustomType(Type type)
        {
            return type != typeof(object) && Type.GetTypeCode(type) == TypeCode.Object;
        }
    }
}