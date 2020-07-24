using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DE.Editor.DataTableTools;
using GameFramework;
using UnityEngine;
namespace DE.Editor.DataTableTools
{
    public sealed partial class DataTableProcessor
    {
        public static class DataProcessorUtility
        {
            private static IDictionary<string, DataTableProcessor.DataProcessor> s_DataProcessors =
                new SortedDictionary<string, DataTableProcessor.DataProcessor>();

            static DataProcessorUtility()
            {
                System.Type dataProcessorBaseType = typeof(DataTableProcessor.DataProcessor);

                System.Type[] types =  Assembly.GetExecutingAssembly().GetTypes();;
                List<System.Type> addList = new List<System.Type>();

                for (int i = 0; i < types.Length; i++)
                {
                    if (!types[i].IsClass || types[i].IsAbstract || types[i].ContainsGenericParameters)
                    {
                        continue;
                    }

                    if (dataProcessorBaseType.IsAssignableFrom(types[i]))
                    {
                        DataTableProcessor.DataProcessor dataProcessor = null;
                        dataProcessor = (DataTableProcessor.DataProcessor) Activator.CreateInstance(types[i]);
                        foreach (string typeString in dataProcessor.GetTypeStrings())
                        {
                            s_DataProcessors.Add(typeString.ToLower(), dataProcessor);
                        }

                        addList.Add(types[i]);
                    }
                }


                AddListType(addList);
                AddArrayType(addList);
                AddDictionary(addList);
            }

            private static void AddArrayType(List<System.Type> addList)
            {
                System.Type dataProcessorBaseType = typeof(DataTableProcessor.DataProcessor);

                System.Type type = typeof(DataTableProcessor.ArrayProcessor<,>);

                for (int i = 0; i < addList.Count; i++)
                {
                    if (!addList[i].HasImplementedRawGeneric(typeof(DataTableProcessor.GenericDataProcessor<>)))
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
                        System.Type arrayType = type.MakeGenericType(typeArgs);
                        if (dataProcessorBaseType.IsAssignableFrom(arrayType))
                        {
                            DataTableProcessor.DataProcessor dataProcessor =
                                (DataTableProcessor.DataProcessor) Activator.CreateInstance(arrayType);
                            DataTableProcessor.DataProcessor tDataProcessor =
                                (DataTableProcessor.DataProcessor) Activator.CreateInstance(addList[i]);
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
                System.Type dataProcessorBaseType = typeof(DataTableProcessor.DataProcessor);

                System.Type type = typeof(DataTableProcessor.ListProcessor<,>);

                for (int i = 0; i < addList.Count; i++)
                {
                    if (!addList[i].HasImplementedRawGeneric(typeof(DataTableProcessor.GenericDataProcessor<>)))
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
                            DataTableProcessor.DataProcessor dataProcessor =
                                (DataTableProcessor.DataProcessor) Activator.CreateInstance(listType);
                            DataTableProcessor.DataProcessor tDataProcessor =
                                (DataTableProcessor.DataProcessor) Activator.CreateInstance(addList[i]);
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

            private static void AddDictionary(List<System.Type> addList)
            {
                System.Type dataProcessorBaseType = typeof(DataTableProcessor.DataProcessor);

                System.Type type = typeof(DataTableProcessor.DictionaryProcessor<,,,>);
                List<Type> list = new List<Type>();
                for (int i = 0; i < addList.Count; i++)
                {
                    if (!addList[i].HasImplementedRawGeneric(typeof(DataTableProcessor.GenericDataProcessor<>)))
                    {
                        continue;
                    }

                    var memberInfo = addList[i].BaseType;

                    if (memberInfo != null)
                    {
                        list.Add(addList[i]);
                    }
                }



                List<Type[]> keyValueList = PermutationAndCombination<Type>.GetCombination(list.ToArray(), 2).ToList();
                foreach (Type value in list)
                {
                    keyValueList.Add(new[] {value, value});
                }

                foreach (Type[] keyValue in keyValueList)
                {
                    Type keyType = keyValue[0].BaseType;
                    Type valueType = keyValue[1].BaseType;
                    if (keyType != null && valueType != null)
                    {
                        System.Type[] typeArgs =
                        {
                            keyValue[0],
                            keyValue[1],
                            keyType.GenericTypeArguments[0],
                            valueType.GenericTypeArguments[0]
                        };
                        System.Type dictionaryType = type.MakeGenericType(typeArgs);
                        if (dataProcessorBaseType.IsAssignableFrom(dictionaryType))
                        {
                            DataTableProcessor.DataProcessor dataProcessor =
                                (DataTableProcessor.DataProcessor) Activator.CreateInstance(dictionaryType);
                            DataTableProcessor.DataProcessor keyDataProcessor =
                                (DataTableProcessor.DataProcessor) Activator.CreateInstance(keyValue[0]);
                            DataTableProcessor.DataProcessor valueDataProcessor =
                                (DataTableProcessor.DataProcessor) Activator.CreateInstance(keyValue[1]);
                            foreach (string typeString in dataProcessor.GetTypeStrings())
                            {
                                foreach (string key in keyDataProcessor.GetTypeStrings())
                                {
                                    foreach (string value in valueDataProcessor.GetTypeStrings())
                                    {
                                        string str = Utility.Text.Format(typeString.ToLower(), key, value);
                                        s_DataProcessors.Add(str, dataProcessor);
                                    }
                                }
                            }
                        }
                    }

                }
            }

            public static DataTableProcessor.DataProcessor GetDataProcessor(string type)
            {
                if (type == null)
                {
                    type = string.Empty;
                }

                DataTableProcessor.DataProcessor dataProcessor = null;
                if (s_DataProcessors.TryGetValue(type.ToLower(), out dataProcessor))
                {
                    return dataProcessor;
                }

                throw new GameFrameworkException(Utility.Text.Format("Not supported data processor type '{0}'.", type));
            }
        }
    }
}