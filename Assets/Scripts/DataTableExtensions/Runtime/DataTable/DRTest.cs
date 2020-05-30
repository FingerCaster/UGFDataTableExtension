//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2020-05-31 04:29:02.842
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
    public class DRTest : DataRowBase
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
        /// 获取Bool值。
        /// </summary>
        public bool BoolValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Byte值。
        /// </summary>
        public byte ByteValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Char值。
        /// </summary>
        public char CharValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Color32值。
        /// </summary>
        public Color32 Color32Value
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Color值。
        /// </summary>
        public Color ColorValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取DateTime值。
        /// </summary>
        public DateTime DateTimeValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Decimal值。
        /// </summary>
        public decimal DecimalValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Double值。
        /// </summary>
        public double DoubleValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Float值。
        /// </summary>
        public float FloatValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Int值。
        /// </summary>
        public int IntValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Long值。
        /// </summary>
        public long LongValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Quaternion值。
        /// </summary>
        public Quaternion QuaternionValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Rect值。
        /// </summary>
        public Rect RectValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取SByte值。
        /// </summary>
        public sbyte SByteValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Short值。
        /// </summary>
        public short ShortValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取String值。
        /// </summary>
        public string StringValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取UInt值。
        /// </summary>
        public uint UIntValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取ULong值。
        /// </summary>
        public ulong ULongValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取UShort值。
        /// </summary>
        public ushort UShortValue
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Vector2值。
        /// </summary>
        public Vector2 Vector2Value
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Vector3值。
        /// </summary>
        public Vector3 Vector3Value
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Vector4值。
        /// </summary>
        public Vector4 Vector4Value
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Bool列表。
        /// </summary>
        public List<bool> BoolList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Byte列表。
        /// </summary>
        public List<byte> ByteList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Char列表。
        /// </summary>
        public List<char> CharList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Color32列表。
        /// </summary>
        public List<Color32> Color32List
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Color列表。
        /// </summary>
        public List<Color> ColorList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取DateTime列表。
        /// </summary>
        public List<DateTime> DateTimeList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Decimal列表。
        /// </summary>
        public List<decimal> DecimalList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Double列表。
        /// </summary>
        public List<double> DoubleList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Float列表。
        /// </summary>
        public List<float> FloatList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Int列表。
        /// </summary>
        public List<int> IntList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Long列表。
        /// </summary>
        public List<long> LongList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Quaternion列表。
        /// </summary>
        public List<Quaternion> QuaternionList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Rect列表。
        /// </summary>
        public List<Rect> RectList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取SByte列表。
        /// </summary>
        public List<sbyte> SByteList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Short列表。
        /// </summary>
        public List<short> ShortList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取String列表。
        /// </summary>
        public List<string> StringList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取UInt列表。
        /// </summary>
        public List<uint> UIntList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取ULong列表。
        /// </summary>
        public List<ulong> ULongList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取UShort列表。
        /// </summary>
        public List<ushort> UShortList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Vector2列表。
        /// </summary>
        public List<Vector2> Vector2List
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Vector3列表。
        /// </summary>
        public List<Vector3> Vector3List
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Vector4列表。
        /// </summary>
        public List<Vector4> Vector4List
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Bool数组。
        /// </summary>
        public bool[] BoolArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Byte数组。
        /// </summary>
        public byte[] ByteArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Char数组。
        /// </summary>
        public char[] CharArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Color32数组。
        /// </summary>
        public Color32[] Color32Array
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Color数组。
        /// </summary>
        public Color[] ColorArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取DateTime数组。
        /// </summary>
        public DateTime[] DateTimeArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Decimal数组。
        /// </summary>
        public decimal[] DecimalArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Double数组。
        /// </summary>
        public double[] DoubleArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Float数组。
        /// </summary>
        public float[] FloatArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Int数组。
        /// </summary>
        public int[] IntArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Long数组。
        /// </summary>
        public long[] LongArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Quaternion数组。
        /// </summary>
        public Quaternion[] QuaternionArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Rect数组。
        /// </summary>
        public Rect[] RectArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取SByte数组。
        /// </summary>
        public sbyte[] SByteArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Short数组。
        /// </summary>
        public short[] ShortArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取String数组。
        /// </summary>
        public string[] StringArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取UInt数组。
        /// </summary>
        public uint[] UIntArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取ULong数组。
        /// </summary>
        public ulong[] ULongArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取UShort数组。
        /// </summary>
        public ushort[] UShortArray
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Vector2数组。
        /// </summary>
        public Vector2[] Vector2Array
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Vector3数组。
        /// </summary>
        public Vector3[] Vector3Array
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Vector4数组。
        /// </summary>
        public Vector4[] Vector4Array
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
					BoolValue = bool.Parse(columnTexts[index++]);
					ByteValue = byte.Parse(columnTexts[index++]);
					CharValue = char.Parse(columnTexts[index++]);
            Color32Value = DataTableExtension.ParseColor32(columnTexts[index++]);
            ColorValue = DataTableExtension.ParseColor(columnTexts[index++]);
                index++;
					DateTimeValue = DateTime.Parse(columnTexts[index++]);
					DecimalValue = decimal.Parse(columnTexts[index++]);
					DoubleValue = double.Parse(columnTexts[index++]);
					FloatValue = float.Parse(columnTexts[index++]);
					IntValue = int.Parse(columnTexts[index++]);
					LongValue = long.Parse(columnTexts[index++]);
            QuaternionValue = DataTableExtension.ParseQuaternion(columnTexts[index++]);
            RectValue = DataTableExtension.ParseRect(columnTexts[index++]);
					SByteValue = sbyte.Parse(columnTexts[index++]);
					ShortValue = short.Parse(columnTexts[index++]);
				StringValue = columnTexts[index++];
					UIntValue = uint.Parse(columnTexts[index++]);
					ULongValue = ulong.Parse(columnTexts[index++]);
					UShortValue = ushort.Parse(columnTexts[index++]);
            Vector2Value = DataTableExtension.ParseVector2(columnTexts[index++]);
            Vector3Value = DataTableExtension.ParseVector3(columnTexts[index++]);
            Vector4Value = DataTableExtension.ParseVector4(columnTexts[index++]);
				BoolList = DataTableExtension.ParseBooleanList(columnTexts[index++]);
				ByteList = DataTableExtension.ParseByteList(columnTexts[index++]);
				CharList = DataTableExtension.ParseCharList(columnTexts[index++]);
				Color32List = DataTableExtension.ParseColor32List(columnTexts[index++]);
				ColorList = DataTableExtension.ParseColorList(columnTexts[index++]);
				DateTimeList = DataTableExtension.ParseDateTimeList(columnTexts[index++]);
				DecimalList = DataTableExtension.ParseDecimalList(columnTexts[index++]);
				DoubleList = DataTableExtension.ParseDoubleList(columnTexts[index++]);
				FloatList = DataTableExtension.ParseSingleList(columnTexts[index++]);
				IntList = DataTableExtension.ParseInt32List(columnTexts[index++]);
				LongList = DataTableExtension.ParseInt64List(columnTexts[index++]);
				QuaternionList = DataTableExtension.ParseQuaternionList(columnTexts[index++]);
				RectList = DataTableExtension.ParseRectList(columnTexts[index++]);
				SByteList = DataTableExtension.ParseSByteList(columnTexts[index++]);
				ShortList = DataTableExtension.ParseInt16List(columnTexts[index++]);
				StringList = DataTableExtension.ParseStringList(columnTexts[index++]);
				UIntList = DataTableExtension.ParseUInt32List(columnTexts[index++]);
				ULongList = DataTableExtension.ParseUInt64List(columnTexts[index++]);
				UShortList = DataTableExtension.ParseUInt16List(columnTexts[index++]);
				Vector2List = DataTableExtension.ParseVector2List(columnTexts[index++]);
				Vector3List = DataTableExtension.ParseVector3List(columnTexts[index++]);
				Vector4List = DataTableExtension.ParseVector4List(columnTexts[index++]);
				BoolArray = DataTableExtension.ParseBooleanArray(columnTexts[index++]);
				ByteArray = DataTableExtension.ParseByteArray(columnTexts[index++]);
				CharArray = DataTableExtension.ParseCharArray(columnTexts[index++]);
				Color32Array = DataTableExtension.ParseColor32Array(columnTexts[index++]);
				ColorArray = DataTableExtension.ParseColorArray(columnTexts[index++]);
				DateTimeArray = DataTableExtension.ParseDateTimeArray(columnTexts[index++]);
				DecimalArray = DataTableExtension.ParseDecimalArray(columnTexts[index++]);
				DoubleArray = DataTableExtension.ParseDoubleArray(columnTexts[index++]);
				FloatArray = DataTableExtension.ParseSingleArray(columnTexts[index++]);
				IntArray = DataTableExtension.ParseInt32Array(columnTexts[index++]);
				LongArray = DataTableExtension.ParseInt64Array(columnTexts[index++]);
				QuaternionArray = DataTableExtension.ParseQuaternionArray(columnTexts[index++]);
				RectArray = DataTableExtension.ParseRectArray(columnTexts[index++]);
				SByteArray = DataTableExtension.ParseSByteArray(columnTexts[index++]);
				ShortArray = DataTableExtension.ParseInt16Array(columnTexts[index++]);
				StringArray = DataTableExtension.ParseStringArray(columnTexts[index++]);
				UIntArray = DataTableExtension.ParseUInt32Array(columnTexts[index++]);
				ULongArray = DataTableExtension.ParseUInt64Array(columnTexts[index++]);
				UShortArray = DataTableExtension.ParseUInt16Array(columnTexts[index++]);
				Vector2Array = DataTableExtension.ParseVector2Array(columnTexts[index++]);
				Vector3Array = DataTableExtension.ParseVector3Array(columnTexts[index++]);
				Vector4Array = DataTableExtension.ParseVector4Array(columnTexts[index++]);
            }
            else if (dataType == typeof(byte[]))
            {
                string[] strings = (string[])dataTableUserData;
                using (MemoryStream memoryStream = new MemoryStream((byte[])dataRowSegment.Data, dataRowSegment.Offset, dataRowSegment.Length, false))
                {
                    using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.UTF8))
                    {
                        m_Id = binaryReader.Read7BitEncodedInt32();
                        BoolValue = binaryReader.ReadBoolean();
                        ByteValue = binaryReader.ReadByte();
                        CharValue = binaryReader.ReadChar();
                        Color32Value = binaryReader.ReadColor32();
                        ColorValue = binaryReader.ReadColor();
                        DateTimeValue = binaryReader.ReadDateTime();
                        DecimalValue = binaryReader.ReadDecimal();
                        DoubleValue = binaryReader.ReadDouble();
                        FloatValue = binaryReader.ReadSingle();
                        IntValue = binaryReader.Read7BitEncodedInt32();
                        LongValue = binaryReader.Read7BitEncodedInt64();
                        QuaternionValue = binaryReader.ReadQuaternion();
                        RectValue = binaryReader.ReadRect();
                        SByteValue = binaryReader.ReadSByte();
                        ShortValue = binaryReader.ReadInt16();
                        StringValue = strings[binaryReader.Read7BitEncodedInt32()];
                        UIntValue = binaryReader.Read7BitEncodedUInt32();
                        ULongValue = binaryReader.Read7BitEncodedUInt64();
                        UShortValue = binaryReader.ReadUInt16();
                        Vector2Value = binaryReader.ReadVector2();
                        Vector3Value = binaryReader.ReadVector3();
                        Vector4Value = binaryReader.ReadVector4();
						BoolList = binaryReader.ReadBooleanList();
						ByteList = binaryReader.ReadByteList();
						CharList = binaryReader.ReadCharList();
						Color32List = binaryReader.ReadColor32List();
						ColorList = binaryReader.ReadColorList();
						DateTimeList = binaryReader.ReadDateTimeList();
						DecimalList = binaryReader.ReadDecimalList();
						DoubleList = binaryReader.ReadDoubleList();
						FloatList = binaryReader.ReadSingleList();
						IntList = binaryReader.ReadInt32List();
						LongList = binaryReader.ReadInt64List();
						QuaternionList = binaryReader.ReadQuaternionList();
						RectList = binaryReader.ReadRectList();
						SByteList = binaryReader.ReadSByteList();
						ShortList = binaryReader.ReadInt16List();
						StringList = binaryReader.ReadStringList(strings);
						UIntList = binaryReader.ReadUInt32List();
						ULongList = binaryReader.ReadUInt64List();
						UShortList = binaryReader.ReadUInt16List();
						Vector2List = binaryReader.ReadVector2List();
						Vector3List = binaryReader.ReadVector3List();
						Vector4List = binaryReader.ReadVector4List();
						BoolArray = binaryReader.ReadBooleanArray();
						ByteArray = binaryReader.ReadByteArray();
						CharArray = binaryReader.ReadCharArray();
						Color32Array = binaryReader.ReadColor32Array();
						ColorArray = binaryReader.ReadColorArray();
						DateTimeArray = binaryReader.ReadDateTimeArray();
						DecimalArray = binaryReader.ReadDecimalArray();
						DoubleArray = binaryReader.ReadDoubleArray();
						FloatArray = binaryReader.ReadSingleArray();
						IntArray = binaryReader.ReadInt32Array();
						LongArray = binaryReader.ReadInt64Array();
						QuaternionArray = binaryReader.ReadQuaternionArray();
						RectArray = binaryReader.ReadRectArray();
						SByteArray = binaryReader.ReadSByteArray();
						ShortArray = binaryReader.ReadInt16Array();
						StringArray = binaryReader.ReadStringArray(strings);
						UIntArray = binaryReader.ReadUInt32Array();
						ULongArray = binaryReader.ReadUInt64Array();
						UShortArray = binaryReader.ReadUInt16Array();
						Vector2Array = binaryReader.ReadVector2Array();
						Vector3Array = binaryReader.ReadVector3Array();
						Vector4Array = binaryReader.ReadVector4Array();
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
