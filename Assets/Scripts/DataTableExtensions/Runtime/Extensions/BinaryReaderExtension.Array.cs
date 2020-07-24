using System;
using System.IO;
using UnityEngine;

namespace DE
{
    public static partial class BinaryReaderExtension
    {
        public static bool[] ReadBooleanArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new bool[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.ReadBoolean();
            return array;
        }

        public static byte[] ReadByteArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new byte[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.ReadByte();
            return array;
        }

        public static char[] ReadCharArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new char[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.ReadChar();
            return array;
        }

        public static Color[] ReadColorArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new Color[count];
            for (var i = 0; i < count; i++) array[i] = ReadColor(binaryReader);
            return array;
        }

        public static Color32[] ReadColor32Array(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new Color32[count];
            for (var i = 0; i < count; i++) array[i] = ReadColor32(binaryReader);
            return array;
        }

        public static DateTime[] ReadDateTimeArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new DateTime[count];
            for (var i = 0; i < count; i++) array[i] = ReadDateTime(binaryReader);
            return array;
        }

        public static decimal[] ReadDecimalArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new decimal[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.ReadDecimal();
            return array;
        }

        public static double[] ReadDoubleArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new double[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.ReadDouble();
            return array;
        }

        public static float[] ReadSingleArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new float[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.ReadSingle();
            return array;
        }

        public static int[] ReadInt32Array(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new int[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.Read7BitEncodedInt32();
            return array;
        }

        public static long[] ReadInt64Array(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new long[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.Read7BitEncodedInt64();
            return array;
        }

        public static Quaternion[] ReadQuaternionArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new Quaternion[count];
            for (var i = 0; i < count; i++) array[i] = ReadQuaternion(binaryReader);
            return array;
        }

        public static Rect[] ReadRectArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new Rect[count];
            for (var i = 0; i < count; i++) array[i] = ReadRect(binaryReader);
            return array;
        }

        public static sbyte[] ReadSByteArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new sbyte[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.ReadSByte();
            return array;
        }

        public static short[] ReadInt16Array(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new short[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.ReadInt16();
            return array;
        }

        public static string[] ReadStringArray(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new string[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.ReadString();
            return array;
        }

        public static uint[] ReadUInt32Array(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new uint[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.Read7BitEncodedUInt32();
            return array;
        }

        public static ulong[] ReadUInt64Array(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new ulong[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.Read7BitEncodedUInt64();
            return array;
        }

        public static ushort[] ReadUInt16Array(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new ushort[count];
            for (var i = 0; i < count; i++) array[i] = binaryReader.ReadUInt16();
            return array;
        }

        public static Vector2[] ReadVector2Array(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new Vector2[count];
            for (var i = 0; i < count; i++) array[i] = ReadVector2(binaryReader);
            return array;
        }

        public static Vector3[] ReadVector3Array(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new Vector3[count];
            for (var i = 0; i < count; i++) array[i] = ReadVector3(binaryReader);
            return array;
        }

        public static Vector4[] ReadVector4Array(this BinaryReader binaryReader)
        {
            var count = binaryReader.Read7BitEncodedInt32();
            var array = new Vector4[count];
            for (var i = 0; i < count; i++) array[i] = ReadVector4(binaryReader);
            return array;
        }
    }
}