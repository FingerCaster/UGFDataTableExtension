using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using GameFramework;
using UnityEngine;
using UnityGameFramework.Editor.DataTableTools;
using UGFDataTableProcessor = UnityGameFramework.Editor.DataTableTools.DataTableProcessor;

namespace DE.Editor
{
    public static class DataTableProcessorHelper
    {
        private static UGFDataTableProcessor m_UGFDataTableProcessor;
        private static readonly string DataTableTemplatePath = "Assets/Res/Configs/DataTableTemplate.txt";
        private static UGFDataTableProcessor.DataProcessor[] m_DataProcessor;
        private const string CommentLineSeparator = "#";
        private static readonly char[] DataSplitSeparators = new char[] {'\t'};
        private static readonly char[] DataTrimSeparators = new char[] {'\"'};
        private static readonly Dictionary<string, FieldInfo> FieldInfos = new Dictionary<string, FieldInfo>();
        

        static DataTableProcessorHelper()
        {
            m_UGFDataTableProcessor = new UGFDataTableProcessor(
                Utility.Path.GetRegularPath(Path.Combine(DataTableTemplatePath)), Encoding.UTF8, 1, 2,
                null, 3, 4, 1);
            Type type = typeof(UGFDataTableProcessor);
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic |
                                                    BindingFlags.GetField | BindingFlags.Static |
                                                    BindingFlags.Instance);
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                FieldInfos.Add(fieldInfo.Name, fieldInfo);
            }

        }
        private static void SetValue(string filedName, object value)
        {
            FieldInfos.TryGetValue(filedName, out FieldInfo fieldInfo);
            fieldInfo?.SetValue(m_UGFDataTableProcessor, value);
        }

        private static object GetValue(string filedName)
        {
            FieldInfos.TryGetValue(filedName, out FieldInfo value);
            return value != null ? value.GetValue(m_UGFDataTableProcessor) : null;
        }

        public static UGFDataTableProcessor CreateDataTableProcessor(string dataTableFileName, Encoding encoding,
            int nameRow,
            int typeRow, int? defaultValueRow, int? commentRow, int contentStartRow, int idColumn)
        {
            if (string.IsNullOrEmpty(dataTableFileName))
            {
                throw new GameFrameworkException("Data table file name is invalid.");
            }

            if (!dataTableFileName.EndsWith(".txt"))
            {
                throw new GameFrameworkException(Utility.Text.Format("Data table file '{0}' is not a txt.",
                    dataTableFileName));
            }

            if (!File.Exists(dataTableFileName))
            {
                throw new GameFrameworkException(Utility.Text.Format("Data table file '{0}' is not exist.",
                    dataTableFileName));
            }

            string[] lines = File.ReadAllLines(dataTableFileName, encoding);
            int rawRowCount = lines.Length;

            int rawColumnCount = 0;
            List<string[]> rawValues = new List<string[]>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] rawValue = lines[i].Split(DataSplitSeparators);
                for (int j = 0; j < rawValue.Length; j++)
                {
                    rawValue[j] = rawValue[j].Trim(DataTrimSeparators);
                }

                if (i == 0)
                {
                    rawColumnCount = rawValue.Length;
                }
                else if (rawValue.Length != rawColumnCount)
                {
                    throw new GameFrameworkException(Utility.Text.Format(
                        "Data table file '{0}', raw Column is '{2}', but line '{1}' column is '{3}'.",
                        dataTableFileName, i.ToString(), rawColumnCount.ToString(), rawValue.Length.ToString()));
                }

                rawValues.Add(rawValue);
            }
            SetValue("m_RawValues",rawValues.ToArray());
            if (nameRow < 0)
            {
                throw new GameFrameworkException(Utility.Text.Format("Name row '{0}' is invalid.", nameRow.ToString()));
            }

            if (typeRow < 0)
            {
                throw new GameFrameworkException(Utility.Text.Format("Type row '{0}' is invalid.", typeRow.ToString()));
            }

            if (contentStartRow < 0)
            {
                throw new GameFrameworkException(Utility.Text.Format("Content start row '{0}' is invalid.",
                    contentStartRow.ToString()));
            }

            if (idColumn < 0)
            {
                throw new GameFrameworkException(
                    Utility.Text.Format("Id column '{0}' is invalid.", idColumn.ToString()));
            }

            if (nameRow >= rawRowCount)
            {
                throw new GameFrameworkException(Utility.Text.Format(
                    "Name row '{0}' >= raw row count '{1}' is not allow.", nameRow.ToString(), rawRowCount.ToString()));
            }

            if (typeRow >= rawRowCount)
            {
                throw new GameFrameworkException(Utility.Text.Format(
                    "Type row '{0}' >= raw row count '{1}' is not allow.", typeRow.ToString(), rawRowCount.ToString()));
            }

            if (defaultValueRow.HasValue && defaultValueRow.Value >= rawRowCount)
            {
                throw new GameFrameworkException(Utility.Text.Format(
                    "Default value row '{0}' >= raw row count '{1}' is not allow.", defaultValueRow.Value.ToString(),
                    rawRowCount.ToString()));
            }

            if (commentRow.HasValue && commentRow.Value >= rawRowCount)
            {
                throw new GameFrameworkException(Utility.Text.Format(
                    "Comment row '{0}' >= raw row count '{1}' is not allow.", commentRow.Value.ToString(),
                    rawRowCount.ToString()));
            }

            if (contentStartRow > rawRowCount)
            {
                throw new GameFrameworkException(Utility.Text.Format(
                    "Content start row '{0}' > raw row count '{1}' is not allow.", contentStartRow.ToString(),
                    rawRowCount.ToString()));
            }

            if (idColumn >= rawColumnCount)
            {
                throw new GameFrameworkException(Utility.Text.Format(
                    "Id column '{0}' >= raw column count '{1}' is not allow.", idColumn.ToString(),
                    rawColumnCount.ToString()));
            }
            string[][] UGFDataTableProcessorRawValues = GetValue("m_RawValues") as string[][];

            SetValue("m_NameRow", UGFDataTableProcessorRawValues[nameRow]);
            SetValue("m_TypeRow", UGFDataTableProcessorRawValues[typeRow]);
            SetValue("m_DefaultValueRow",
                defaultValueRow.HasValue ? UGFDataTableProcessorRawValues[defaultValueRow.Value] : null);
            SetValue("m_CommentRow", commentRow.HasValue ? UGFDataTableProcessorRawValues[commentRow.Value] : null);
            SetValue("m_ContentStartRow", contentStartRow);
            SetValue("m_IdColumn", idColumn);
            
          //  string[] UGFDataTableProcessorNameRow = GetValue("m_NameRow") as string[];
            string[] UGFDataTableProcessorTypeRow = GetValue("m_TypeRow") as string[];
