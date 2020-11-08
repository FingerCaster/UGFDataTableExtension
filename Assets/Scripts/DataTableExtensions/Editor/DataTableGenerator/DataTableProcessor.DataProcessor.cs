﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using System.IO;

namespace DE.Editor.DataTableTools
{
    public sealed partial class DataTableProcessor
    {
        public abstract class DataProcessor
        {
            public abstract Type Type { get; }

            public abstract bool IsId { get; }

            public abstract bool IsComment { get; }

            public abstract bool IsSystem { get; }
            public abstract bool IsEnum { get; }

            public abstract string LanguageKeyword { get; }

            public abstract string[] GetTypeStrings();

            public abstract void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter,
                string value);
        }
    }
}