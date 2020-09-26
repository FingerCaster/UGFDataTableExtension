using System;
using System.IO;

namespace DE.Editor.DataTableTools
{
    public sealed partial class DataTableProcessor
    {
        private sealed class EnumProcessor : GenericDataProcessor<int>
        {
            public Type EnumType { get; set; }
            public override bool IsSystem => false;
            public string NameSpace => EnumType.Namespace;
            public override string LanguageKeyword => EnumType.Name;

            public override string[] GetTypeStrings()
            {
                if (string.IsNullOrEmpty(EnumType.FullName) || EnumType.FullName == EnumType.Name)
                {
                    return new[] {EnumType.Name.ToLower()};
                }
                else
                {
                    return new[]
                    {
                        EnumType.Name.ToLower(),
                        EnumType.FullName.ToLower()
                    };
                }
            }

            public override int Parse(string value)
            {
                return int.Parse(value);
            }

            public override void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter,
                string value)
            {
                binaryWriter.Write7BitEncodedInt32(Parse(value));
            }
        }
    }
}