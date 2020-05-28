using System;
using System.Collections.Generic;
using System.IO;
using UGFDataTableProcessor =  UnityGameFramework.Editor.DataTableTools.DataTableProcessor;
namespace DE.Editor
{
    public class ArrayProcessor<T,K>: UGFDataTableProcessor.DataProcessor where T : UGFDataTableProcessor.GenericDataProcessor<K>
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
                if (!(Activator.CreateInstance(typeof(T)) is T t))
                    return typeof(T[]);
                System.Type type = typeof(T[]);
                return type;
            }
        }

        public override bool IsId => false;

        public override string LanguageKeyword
        {
            get
            {
                return "string";
            }
        }
        public string RealLanguageKeyword
        {
            get
            {
                if (Activator.CreateInstance(typeof(T)) is T t)
                {
                    return $"{t.LanguageKeyword}[]";
                }

                return $"{typeof(T)}[]";
            }
        }

        public override string[] GetTypeStrings()
        {
            return new string[]
            {
                "{0}[]"
            };
        }

        public override void WriteToStream(UGFDataTableProcessor UGFDataTableProcessor, BinaryWriter binaryWriter, string value)
        {
            binaryWriter.Write(value);
        }
    }
}