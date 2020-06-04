using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UGFDataTableProcessor = UnityGameFramework.Editor.DataTableTools.DataTableProcessor;

namespace DE.Editor
{
    public class ArrayProcessor<T, K> : UGFDataTableProcessor.DataProcessor, ICollectionProcessor
        where T : UGFDataTableProcessor.GenericDataProcessor<K>,new()
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

        public Type ItemType
        {
            get
            {
                UGFDataTableProcessor.DataProcessor dataProcessor = Activator.CreateInstance(typeof(T)) as T;
                return dataProcessor.Type;
            }
        }

        public string ItemLanguageKeyword
        {
            get
            {
                UGFDataTableProcessor.DataProcessor dataProcessor = Activator.CreateInstance(typeof(T)) as T;
                return dataProcessor.LanguageKeyword;
            }
        }

        public override bool IsId => false;

        public override string LanguageKeyword
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

        public override void WriteToStream(UGFDataTableProcessor UGFDataTableProcessor, BinaryWriter binaryWriter,
            string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
            {
                binaryWriter.Write7BitEncodedInt32(0);
                return;
            }
            UGFDataTableProcessor.DataProcessor dataProcessor = new T();
            string[] splitValues;
            splitValues = value.Split(dataProcessor.IsSystem ? ',' :  '|');

            binaryWriter.Write7BitEncodedInt32(splitValues.Length);
            foreach (string itemValue in splitValues)
            {
                dataProcessor.WriteToStream(UGFDataTableProcessor, binaryWriter, itemValue);
            }
        }
    }
}