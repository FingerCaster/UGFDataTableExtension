using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GameFramework;
using UnityEngine;
using UGFDataTableProcessor = UnityGameFramework.Editor.DataTableTools.DataTableProcessor;

namespace DE.Editor
{
    public static class DataProcessorUtility
    {
        private static IDictionary<string, UGFDataTableProcessor.DataProcessor> s_DataProcessors =
            new SortedDictionary<string, UGFDataTableProcessor.DataProcessor>();

        static DataProcessorUtility()
        {
            System.Type dataProcessorBaseType = typeof(UGFDataTableProcessor.DataProcessor);

            List<System.Type> types = DataTableProcessorHelper.GetTypeNames(dataProcessorBaseType);
            List<System.Type> addList = new List<System.Type>();

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
                    foreach (string typeString in dataProcessor.GetTypeStrings())
                    {
                        s_DataProcessors.Add(typeString.ToLower(), dataProcessor);
                    }

                    addList.Add(types[i]);
                }
            }

            AddListType(addList);
            AddArrayType(addList);
        }

        private static void AddArrayType(List<System.Type> addList)
        {
            System.Type dataProcessorBaseType = typeof(UGFDataTableProcessor.DataProcessor);

            System.Type type = typeof(ArrayProcessor<,>);

            for (int i = 0; i < addList.Count; i++)
            {
                if (!addList[i].HasImplementedRawGeneric(typeof(UGFDataTableProcessor.GenericDataProcessor<>)))
                {
                    continue;
                }

                var memberInfo = addList[i].BaseType;

                if (memberInfo != null)
                {
                    System.Type[] typeArgs =
                    {
                        addList[i],
                        memberInfo.GenericTypeArguments[0]
                    };
                    System.Type listType = type.MakeGenericType(typeArgs);
                    if (dataProcessorBaseType.IsAssignableFrom(listType))
                    {
                        UGFDataTableProcessor.DataProcessor dataProcessor =
                            (UGFDataTableProcessor.DataProcessor) Activator.CreateInstance(listType);
                        UGFDataTableProcessor.DataProcessor tDataProcessor =
                            (UGFDataTableProcessor.DataProcessor) Activator.CreateInstance(addList[i]);
                        foreach (string typeString in dataProcessor.GetTypeStrings())
                        {
                            foreach (var tTypeString in tDataProcessor.GetTypeStrings())
                            {
                                string key = Utility.Text.Format(typeString.ToLower(), tTypeString);
                                s_DataProcessors.Add(key, dataProcessor);
                            }
                        }
                    }
                }
            }
        }

        private static void AddListType(List<System.Type> addList)
        {
            System.Type dataProcessorBaseType = typeof(UGFDataTableProcessor.DataProcessor);

            System.Type type = typeof(ListProcessor<,>);

            for (int i = 0; i < addList.Count; i++)
            {
                if (!addList[i].HasImplementedRawGeneric(typeof(UGFDataTableProcessor.GenericDataProcessor<>)))
                {
                    continue;
                }

                var memberInfo = addList[i].BaseType;

                if (memberInfo != null)
                {
                    System.Type[] typeArgs =
                    {
                        addList[i],
                        memberInfo.GenericTypeArguments[0]
                    };
                    System.Type listType = type.MakeGenericType(typeArgs);
                    if (dataProcessorBaseType.IsAssignableFrom(listType))
                    {
                        UGFDataTableProcessor.DataProcessor dataProcessor =
                            (UGFDataTableProcessor.DataProcessor) Activator.CreateInstance(listType);
                        UGFDataTableProcessor.DataProcessor tDataProcessor =
                            (UGFDataTableProcessor.DataProcessor) Activator.CreateInstance(addList[i]);
                        foreach (string typeString in dataProcessor.GetTypeStrings())
                        {
                            foreach (var tTypeString in tDataProcessor.GetTypeStrings())
                            {
                                string key = Utility.Text.Format(typeString.ToLower(), tTypeString);
                                s_DataProcessors.Add(key, dataProcessor);
                            }
                        }
                    }
                }
            }
        }

        public static UGFDataTableProcessor.DataProcessor GetDataProcessor(string type)
        {
            if (type == null)
            {
                type = string.Empty;
            }

            UGFDataTableProcessor.DataProcessor dataProcessor = null;
            if (s_DataProcessors.TryGetValue(type.ToLower(), out dataProcessor))
            {
                return dataProcessor;
            }

            throw new GameFrameworkException(Utility.Text.Format("Not supported data processor type '{0}'.", type));
        }
    }
}