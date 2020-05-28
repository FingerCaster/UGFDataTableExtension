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
        private static UGFDataTableProcessor.DataProcessor[] m_DataProcessor;

        public static void SetDataTableProcessor(UGFDataTableProcessor dataTableProcessor)
        {
            m_UGFDataTableProcessor = dataTableProcessor;
            Type type = typeof(UGFDataTableProcessor);
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic |
                                                    BindingFlags.GetField | BindingFlags.Static |
                                                    BindingFlags.Instance);
            FieldInfo dataProcessorFieldInfo = null;
            FieldInfo typeRowFieldInfo = null;
            FieldInfo stringsFieldInfo = null;
            FieldInfo rawValuesFieldInfo = null;
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                if (fieldInfo.Name == "m_DataProcessor")
                {
                    dataProcessorFieldInfo = fieldInfo;
                }

                if (fieldInfo.Name == "m_TypeRow")
                {
                    typeRowFieldInfo = fieldInfo;
                }

                if (fieldInfo.Name == "m_Strings")
                {
                    stringsFieldInfo = fieldInfo;
                }

                if (fieldInfo.Name == "m_RawValues")
                {
                    rawValuesFieldInfo = fieldInfo;
                }
            }

            string[] typeRow = typeRowFieldInfo.GetValue(m_UGFDataTableProcessor) as string[];
            string[] strings = stringsFieldInfo.GetValue(m_UGFDataTableProcessor) as string[];
            string[][] rawValues = rawValuesFieldInfo.GetValue(m_UGFDataTableProcessor) as string[][];

            m_DataProcessor = new UGFDataTableProcessor.DataProcessor[m_UGFDataTableProcessor.RawColumnCount];
            for (int i = 0; i < m_DataProcessor.Length; i++)
            {
                if (i == m_UGFDataTableProcessor.IdColumn)
                {
                    m_DataProcessor[i] = DataProcessorUtility.GetDataProcessor("id");
                }
                else
                {
                    m_DataProcessor[i] = DataProcessorUtility.GetDataProcessor(typeRow[i]);
                }
            }
            dataProcessorFieldInfo.SetValue(m_UGFDataTableProcessor, m_DataProcessor);

            Dictionary<string, int> newStrings = new Dictionary<string, int>();
            for (int i = m_UGFDataTableProcessor.ContentStartRow; i < m_UGFDataTableProcessor.RawRowCount; i++)
            {
                if (m_UGFDataTableProcessor.IsCommentRow(i))
                {
                    continue;
                }

                for (int j = 0; j < m_UGFDataTableProcessor.RawColumnCount; j++)
                {
                    if (m_DataProcessor[j].LanguageKeyword != "string")
                    {
                        continue;
                    }

                    string str = rawValues[i][j];
                    if (newStrings.ContainsKey(str))
                    {
                        newStrings[str]++;
                    }
                    else
                    {
                        newStrings[str] = 1;
                    }
                }
            }

            stringsFieldInfo.SetValue(m_UGFDataTableProcessor,
                newStrings.OrderBy(value => value.Key).OrderByDescending(value => value.Value).Select(value => value.Key)
                    .ToArray());
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
    }
}