﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System.IO;

namespace DE.Editor.DataTableTools
{
    public sealed partial class DataTableProcessor
    {
        private sealed class UIntProcessor : GenericDataProcessor<uint>
        {
            public override bool IsSystem => true;

            public override string LanguageKeyword => "uint";

            public override string[] GetTypeStrings()
            {
                return new[]
                {
                    "uint",
                    "uint32",
                    "system.uint32"
                };
            }

            public override uint Parse(string value)
            {
                return uint.Parse(value);
            }

            public override void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter,
                string value)
            {
                binaryWriter.Write7BitEncodedUInt32(Parse(value));
            }
        }
    }
}