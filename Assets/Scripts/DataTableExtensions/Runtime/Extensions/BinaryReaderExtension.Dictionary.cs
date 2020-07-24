using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace DE
{
    public static partial class BinaryReaderExtension
    {
        public static Dictionary<Vector3, Vector4> ReadVector3Vector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Vector3, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadVector3(binaryReader), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<Vector2, Vector4> ReadVector2Vector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Vector2, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadVector2(binaryReader), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<ushort, Vector4> ReadUInt16Vector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<ushort, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadUInt16(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<ulong, Vector4> ReadUInt64Vector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<ulong, Vector4>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<uint, Vector4> ReadUInt32Vector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<uint, Vector4>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<string, Vector4> ReadStringVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<string, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadString(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<short, Vector4> ReadInt16Vector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<short, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadInt16(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<sbyte, Vector4> ReadSByteVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<sbyte, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSByte(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<Rect, Vector4> ReadRectVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Rect, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadRect(binaryReader), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<Quaternion, Vector4> ReadQuaternionVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadQuaternion(binaryReader), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<long, Vector4> ReadInt64Vector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, Vector4>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<int, Vector4> ReadInt32Vector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, Vector4>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<float, Vector4> ReadSingleVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<double, Vector4> ReadDoubleVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<decimal, Vector4> ReadDecimalVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<DateTime, Vector4> ReadDateTimeVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color32, Vector4> ReadColor32Vector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color, Vector4> ReadColorVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<char, Vector4> ReadCharVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<byte, Vector4> ReadByteVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<bool, Vector4> ReadBooleanVector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), ReadVector4(binaryReader));
            return dictionary;
        }

        public static Dictionary<Vector2, Vector3> ReadVector2Vector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Vector2, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadVector2(binaryReader), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<ushort, Vector3> ReadUInt16Vector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<ushort, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadUInt16(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<ulong, Vector3> ReadUInt64Vector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<ulong, Vector3>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<uint, Vector3> ReadUInt32Vector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<uint, Vector3>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<string, Vector3> ReadStringVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<string, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadString(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<short, Vector3> ReadInt16Vector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<short, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadInt16(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<sbyte, Vector3> ReadSByteVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<sbyte, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSByte(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<Rect, Vector3> ReadRectVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Rect, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadRect(binaryReader), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<Quaternion, Vector3> ReadQuaternionVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadQuaternion(binaryReader), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<long, Vector3> ReadInt64Vector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, Vector3>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<int, Vector3> ReadInt32Vector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, Vector3>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<float, Vector3> ReadSingleVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<double, Vector3> ReadDoubleVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<decimal, Vector3> ReadDecimalVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<DateTime, Vector3> ReadDateTimeVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color32, Vector3> ReadColor32Vector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color, Vector3> ReadColorVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<char, Vector3> ReadCharVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<byte, Vector3> ReadByteVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<bool, Vector3> ReadBooleanVector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<ushort, Vector2> ReadUInt16Vector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<ushort, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadUInt16(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<ulong, Vector2> ReadUInt64Vector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<ulong, Vector2>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<uint, Vector2> ReadUInt32Vector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<uint, Vector2>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<string, Vector2> ReadStringVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<string, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadString(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<short, Vector2> ReadInt16Vector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<short, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadInt16(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<sbyte, Vector2> ReadSByteVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<sbyte, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSByte(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<Rect, Vector2> ReadRectVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Rect, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadRect(binaryReader), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<Quaternion, Vector2> ReadQuaternionVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadQuaternion(binaryReader), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<long, Vector2> ReadInt64Vector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, Vector2>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<int, Vector2> ReadInt32Vector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, Vector2>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<float, Vector2> ReadSingleVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<double, Vector2> ReadDoubleVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<decimal, Vector2> ReadDecimalVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<DateTime, Vector2> ReadDateTimeVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color32, Vector2> ReadColor32Vector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color, Vector2> ReadColorVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<char, Vector2> ReadCharVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<byte, Vector2> ReadByteVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<bool, Vector2> ReadBooleanVector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<ulong, ushort> ReadUInt64UInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<ulong, ushort>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt64(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<uint, ushort> ReadUInt32UInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<uint, ushort>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt32(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<string, ushort> ReadStringUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<string, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadString(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<short, ushort> ReadInt16UInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<short, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadInt16(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<sbyte, ushort> ReadSByteUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<sbyte, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSByte(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<Rect, ushort> ReadRectUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Rect, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadRect(binaryReader), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<Quaternion, ushort> ReadQuaternionUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadQuaternion(binaryReader), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<long, ushort> ReadInt64UInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, ushort>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<int, ushort> ReadInt32UInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, ushort>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<float, ushort> ReadSingleUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<double, ushort> ReadDoubleUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<decimal, ushort> ReadDecimalUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<DateTime, ushort> ReadDateTimeUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<Color32, ushort> ReadColor32UInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<Color, ushort> ReadColorUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<char, ushort> ReadCharUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<byte, ushort> ReadByteUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<bool, ushort> ReadBooleanUInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<uint, ulong> ReadUInt32UInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<uint, ulong>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt32(), binaryReader.Read7BitEncodedUInt64());
            return dictionary;
        }

        public static Dictionary<string, ulong> ReadStringUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<string, ulong>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadString(), binaryReader.ReadUInt64());
            return dictionary;
        }

        public static Dictionary<short, ulong> ReadInt16UInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<short, ulong>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadInt16(), binaryReader.ReadUInt64());
            return dictionary;
        }

        public static Dictionary<sbyte, ulong> ReadSByteUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<sbyte, ulong>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSByte(), binaryReader.ReadUInt64());
            return dictionary;
        }

        public static Dictionary<Rect, ulong> ReadRectUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Rect, ulong>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadRect(binaryReader), binaryReader.Read7BitEncodedUInt64());
            return dictionary;
        }

        public static Dictionary<Quaternion, ulong> ReadQuaternionUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, ulong>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadQuaternion(binaryReader), binaryReader.Read7BitEncodedUInt64());
            return dictionary;
        }

        public static Dictionary<long, ulong> ReadInt64UInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, ulong>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), binaryReader.Read7BitEncodedUInt64());
            return dictionary;
        }

        public static Dictionary<int, ulong> ReadInt32UInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, ulong>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), binaryReader.Read7BitEncodedUInt64());
            return dictionary;
        }

        public static Dictionary<float, ulong> ReadSingleUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, ulong>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), binaryReader.ReadUInt64());
            return dictionary;
        }

        public static Dictionary<double, ulong> ReadDoubleUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, ulong>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), binaryReader.ReadUInt64());
            return dictionary;
        }

        public static Dictionary<decimal, ulong> ReadDecimalUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, ulong>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadUInt64());
            return dictionary;
        }

        public static Dictionary<DateTime, ulong> ReadDateTimeUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, ulong>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadDateTime(binaryReader), binaryReader.Read7BitEncodedUInt64());
            return dictionary;
        }

        public static Dictionary<Color32, ulong> ReadColor32UInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, ulong>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadColor32(binaryReader), binaryReader.Read7BitEncodedUInt64());
            return dictionary;
        }

        public static Dictionary<Color, ulong> ReadColorUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, ulong>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadColor(binaryReader), binaryReader.Read7BitEncodedUInt64());
            return dictionary;
        }

        public static Dictionary<char, ulong> ReadCharUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, ulong>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadUInt64());
            return dictionary;
        }

        public static Dictionary<byte, ulong> ReadByteUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, ulong>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadUInt64());
            return dictionary;
        }

        public static Dictionary<bool, ulong> ReadBooleanUInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, ulong>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadUInt64());
            return dictionary;
        }

        public static Dictionary<string, uint> ReadStringUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<string, uint>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadString(), binaryReader.ReadUInt32());
            return dictionary;
        }

        public static Dictionary<short, uint> ReadInt16UInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<short, uint>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadInt16(), binaryReader.ReadUInt32());
            return dictionary;
        }

        public static Dictionary<sbyte, uint> ReadSByteUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<sbyte, uint>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSByte(), binaryReader.ReadUInt32());
            return dictionary;
        }

        public static Dictionary<Rect, uint> ReadRectUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Rect, uint>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadRect(binaryReader), binaryReader.Read7BitEncodedUInt32());
            return dictionary;
        }

        public static Dictionary<Quaternion, uint> ReadQuaternionUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, uint>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadQuaternion(binaryReader), binaryReader.Read7BitEncodedUInt32());
            return dictionary;
        }

        public static Dictionary<long, uint> ReadInt64UInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, uint>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), binaryReader.Read7BitEncodedUInt32());
            return dictionary;
        }

        public static Dictionary<int, uint> ReadInt32UInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, uint>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), binaryReader.Read7BitEncodedUInt32());
            return dictionary;
        }

        public static Dictionary<float, uint> ReadSingleUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, uint>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), binaryReader.ReadUInt32());
            return dictionary;
        }

        public static Dictionary<double, uint> ReadDoubleUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, uint>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), binaryReader.ReadUInt32());
            return dictionary;
        }

        public static Dictionary<decimal, uint> ReadDecimalUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, uint>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadUInt32());
            return dictionary;
        }

        public static Dictionary<DateTime, uint> ReadDateTimeUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, uint>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadDateTime(binaryReader), binaryReader.Read7BitEncodedUInt32());
            return dictionary;
        }

        public static Dictionary<Color32, uint> ReadColor32UInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, uint>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadColor32(binaryReader), binaryReader.Read7BitEncodedUInt32());
            return dictionary;
        }

        public static Dictionary<Color, uint> ReadColorUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, uint>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadColor(binaryReader), binaryReader.Read7BitEncodedUInt32());
            return dictionary;
        }

        public static Dictionary<char, uint> ReadCharUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, uint>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadUInt32());
            return dictionary;
        }

        public static Dictionary<byte, uint> ReadByteUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, uint>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadUInt32());
            return dictionary;
        }

        public static Dictionary<bool, uint> ReadBooleanUInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, uint>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadUInt32());
            return dictionary;
        }

        public static Dictionary<short, string> ReadInt16StringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<short, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadInt16(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<sbyte, string> ReadSByteStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<sbyte, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSByte(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<Rect, string> ReadRectStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Rect, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadRect(binaryReader), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<Quaternion, string> ReadQuaternionStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadQuaternion(binaryReader), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<long, string> ReadInt64StringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, string>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<int, string> ReadInt32StringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, string>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<float, string> ReadSingleStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<double, string> ReadDoubleStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<decimal, string> ReadDecimalStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<DateTime, string> ReadDateTimeStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<Color32, string> ReadColor32StringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<Color, string> ReadColorStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<char, string> ReadCharStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<byte, string> ReadByteStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<bool, string> ReadBooleanStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<sbyte, short> ReadSByteInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<sbyte, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSByte(), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<Rect, short> ReadRectInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Rect, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadRect(binaryReader), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<Quaternion, short> ReadQuaternionInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadQuaternion(binaryReader), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<long, short> ReadInt64Int16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, short>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<int, short> ReadInt32Int16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, short>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<float, short> ReadSingleInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<double, short> ReadDoubleInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<decimal, short> ReadDecimalInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<DateTime, short> ReadDateTimeInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<Color32, short> ReadColor32Int16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<Color, short> ReadColorInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<char, short> ReadCharInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<byte, short> ReadByteInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<bool, short> ReadBooleanInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<Rect, sbyte> ReadRectSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Rect, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadRect(binaryReader), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<Quaternion, sbyte> ReadQuaternionSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadQuaternion(binaryReader), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<long, sbyte> ReadInt64SByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, sbyte>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<int, sbyte> ReadInt32SByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, sbyte>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<float, sbyte> ReadSingleSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<double, sbyte> ReadDoubleSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<decimal, sbyte> ReadDecimalSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<DateTime, sbyte> ReadDateTimeSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<Color32, sbyte> ReadColor32SByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<Color, sbyte> ReadColorSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<char, sbyte> ReadCharSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<byte, sbyte> ReadByteSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<bool, sbyte> ReadBooleanSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<Quaternion, Rect> ReadQuaternionRectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadQuaternion(binaryReader), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<long, Rect> ReadInt64RectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<int, Rect> ReadInt32RectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<float, Rect> ReadSingleRectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<double, Rect> ReadDoubleRectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<decimal, Rect> ReadDecimalRectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<DateTime, Rect> ReadDateTimeRectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color32, Rect> ReadColor32RectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color, Rect> ReadColorRectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<char, Rect> ReadCharRectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<byte, Rect> ReadByteRectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<bool, Rect> ReadBooleanRectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<long, Quaternion> ReadInt64QuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, Quaternion>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<int, Quaternion> ReadInt32QuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, Quaternion>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<float, Quaternion> ReadSingleQuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, Quaternion>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<double, Quaternion> ReadDoubleQuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, Quaternion>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<decimal, Quaternion> ReadDecimalQuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, Quaternion>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<DateTime, Quaternion> ReadDateTimeQuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, Quaternion>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color32, Quaternion> ReadColor32QuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, Quaternion>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color, Quaternion> ReadColorQuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, Quaternion>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<char, Quaternion> ReadCharQuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, Quaternion>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<byte, Quaternion> ReadByteQuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, Quaternion>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<bool, Quaternion> ReadBooleanQuaternionDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, Quaternion>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<int, long> ReadInt32Int64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, long>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), binaryReader.Read7BitEncodedInt64());
            return dictionary;
        }

        public static Dictionary<float, long> ReadSingleInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, long>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), binaryReader.ReadInt64());
            return dictionary;
        }

        public static Dictionary<double, long> ReadDoubleInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, long>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), binaryReader.ReadInt64());
            return dictionary;
        }

        public static Dictionary<decimal, long> ReadDecimalInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, long>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadInt64());
            return dictionary;
        }

        public static Dictionary<DateTime, long> ReadDateTimeInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, long>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadDateTime(binaryReader), binaryReader.Read7BitEncodedInt64());
            return dictionary;
        }

        public static Dictionary<Color32, long> ReadColor32Int64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, long>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadColor32(binaryReader), binaryReader.Read7BitEncodedInt64());
            return dictionary;
        }

        public static Dictionary<Color, long> ReadColorInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, long>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadColor(binaryReader), binaryReader.Read7BitEncodedInt64());
            return dictionary;
        }

        public static Dictionary<char, long> ReadCharInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, long>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadInt64());
            return dictionary;
        }

        public static Dictionary<byte, long> ReadByteInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, long>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadInt64());
            return dictionary;
        }

        public static Dictionary<bool, long> ReadBooleanInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, long>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadInt64());
            return dictionary;
        }

        public static Dictionary<float, int> ReadSingleInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, int>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), binaryReader.ReadInt32());
            return dictionary;
        }

        public static Dictionary<double, int> ReadDoubleInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, int>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), binaryReader.ReadInt32());
            return dictionary;
        }

        public static Dictionary<decimal, int> ReadDecimalInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, int>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadInt32());
            return dictionary;
        }

        public static Dictionary<DateTime, int> ReadDateTimeInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, int>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadDateTime(binaryReader), binaryReader.Read7BitEncodedInt32());
            return dictionary;
        }

        public static Dictionary<Color32, int> ReadColor32Int32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, int>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadColor32(binaryReader), binaryReader.Read7BitEncodedInt32());
            return dictionary;
        }

        public static Dictionary<Color, int> ReadColorInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, int>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(ReadColor(binaryReader), binaryReader.Read7BitEncodedInt32());
            return dictionary;
        }

        public static Dictionary<char, int> ReadCharInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, int>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadInt32());
            return dictionary;
        }

        public static Dictionary<byte, int> ReadByteInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, int>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadInt32());
            return dictionary;
        }

        public static Dictionary<bool, int> ReadBooleanInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, int>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadInt32());
            return dictionary;
        }

        public static Dictionary<double, float> ReadDoubleSingleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, float>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), binaryReader.ReadSingle());
            return dictionary;
        }

        public static Dictionary<decimal, float> ReadDecimalSingleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, float>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadSingle());
            return dictionary;
        }

        public static Dictionary<DateTime, float> ReadDateTimeSingleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, float>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), binaryReader.ReadSingle());
            return dictionary;
        }

        public static Dictionary<Color32, float> ReadColor32SingleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, float>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), binaryReader.ReadSingle());
            return dictionary;
        }

        public static Dictionary<Color, float> ReadColorSingleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, float>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), binaryReader.ReadSingle());
            return dictionary;
        }

        public static Dictionary<char, float> ReadCharSingleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, float>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadSingle());
            return dictionary;
        }

        public static Dictionary<byte, float> ReadByteSingleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, float>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadSingle());
            return dictionary;
        }

        public static Dictionary<bool, float> ReadBooleanSingleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, float>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadSingle());
            return dictionary;
        }

        public static Dictionary<decimal, double> ReadDecimalDoubleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, double>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadDouble());
            return dictionary;
        }

        public static Dictionary<DateTime, double> ReadDateTimeDoubleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, double>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), binaryReader.ReadDouble());
            return dictionary;
        }

        public static Dictionary<Color32, double> ReadColor32DoubleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, double>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), binaryReader.ReadDouble());
            return dictionary;
        }

        public static Dictionary<Color, double> ReadColorDoubleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, double>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), binaryReader.ReadDouble());
            return dictionary;
        }

        public static Dictionary<char, double> ReadCharDoubleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, double>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadDouble());
            return dictionary;
        }

        public static Dictionary<byte, double> ReadByteDoubleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, double>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadDouble());
            return dictionary;
        }

        public static Dictionary<bool, double> ReadBooleanDoubleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, double>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadDouble());
            return dictionary;
        }

        public static Dictionary<DateTime, decimal> ReadDateTimeDecimalDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, decimal>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), binaryReader.ReadDecimal());
            return dictionary;
        }

        public static Dictionary<Color32, decimal> ReadColor32DecimalDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, decimal>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), binaryReader.ReadDecimal());
            return dictionary;
        }

        public static Dictionary<Color, decimal> ReadColorDecimalDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, decimal>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), binaryReader.ReadDecimal());
            return dictionary;
        }

        public static Dictionary<char, decimal> ReadCharDecimalDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, decimal>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadDecimal());
            return dictionary;
        }

        public static Dictionary<byte, decimal> ReadByteDecimalDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, decimal>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadDecimal());
            return dictionary;
        }

        public static Dictionary<bool, decimal> ReadBooleanDecimalDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, decimal>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadDecimal());
            return dictionary;
        }

        public static Dictionary<Color32, DateTime> ReadColor32DateTimeDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, DateTime>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), ReadDateTime(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color, DateTime> ReadColorDateTimeDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, DateTime>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), ReadDateTime(binaryReader));
            return dictionary;
        }

        public static Dictionary<char, DateTime> ReadCharDateTimeDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, DateTime>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), ReadDateTime(binaryReader));
            return dictionary;
        }

        public static Dictionary<byte, DateTime> ReadByteDateTimeDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, DateTime>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), ReadDateTime(binaryReader));
            return dictionary;
        }

        public static Dictionary<bool, DateTime> ReadBooleanDateTimeDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, DateTime>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), ReadDateTime(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color, Color32> ReadColorColor32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, Color32>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), ReadColor32(binaryReader));
            return dictionary;
        }

        public static Dictionary<char, Color32> ReadCharColor32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, Color32>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), ReadColor32(binaryReader));
            return dictionary;
        }

        public static Dictionary<byte, Color32> ReadByteColor32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, Color32>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), ReadColor32(binaryReader));
            return dictionary;
        }

        public static Dictionary<bool, Color32> ReadBooleanColor32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, Color32>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), ReadColor32(binaryReader));
            return dictionary;
        }

        public static Dictionary<char, Color> ReadCharColorDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, Color>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), ReadColor(binaryReader));
            return dictionary;
        }

        public static Dictionary<byte, Color> ReadByteColorDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, Color>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), ReadColor(binaryReader));
            return dictionary;
        }

        public static Dictionary<bool, Color> ReadBooleanColorDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, Color>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), ReadColor(binaryReader));
            return dictionary;
        }

        public static Dictionary<byte, char> ReadByteCharDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, char>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadChar());
            return dictionary;
        }

        public static Dictionary<bool, char> ReadBooleanCharDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, char>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadChar());
            return dictionary;
        }

        public static Dictionary<bool, byte> ReadBooleanByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, byte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadByte());
            return dictionary;
        }

        public static Dictionary<bool, bool> ReadBooleanBooleanDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<bool, bool>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadBoolean(), binaryReader.ReadBoolean());
            return dictionary;
        }

        public static Dictionary<byte, byte> ReadByteByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<byte, byte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadByte(), binaryReader.ReadByte());
            return dictionary;
        }

        public static Dictionary<char, char> ReadCharCharDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<char, char>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadChar(), binaryReader.ReadChar());
            return dictionary;
        }

        public static Dictionary<Color, Color> ReadColorColorDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color, Color>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor(binaryReader), ReadColor(binaryReader));
            return dictionary;
        }

        public static Dictionary<Color32, Color32> ReadColor32Color32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Color32, Color32>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadColor32(binaryReader), ReadColor32(binaryReader));
            return dictionary;
        }

        public static Dictionary<DateTime, DateTime> ReadDateTimeDateTimeDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<DateTime, DateTime>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadDateTime(binaryReader), ReadDateTime(binaryReader));
            return dictionary;
        }

        public static Dictionary<decimal, decimal> ReadDecimalDecimalDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<decimal, decimal>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDecimal(), binaryReader.ReadDecimal());
            return dictionary;
        }

        public static Dictionary<double, double> ReadDoubleDoubleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<double, double>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadDouble(), binaryReader.ReadDouble());
            return dictionary;
        }

        public static Dictionary<float, float> ReadSingleSingleDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<float, float>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSingle(), binaryReader.ReadSingle());
            return dictionary;
        }

        public static Dictionary<int, int> ReadInt32Int32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<int, int>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt32(), binaryReader.Read7BitEncodedInt32());
            return dictionary;
        }

        public static Dictionary<long, long> ReadInt64Int64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<long, long>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedInt64(), binaryReader.Read7BitEncodedInt64());
            return dictionary;
        }

        public static Dictionary<Quaternion, Quaternion> ReadQuaternionQuaternionDictionary(
            this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Quaternion, Quaternion>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadQuaternion(binaryReader), ReadQuaternion(binaryReader));
            return dictionary;
        }

        public static Dictionary<Rect, Rect> ReadRectRectDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Rect, Rect>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadRect(binaryReader), ReadRect(binaryReader));
            return dictionary;
        }

        public static Dictionary<sbyte, sbyte> ReadSByteSByteDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<sbyte, sbyte>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadSByte(), binaryReader.ReadSByte());
            return dictionary;
        }

        public static Dictionary<short, short> ReadInt16Int16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<short, short>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadInt16(), binaryReader.ReadInt16());
            return dictionary;
        }

        public static Dictionary<string, string> ReadStringStringDictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<string, string>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadString(), binaryReader.ReadString());
            return dictionary;
        }

        public static Dictionary<uint, uint> ReadUInt32UInt32Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<uint, uint>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt32(), binaryReader.Read7BitEncodedUInt32());
            return dictionary;
        }

        public static Dictionary<ulong, ulong> ReadUInt64UInt64Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<ulong, ulong>(count);
            for (var i = 0; i < count; i++)
                dictionary.Add(binaryReader.Read7BitEncodedUInt64(), binaryReader.Read7BitEncodedUInt64());
            return dictionary;
        }

        public static Dictionary<ushort, ushort> ReadUInt16UInt16Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<ushort, ushort>(count);
            for (var i = 0; i < count; i++) dictionary.Add(binaryReader.ReadUInt16(), binaryReader.ReadUInt16());
            return dictionary;
        }

        public static Dictionary<Vector2, Vector2> ReadVector2Vector2Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Vector2, Vector2>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadVector2(binaryReader), ReadVector2(binaryReader));
            return dictionary;
        }

        public static Dictionary<Vector3, Vector3> ReadVector3Vector3Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Vector3, Vector3>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadVector3(binaryReader), ReadVector3(binaryReader));
            return dictionary;
        }

        public static Dictionary<Vector4, Vector4> ReadVector4Vector4Dictionary(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var dictionary = new Dictionary<Vector4, Vector4>(count);
            for (var i = 0; i < count; i++) dictionary.Add(ReadVector4(binaryReader), ReadVector4(binaryReader));
            return dictionary;
        }
    }
}