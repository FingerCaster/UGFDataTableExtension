using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UGFDataTableProcessor = UnityGameFramework.Editor.DataTableTools.DataTableProcessor;

namespace DE.Editor
{
    public class DictionaryProcessor<T1, T2, T3, T4> : UGFDataTableProcessor.DataProcessor,IDictionaryProcessor
        where T1 : UGFDataTableProcessor.GenericDataProcessor<T3>, new()
        where T2 : UGFDataTableProcessor.GenericDataProcessor<T4>, new()
    {
        public override Type Type
        {
            get
            {
                T1 t1 = new T1();
                T2 t2 = new T2();
                System.Type type = typeof(Dictionary<,>);
                type = type.MakeGenericType(t1.Type, t2.Type);
                return type;
            }
        }

        public override bool IsId
        {
            get { return false; }
        }

        public override bool IsComment
        {
            get { return false; }
        }

        public override bool IsSystem
        {
            get { return false; }
        }

        public override string LanguageKeyword
        {
            get
            {
                T1 t1 = new T1();
                T2 t2 = new T2();
                return $"Dictionary<{t1.LanguageKeyword},{t2.LanguageKeyword}>";
            }
        }

        public override string[] GetTypeStrings()
        {
            return new string[]
            {
                "Dictionary<{0},{1}>",
                "System.Collections.Generic.Dictionary<{0},{1}>"
            };
        }

        public override void WriteToStream(UGFDataTableProcessor dataTableProcessor, BinaryWriter binaryWriter,
            string value)
        {
            UGFDataTableProcessor.DataProcessor dataProcessor1 = new T1();
            UGFDataTableProcessor.DataProcessor dataProcessor2 = new T2();
            string[] splitValues = value.Split('|');
            binaryWriter.Write7BitEncodedInt32(splitValues.Length);
            foreach (string itemValue in splitValues)
            {
                string[] keyValue = itemValue.Split(',');
                dataProcessor1.WriteToStream(dataTableProcessor, binaryWriter, keyValue[0].Substring(1));
                dataProcessor1.WriteToStream(dataTableProcessor, binaryWriter,
                    keyValue[1].Substring(0, keyValue[1].Length - 1));
            }
        }
        public Type KeyType
        {
            get
            {
                T1 t1 = new T1();
                return t1.Type;
            }
        }

        public Type ValueType
        {
            get
            {
                T2 t2 = new T2();
                return t2.Type;
            }
        }

        public string KeyLanguageKeyword
        {
            get
            {
                T2 t2 = new T2();
                return t2.LanguageKeyword;
            }
        }

        public string ValueLanguageKeyword
        {
            get
            {
                T2 t2 = new T2();
                return t2.LanguageKeyword;
            }
        }
    }
}