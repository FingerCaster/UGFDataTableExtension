using System;
using System.Collections.Generic;
using UnityEngine;

namespace DE
{
    public static partial class DataTableExtension
    {
        public static List<bool> ParseBooleanList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<bool>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(bool.Parse(splitValue[i]));
            return list;
        }

        public static List<byte> ParseByteList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<byte>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(byte.Parse(splitValue[i]));
            return list;
        }

        public static List<char> ParseCharList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<char>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(char.Parse(splitValue[i]));
            return list;
        }

        public static List<Color> ParseColorList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var list = new List<Color>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(ParseColor(splitValue[i]));
            return list;
        }

        public static List<Color32> ParseColor32List(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var list = new List<Color32>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(ParseColor32(splitValue[i]));
            return list;
        }

        public static List<DateTime> ParseDateTimeList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<DateTime>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(DateTime.Parse(splitValue[i]));
            return list;
        }

        public static List<decimal> ParseDecimalList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<decimal>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(decimal.Parse(splitValue[i]));
            return list;
        }

        public static List<double> ParseDoubleList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<double>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(double.Parse(splitValue[i]));
            return list;
        }

        public static List<float> ParseSingleList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<float>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(float.Parse(splitValue[i]));
            return list;
        }

        public static List<int> ParseInt32List(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<int>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(int.Parse(splitValue[i]));
            return list;
        }

        public static List<long> ParseInt64List(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<long>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(long.Parse(splitValue[i]));
            return list;
        }

        public static List<Quaternion> ParseQuaternionList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var list = new List<Quaternion>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(ParseQuaternion(splitValue[i]));
            return list;
        }

        public static List<Rect> ParseRectList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var list = new List<Rect>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(ParseRect(splitValue[i]));
            return list;
        }

        public static List<sbyte> ParseSByteList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<sbyte>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(sbyte.Parse(splitValue[i]));
            return list;
        }

        public static List<short> ParseInt16List(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<short>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(short.Parse(splitValue[i]));
            return list;
        }

        public static List<string> ParseStringList(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<string>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(splitValue[i]);
            return list;
        }

        public static List<uint> ParseUInt32List(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<uint>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(uint.Parse(splitValue[i]));
            return list;
        }

        public static List<ulong> ParseUInt64List(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<ulong>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(ulong.Parse(splitValue[i]));
            return list;
        }

        public static List<ushort> ParseUInt16List(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split(',');
            var list = new List<ushort>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(ushort.Parse(splitValue[i]));
            return list;
        }

        public static List<Vector2> ParseVector2List(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var list = new List<Vector2>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(ParseVector2(splitValue[i]));
            return list;
        }

        public static List<Vector3> ParseVector3List(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var list = new List<Vector3>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(ParseVector3(splitValue[i]));
            return list;
        }

        public static List<Vector4> ParseVector4List(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLowerInvariant().Equals("null"))
                return null;
            var splitValue = value.Split('|');
            var list = new List<Vector4>(splitValue.Length);
            for (var i = 0; i < splitValue.Length; i++) list.Add(ParseVector4(splitValue[i]));
            return list;
        }
    }
}