//            string[] UGFDataTableProcessorDefaultValueRow = GetValue("m_DefaultValueRow") as string[];
//            string[] UGFDataTableProcessorCommentRow = GetValue("m_CommentRow") as string[];
//            int UGFDataTableProcessorContentStartRow = (int) GetValue("m_ContentStartRow");
//            int UGFDataTableProcessorIdColumn = (int) GetValue("m_IdColumn");
//            DataTableProcessor.DataProcessor[] UGFDataTableProcessorDataProcessor =
//                GetValue("m_DataProcessor") as DataTableProcessor.DataProcessor[];
//            string[] UGFDataTableProcessorStrings = GetValue("m_Strings") as string[];
//            string UGFDataTableProcessorCodeTemplate = GetValue("m_CodeTemplate") as string;
//            DataTableCodeGenerator UGFDataTableProcessorCodeGenerator =
//                GetValue("m_CodeGenerator") as DataTableCodeGenerator;

          


            m_DataProcessor = new DataTableProcessor.DataProcessor[rawColumnCount];
            for (int i = 0; i < rawColumnCount; i++)
            {
                if (i == m_UGFDataTableProcessor.IdColumn)
                {
                    m_DataProcessor[i] = DataProcessorUtility.GetDataProcessor("id");
                }
                else
                {
                    try
                    {
                        m_DataProcessor[i] = DataProcessorUtility.GetDataProcessor(UGFDataTableProcessorTypeRow[i]);

                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.Log($"出错的位置{i}");
                        throw;
                    }
                }
            }

            SetValue("m_DataProcessor", m_DataProcessor);
            Dictionary<string, int> strings = new Dictionary<string, int>();
            for (int i = contentStartRow; i < rawRowCount; i++)
            {
                if (m_UGFDataTableProcessor.IsCommentRow(i))
                {
                    continue;
                }

                for (int j = 0; j < rawColumnCount; j++)
                {
                    ICollectionProcessor collectionProcessor = m_DataProcessor[j] as  ICollectionProcessor;

                    if (collectionProcessor != null)
                    {
                        if (collectionProcessor.ItemLanguageKeyword != "string")
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (m_DataProcessor[j].LanguageKeyword != "string")
                        {
                            continue;
                        }
                    }
                    

                    string str = UGFDataTableProcessorRawValues[i][j];
                    string[] values = str.Split('|');
                    foreach (string value in values)
                    {
                        if (strings.ContainsKey(value))
                        {
                            strings[value]++;
                        }
                        else
                        {
                            strings[value] = 1;
                        }
                    }
                }
            }

            SetValue("m_Strings", strings.OrderBy(value => value.Key).OrderByDescending(value => value.Value).Select(
                value => value.Key).ToArray());
            SetValue("m_CodeTemplate", null);
            SetValue("m_CodeGenerator", null);
            return m_UGFDataTableProcessor;
        }
        
        public static bool IsListColumn(int rawColumn)
        {
            if (rawColumn < 0 || rawColumn >= m_UGFDataTableProcessor.RawColumnCount)
            {
                throw new GameFrameworkException(Utility.Text.Format("Raw column '{0}' is out of range.",
                    rawColumn.ToString()));
            }

            return m_DataProcessor[rawColumn].GetTypeStrings()[0].Equals("List<{0}>");
        }

        public static bool IsArrayColumn(int rawColumn)
        {
            if (rawColumn < 0 || rawColumn >= m_UGFDataTableProcessor.RawColumnCount)
            {
                throw new GameFrameworkException(Utility.Text.Format("Raw column '{0}' is out of range.",
                    rawColumn.ToString()));
            }

            return m_DataProcessor[rawColumn].GetTypeStrings()[0].Equals("{0}[]");
        }

        public static UGFDataTableProcessor.DataProcessor GetDataProcessor(int rawColumn)
        {
            return m_DataProcessor[rawColumn];
        }
      

        
        private static readonly string[] EditorAssemblyNames =
        {
#if UNITY_2017_3_OR_NEWER
            "UnityGameFramework.Editor",
            "DE.Editor",
#endif
            "Assembly-CSharp-Editor"
        };

        public static List<Type> GetTypeNames(System.Type typeBase)
        {
            List<Type> typeNames = new List<Type>();
            foreach (string assemblyName in EditorAssemblyNames)
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

                if (assembly == null)
                {
                    continue;
                }

                System.Type[] types = assembly.GetTypes();
                foreach (System.Type type in types)
                {
                    if (type.IsClass && !type.IsAbstract && typeBase.IsAssignableFrom(type))
                    {
                        typeNames.Add(type);
                    }
                }
            }

            return typeNames;
        }
        
        public static bool IsCustomType(Type type)
        {
            return (type != typeof(object) && Type.GetTypeCode(type) == TypeCode.Object);
        }
    }
}