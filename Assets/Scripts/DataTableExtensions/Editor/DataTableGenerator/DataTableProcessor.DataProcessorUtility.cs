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
            private static readonly IDictionary<string, DataProcessor> s_DataProcessors =
                new SortedDictionary<string, DataProcessor>();

            static DataProcessorUtility()
            {
                var dataProcessorBaseType = typeof(DataProcessor);

                var types = Assembly.GetExecutingAssembly().GetTypes();
                ;
                var addList = new List<Type>();

                for (var i = 0; i < types.Length; i++)
                {
                    if (!types[i].IsClass || types[i].IsAbstract || types[i].ContainsGenericParameters) continue;

                    if (dataProcessorBaseType.IsAssignableFrom(types[i]))
                    {
                        DataProcessor dataProcessor = null;
                        dataProcessor = (DataProcessor) Activator.CreateInstance(types[i]);
                        foreach (var typeString in dataProcessor.GetTypeStrings())
                            s_DataProcessors.Add(typeString.ToLower(), dataProcessor);

                        addList.Add(types[i]);
                    }
                }


                AddListType(addList);
                AddArrayType(addList);
                AddDictionary(addList);
            }

            private static void AddArrayType(List<Type> addList)
            {
                var dataProcessorBaseType = typeof(DataProcessor);

                var type = typeof(ArrayProcessor<,>);

                for (var i = 0; i < addList.Count; i++)
                {
                    if (!addList[i].HasImplementedRawGeneric(typeof(GenericDataProcessor<>))) continue;

                    var memberInfo = addList[i].BaseType;

                    if (memberInfo != null)
                    {
                        Type[] typeArgs =
                        {
                            addList[i],
                            memberInfo.GenericTypeArguments[0]
                        };
                        var arrayType = type.MakeGenericType(typeArgs);
                        if (dataProcessorBaseType.IsAssignableFrom(arrayType))
                        {
                            var dataProcessor =
                                (DataProcessor) Activator.CreateInstance(arrayType);
                            var tDataProcessor =
                                (DataProcessor) Activator.CreateInstance(addList[i]);
                            foreach (var typeString in dataProcessor.GetTypeStrings())
                            foreach (var tTypeString in tDataProcessor.GetTypeStrings())
                            {
                                var key = Utility.Text.Format(typeString.ToLower(), tTypeString);
                                s_DataProcessors.Add(key, dataProcessor);
                            }
                        }
                    }
                }
            }

            private static void AddListType(List<Type> addList)
            {
                var dataProcessorBaseType = typeof(DataProcessor);

                var type = typeof(ListProcessor<,>);

                for (var i = 0; i < addList.Count; i++)
                {
                    if (!addList[i].HasImplementedRawGeneric(typeof(GenericDataProcessor<>))) continue;

                    var memberInfo = addList[i].BaseType;

                    if (memberInfo != null)
                    {
                        Type[] typeArgs =
                        {
                            addList[i],
                            memberInfo.GenericTypeArguments[0]
                        };
                        var listType = type.MakeGenericType(typeArgs);
                        if (dataProcessorBaseType.IsAssignableFrom(listType))
                        {
                            var dataProcessor =
                                (DataProcessor) Activator.CreateInstance(listType);
                            var tDataProcessor =
                                (DataProcessor) Activator.CreateInstance(addList[i]);
                            foreach (var typeString in dataProcessor.GetTypeStrings())
                            foreach (var tTypeString in tDataProcessor.GetTypeStrings())
                            {
                                var key = Utility.Text.Format(typeString.ToLower(), tTypeString);
                                s_DataProcessors.Add(key, dataProcessor);
                            }
                        }
                    }
                }
            }

            private static void AddDictionary(List<Type> addList)
            {
                var dataProcessorBaseType = typeof(DataProcessor);

                var type = typeof(DictionaryProcessor<,,,>);
                var list = new List<Type>();
                for (var i = 0; i < addList.Count; i++)
                {
                    if (!addList[i].HasImplementedRawGeneric(typeof(GenericDataProcessor<>))) continue;

                    var memberInfo = addList[i].BaseType;

                    if (memberInfo != null) list.Add(addList[i]);
                }


                var keyValueList = PermutationAndCombination<Type>.GetCombination(list.ToArray(), 2).ToList();
                foreach (var value in list) keyValueList.Add(new[] {value, value});

                foreach (var keyValue in keyValueList)
                {
                    var keyType = keyValue[0].BaseType;
                    var valueType = keyValue[1].BaseType;
                    if (keyType != null && valueType != null)
                    {
                        Type[] typeArgs =
                        {
                            keyValue[0],
                            keyValue[1],
                            keyType.GenericTypeArguments[0],
                            valueType.GenericTypeArguments[0]
                        };
                        var dictionaryType = type.MakeGenericType(typeArgs);
                        if (dataProcessorBaseType.IsAssignableFrom(dictionaryType))
                        {
                            var dataProcessor =
                                (DataProcessor) Activator.CreateInstance(dictionaryType);
                            var keyDataProcessor =
                                (DataProcessor) Activator.CreateInstance(keyValue[0]);
                            var valueDataProcessor =
                                (DataProcessor) Activator.CreateInstance(keyValue[1]);
                            foreach (var typeString in dataProcessor.GetTypeStrings())
                            foreach (var key in keyDataProcessor.GetTypeStrings())
                            foreach (var value in valueDataProcessor.GetTypeStrings())
                            {
                                var str = Utility.Text.Format(typeString.ToLower(), key, value);
                                s_DataProcessors.Add(str, dataProcessor);
                            }
                        }
                    }
                }
            }

            public static DataProcessor GetDataProcessor(string type)
            {
                if (type == null) type = string.Empty;

                DataProcessor dataProcessor = null;
                if (s_DataProcessors.TryGetValue(type.ToLower(), out dataProcessor)) return dataProcessor;

                throw new GameFrameworkException(Utility.Text.Format("Not supported data processor type '{0}'.", type));
            }
        }
    }
}