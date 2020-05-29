using System;
using System.Collections.Generic;
using System.IO;
using UGFDataTableProcessor =  UnityGameFramework.Editor.DataTableTools.DataTableProcessor;


namespace DE.Editor
{
    public sealed class ListProcessor<T,K> : UGFDataTableProcessor.DataProcessor ,ICollectionProcessor where T : UGFDataTableProcessor.GenericDataProcessor<K>
    {
        public override bool IsComment => false;

        public override bool IsSystem
        {
            get { return false; }
        }

        public Type ItemType
        {
            get
            {
                UGFDataTableProcessor.DataProcessor dataProcessor = Activator.CreateInstance(typeof(T)) as T;
                return dataProcessor.Type;
            }
        }

        public string ItemLanguageKeyword {
            get
            {
                UGFDataTableProcessor.DataProcessor dataProcessor = Activator.CreateInstance(typeof(T)) as T;
                return dataProcessor.LanguageKeyword;
            }
        }

        public override System.Type Type
        {
            get
            {
                if (!(Activator.CreateInstance(typeof(T)) is T t)) return typeof(List<T>);
                System.Type type = typeof(List<>);
                type = type.MakeGenericType(t.Type);
                return type;
            }
        }

        public override bool IsId => false;
        
        public override string LanguageKeyword
        {
            get
            {
                if (Activator.CreateInstance(typeof(T)) is T t)
                {
                    return $"List<{t.LanguageKeyword}>";
                }

                return $"List<{typeof(T)}>";
            }
        }
        public override string[] GetTypeStrings()
        {
            return new string[]
            {
                "List<{0}>",
                "System.Collections.Generic.List<{0}>"
            };
        }

        public override void WriteToStream(UGFDataTableProcessor UGFDataTableProcessor, BinaryWriter binaryWriter, string value)
        {
            UGFDataTableProcessor.DataProcessor dataProcessor = Activator.CreateInstance(typeof(T)) as T;
            string[] splitValues = value.Split('|');
            binaryWriter.Write7BitEncodedInt32(splitValues.Length);
            foreach (string itemValue in splitValues)
            {
                dataProcessor.WriteToStream(UGFDataTableProcessor, binaryWriter, itemValue);
            }
        }

    }
}