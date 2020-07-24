using System;
using UnityEngine;

namespace DE
{
    public static partial class DataTableExtension
    {
        public static bool[] ParseBooleanArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new bool[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = bool.Parse(splitValue[i]);

            return array;
        }

        public static byte[] ParseByteArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new byte[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = byte.Parse(splitValue[i]);

            return array;
        }

        public static char[] ParseCharArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new char[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = char.Parse(splitValue[i]);

            return array;
        }

        public static Color[] ParseColorArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var array = new Color[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = ParseColor(splitValue[i]);

            return array;
        }

        public static Color32[] ParseColor32Array(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var array = new Color32[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = ParseColor32(splitValue[i]);

            return array;
        }

        public static DateTime[] ParseDateTimeArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new DateTime[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = DateTime.Parse(splitValue[i]);

            return array;
        }

        public static decimal[] ParseDecimalArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new decimal[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = decimal.Parse(splitValue[i]);

            return array;
        }

        public static double[] ParseDoubleArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new double[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = double.Parse(splitValue[i]);

            return array;
        }

        public static float[] ParseSingleArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new float[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = float.Parse(splitValue[i]);

            return array;
        }

        public static int[] ParseInt32Array(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new int[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = int.Parse(splitValue[i]);

            return array;
        }

        public static long[] ParseInt64Array(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new long[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = long.Parse(splitValue[i]);

            return array;
        }

        public static Quaternion[] ParseQuaternionArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var array = new Quaternion[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = ParseQuaternion(splitValue[i]);

            return array;
        }

        public static Rect[] ParseRectArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var array = new Rect[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = ParseRect(splitValue[i]);

            return array;
        }

        public static sbyte[] ParseSByteArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new sbyte[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = sbyte.Parse(splitValue[i]);

            return array;
        }

        public static short[] ParseInt16Array(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new short[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = short.Parse(splitValue[i]);

            return array;
        }

        public static string[] ParseStringArray(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new string[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = splitValue[i];

            return array;
        }

        public static uint[] ParseUInt32Array(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new uint[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = uint.Parse(splitValue[i]);

            return array;
        }

        public static ulong[] ParseUInt64Array(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new ulong[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = ulong.Parse(splitValue[i]);

            return array;
        }

        public static ushort[] ParseUInt16Array(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var array = new ushort[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = ushort.Parse(splitValue[i]);

            return array;
        }

        public static Vector2[] ParseVector2Array(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var array = new Vector2[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = ParseVector2(splitValue[i]);

            return array;
        }

        public static Vector3[] ParseVector3Array(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var array = new Vector3[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = ParseVector3(splitValue[i]);

            return array;
        }

        public static Vector4[] ParseVector4Array(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var array = new Vector4[splitValue.Length];
            for (var i = 0; i < splitValue.Length; i++) array[i] = ParseVector4(splitValue[i]);

            return array;
        }
    }
}