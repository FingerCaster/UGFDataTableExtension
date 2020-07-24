//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2020-07-24 17:34:13.137
//------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace DE
{
    /// <summary>
    ///     测试表格生成。
    /// </summary>
    public class DRTestDictionary : DataRowBase
    {
        private int m_Id;

        /// <summary>
        ///     获取编号。
        /// </summary>
        public override int Id => m_Id;

        /// <summary>
        ///     获取测试字典(KeyType：int ValueType:Int)。
        /// </summary>
        public Dictionary<int, int> TestIntIntDictionary { get; private set; }

        /// <summary>
        ///     获取测试字典(KeyType：int ValueType:vector3)。
        /// </summary>
        public Dictionary<int, Vector3> TestIntVector3Dictionary { get; private set; }

        public override bool ParseDataRow(string dataRowString, object userData)
        {
            var columnStrings = dataRowString.Split(DataTableExtension.DataSplitSeparators);
            for (var i = 0; i < columnStrings.Length; i++)
                columnStrings[i] = columnStrings[i].Trim(DataTableExtension.DataTrimSeparators);

            var index = 0;
            index++;
            m_Id = int.Parse(columnStrings[index++]);
            index++;
            TestIntIntDictionary = DataTableExtension.ParseInt32Int32Dictionary(columnStrings[index++]);
            TestIntVector3Dictionary = DataTableExtension.ParseInt32Vector3Dictionary(columnStrings[index++]);
            GeneratePropertyArray();
            return true;
        }

        public override bool ParseDataRow(byte[] dataRowBytes, int startIndex, int length, object userData)
        {
            using (var memoryStream = new MemoryStream(dataRowBytes, startIndex, length, false))
            {
                using (var binaryReader = new BinaryReader(memoryStream, Encoding.UTF8))
                {
                    m_Id = binaryReader.Read7BitEncodedInt32();
                    TestIntIntDictionary = binaryReader.ReadInt32Int32Dictionary();
                    TestIntVector3Dictionary = binaryReader.ReadInt32Vector3Dictionary();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private void GeneratePropertyArray()
        {
        }
    }
}