﻿//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2020-11-09 00:18:15.363
//------------------------------------------------------------

using GameFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;
using Test;


namespace DE
{
    /// <summary>
    /// 测试表格生成。
    /// </summary>
    public class DRTestEnum : DataRowBase
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
        /// 获取测试枚举。
        /// </summary>
        public TestEnum TestEnum
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取测试枚举list。
        /// </summary>
        public List<TestEnum> TestEnumList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取测试枚举Array。
        /// </summary>
        public TestEnum[] TestEnumArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取测试枚举字典。
        /// </summary>
        public Dictionary<TestEnum,int> TestEnumDic
        {
            get;
            private set;
        }

        public override bool ParseDataRow(string dataRowString, object userData)
        {
            string[] columnStrings = dataRowString.Split(DataTableExtension.DataSplitSeparators);
            for (int i = 0; i < columnStrings.Length; i++)
            {
                columnStrings[i] = columnStrings[i].Trim(DataTableExtension.DataTrimSeparators);
            }

            int index = 0;
            index++;
            m_Id = int.Parse(columnStrings[index++]);
			TestEnum = (TestEnum)int.Parse(columnStrings[index++]);
			TestEnumList = DataTableExtension.ParseTestEnumList(columnStrings[index++]);
			TestEnumArray = DataTableExtension.ParseTestEnumArray(columnStrings[index++]);
			TestEnumDic = DataTableExtension.ParseTestEnumInt32Dictionary(columnStrings[index++]);
            GeneratePropertyArray();
            return true;
        }

        public override bool ParseDataRow(byte[] dataRowBytes, int startIndex, int length, object userData)
        {
            using (MemoryStream memoryStream = new MemoryStream(dataRowBytes, startIndex, length, false))
            {
                using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.UTF8))
                {
                    m_Id = binaryReader.Read7BitEncodedInt32();
					TestEnum = (TestEnum)binaryReader.Read7BitEncodedInt32();
					TestEnumList = binaryReader.ReadTestEnumList();
					TestEnumArray = binaryReader.ReadTestEnumArray();
					TestEnumDic = binaryReader.ReadTestEnumInt32Dictionary();
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
