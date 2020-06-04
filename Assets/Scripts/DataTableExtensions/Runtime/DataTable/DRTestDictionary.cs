//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2020-06-04 11:32:20.696
//------------------------------------------------------------

using GameFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace DE
{
    /// <summary>
    /// 测试表格生成。
    /// </summary>
    public class DRTestDictionary : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 获取测试字典(KeyType：int ValueType:Int)。
        /// </summary>
        public Dictionary<int,int> TestIntIntDictionary
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取测试字典(KeyType：int ValueType:vector3)。
        /// </summary>
        public Dictionary<int,Vector3> TestIntVector3Dictionary
        {
            get;
            private set;
        }

        public override bool ParseDataRow(GameFrameworkDataSegment dataRowSegment, object dataTableUserData)
        {
            Type dataType = dataRowSegment.DataType;
            if (dataType == typeof(string))
            {
                string[] columnTexts = ((string)dataRowSegment.Data).Substring(dataRowSegment.Offset, dataRowSegment.Length).Split(DataTableExtension.DataSplitSeparators);
                for (int i = 0; i < columnTexts.Length; i++)
                {
                    columnTexts[i] = columnTexts[i].Trim(DataTableExtension.DataTrimSeparators);
                }

                int index = 0;
                index++;
                m_Id = int.Parse(columnTexts[index++]);
                index++;
				TestIntIntDictionary = DataTableExtension.ParseInt32Int32Dictionary(columnTexts[index++]);
				TestIntVector3Dictionary = DataTableExtension.ParseInt32Vector3Dictionary(columnTexts[index++]);
            }
            else if (dataType == typeof(byte[]))
            {
                string[] strings = (string[])dataTableUserData;
                using (MemoryStream memoryStream = new MemoryStream((byte[])dataRowSegment.Data, dataRowSegment.Offset, dataRowSegment.Length, false))
                {
                    using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.UTF8))
                    {
                        m_Id = binaryReader.Read7BitEncodedInt32();
						TestIntIntDictionary = binaryReader.ReadInt32Int32Dictionary();
						TestIntVector3Dictionary = binaryReader.ReadInt32Vector3Dictionary();
                    }
                }
            }
            else
            {
                Log.Warning("Can not parse data row which type '{0}' is invalid.", dataType.FullName);
                return false;
            }

            GeneratePropertyArray();
            return true;
        }

        private void GeneratePropertyArray()
        {

        }
    }
}
