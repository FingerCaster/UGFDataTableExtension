using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace DE
{
    public static partial class BinaryReaderExtension
    {
        public static List<bool> ReadBooleanList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<bool>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.ReadBoolean());
            return list;
        }

        public static List<byte> ReadByteList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<byte>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.ReadByte());
            return list;
        }

        public static List<char> ReadCharList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<char>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.ReadChar());
            return list;
        }

        public static List<Color> ReadColorList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<Color>(count);
            for (var i = 0; i < count; i++) list.Add(ReadColor(binaryReader));
            return list;
        }

        public static List<Color32> ReadColor32List(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<Color32>(count);
            for (var i = 0; i < count; i++) list.Add(ReadColor32(binaryReader));
            return list;
        }

        public static List<DateTime> ReadDateTimeList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<DateTime>(count);
            for (var i = 0; i < count; i++) list.Add(ReadDateTime(binaryReader));
            return list;
        }

        public static List<decimal> ReadDecimalList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<decimal>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.ReadDecimal());
            return list;
        }

        public static List<double> ReadDoubleList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<double>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.ReadDouble());
            return list;
        }

        public static List<float> ReadSingleList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<float>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.ReadSingle());
            return list;
        }

        public static List<int> ReadInt32List(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<int>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.Read7BitEncodedInt32());
            return list;
        }

        public static List<long> ReadInt64List(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<long>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.Read7BitEncodedInt64());
            return list;
        }

        public static List<Quaternion> ReadQuaternionList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<Quaternion>(count);
            for (var i = 0; i < count; i++) list.Add(ReadQuaternion(binaryReader));
            return list;
        }

        public static List<Rect> ReadRectList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<Rect>(count);
            for (var i = 0; i < count; i++) list.Add(ReadRect(binaryReader));
            return list;
        }

        public static List<sbyte> ReadSByteList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<sbyte>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.ReadSByte());
            return list;
        }

        public static List<short> ReadInt16List(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<short>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.ReadInt16());
            return list;
        }

        public static List<string> ReadStringList(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<string>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.ReadString());
            return list;
        }

        public static List<uint> ReadUInt32List(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<uint>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.Read7BitEncodedUInt32());
            return list;
        }

        public static List<ulong> ReadUInt64List(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<ulong>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.Read7BitEncodedUInt64());
            return list;
        }

        public static List<ushort> ReadUInt16List(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<ushort>(count);
            for (var i = 0; i < count; i++) list.Add(binaryReader.ReadUInt16());
            return list;
        }

        public static List<Vector2> ReadVector2List(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<Vector2>(count);
            for (var i = 0; i < count; i++) list.Add(ReadVector2(binaryReader));
            return list;
        }

        public static List<Vector3> ReadVector3List(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<Vector3>(count);
            for (var i = 0; i < count; i++) list.Add(ReadVector3(binaryReader));
            return list;
        }

        public static List<Vector4> ReadVector4List(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var list = new List<Vector4>(count);
            for (var i = 0; i < count; i++) list.Add(ReadVector4(binaryReader));
            return list;
        }
    }
}