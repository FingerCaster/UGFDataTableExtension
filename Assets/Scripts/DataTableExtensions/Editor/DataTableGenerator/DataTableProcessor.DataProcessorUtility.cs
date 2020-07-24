using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GameFramework;
namespace DE.Editor.DataTableTools
{
    public sealed partial class DataTableProcessor
    {
        public static class DataProcessorUtility
        {
            private static IDictionary<string, DataProcessor> s_DataProcessors =
                new SortedDictionary<string, DataProcessor>();

            static DataProcessorUtility()
            {
                System.Type dataProcessorBaseType = typeof(DataProcessor);

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
                        DataProcessor dataProcessor = null;
                        dataProcessor = (DataProcessor) Activator.CreateInstance(types[i]);
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
                System.Type dataProcessorBaseType = typeof(DataProcessor);

                System.Type type = typeof(ArrayProcessor<,>);

                for (int i = 0; i < addList.Count; i++)
                {
                    if (!addList[i].HasImplementedRawGeneric(typeof(GenericDataProcessor<>)))
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
                            DataProcessor dataProcessor =
                                (DataProcessor) Activator.CreateInstance(arrayType);
                            DataProcessor tDataProcessor =
                                (DataProcessor) Activator.CreateInstance(addList[i]);
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
                System.Type dataProcessorBaseType = typeof(DataProcessor);

                System.Type type = typeof(ListProcessor<,>);

                for (int i = 0; i < addList.Count; i++)
                {
                    if (!addList[i].HasImplementedRawGeneric(typeof(GenericDataProcessor<>)))
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
                            DataProcessor dataProcessor =
                                (DataProcessor) Activator.CreateInstance(listType);
                            DataProcessor tDataProcessor =
                                (DataProcessor) Activator.CreateInstance(addList[i]);
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
                System.Type dataProcessorBaseType = typeof(DataProcessor);

                System.Type type = typeof(DictionaryProcessor<,,,>);
                List<Type> list = new List<Type>();
                for (int i = 0; i < addList.Count; i++)
                {
                    if (!addList[i].HasImplementedRawGeneric(typeof(GenericDataProcessor<>)))
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
                            DataProcessor dataProcessor =
                                (DataProcessor) Activator.CreateInstance(dictionaryType);
                            DataProcessor keyDataProcessor =
                                (DataProcessor) Activator.CreateInstance(keyValue[0]);
                            DataProcessor valueDataProcessor =
                                (DataProcessor) Activator.CreateInstance(keyValue[1]);
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

            public static DataProcessor GetDataProcessor(string type)
            {
                if (type == null)
                {
                    type = string.Empty;
                }

                DataProcessor dataProcessor = null;
                if (s_DataProcessors.TryGetValue(type.ToLower(), out dataProcessor))
                {
                    return dataProcessor;
                }

                throw new GameFrameworkException(Utility.Text.Format("Not supported data processor type '{0}'.", type));
            }
        }
    }
}