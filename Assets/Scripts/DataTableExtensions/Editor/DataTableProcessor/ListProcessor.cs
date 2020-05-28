using System;
using System.Collections.Generic;
using System.IO;
using UGFDataTableProcessor =  UnityGameFramework.Editor.DataTableTools.DataTableProcessor;


namespace DE.Editor
{
    public sealed class ListProcessor<T,K> : UGFDataTableProcessor.DataProcessor where T : UGFDataTableProcessor.GenericDataProcessor<K>
    {
        public override bool IsComment => false;

        public override bool IsSystem
        {
            get { return false; }
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
            binaryWriter.Write(value);
        }
    }
}