using UnityEngine;
using System.IO;
using System;
using System.Collections.Generic;
namespace DE
{
	public static partial class DataTableExtension
	{
		public static Dictionary<Vector3,Vector4> ParseVector3Vector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Vector3,Vector4> dictionary = new Dictionary<Vector3,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseVector3(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Vector2,Vector4> ParseVector2Vector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Vector2,Vector4> dictionary = new Dictionary<Vector2,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseVector2(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<ushort,Vector4> ParseUInt16Vector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<ushort,Vector4> dictionary = new Dictionary<ushort,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt16.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<ulong,Vector4> ParseUInt64Vector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<ulong,Vector4> dictionary = new Dictionary<ulong,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt64.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<uint,Vector4> ParseUInt32Vector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<uint,Vector4> dictionary = new Dictionary<uint,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt32.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<string,Vector4> ParseStringVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<string,Vector4> dictionary = new Dictionary<string,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(keyValue[0].Substring(1),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<short,Vector4> ParseInt16Vector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<short,Vector4> dictionary = new Dictionary<short,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int16.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,Vector4> ParseSByteVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<sbyte,Vector4> dictionary = new Dictionary<sbyte,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(SByte.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Rect,Vector4> ParseRectVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Rect,Vector4> dictionary = new Dictionary<Rect,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseRect(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Vector4> ParseQuaternionVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,Vector4> dictionary = new Dictionary<Quaternion,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,Vector4> ParseInt64Vector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,Vector4> dictionary = new Dictionary<long,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,Vector4> ParseInt32Vector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,Vector4> dictionary = new Dictionary<int,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,Vector4> ParseSingleVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,Vector4> dictionary = new Dictionary<float,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,Vector4> ParseDoubleVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,Vector4> dictionary = new Dictionary<double,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Vector4> ParseDecimalVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,Vector4> dictionary = new Dictionary<decimal,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Vector4> ParseDateTimeVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,Vector4> dictionary = new Dictionary<DateTime,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Vector4> ParseColor32Vector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,Vector4> dictionary = new Dictionary<Color32,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,Vector4> ParseColorVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,Vector4> dictionary = new Dictionary<Color,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,Vector4> ParseCharVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,Vector4> dictionary = new Dictionary<char,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,Vector4> ParseByteVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,Vector4> dictionary = new Dictionary<byte,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,Vector4> ParseBooleanVector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,Vector4> dictionary = new Dictionary<bool,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Vector2,Vector3> ParseVector2Vector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Vector2,Vector3> dictionary = new Dictionary<Vector2,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseVector2(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<ushort,Vector3> ParseUInt16Vector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<ushort,Vector3> dictionary = new Dictionary<ushort,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt16.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<ulong,Vector3> ParseUInt64Vector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<ulong,Vector3> dictionary = new Dictionary<ulong,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt64.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<uint,Vector3> ParseUInt32Vector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<uint,Vector3> dictionary = new Dictionary<uint,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt32.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<string,Vector3> ParseStringVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<string,Vector3> dictionary = new Dictionary<string,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(keyValue[0].Substring(1),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<short,Vector3> ParseInt16Vector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<short,Vector3> dictionary = new Dictionary<short,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int16.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,Vector3> ParseSByteVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<sbyte,Vector3> dictionary = new Dictionary<sbyte,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(SByte.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Rect,Vector3> ParseRectVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Rect,Vector3> dictionary = new Dictionary<Rect,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseRect(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Vector3> ParseQuaternionVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,Vector3> dictionary = new Dictionary<Quaternion,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,Vector3> ParseInt64Vector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,Vector3> dictionary = new Dictionary<long,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,Vector3> ParseInt32Vector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,Vector3> dictionary = new Dictionary<int,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,Vector3> ParseSingleVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,Vector3> dictionary = new Dictionary<float,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,Vector3> ParseDoubleVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,Vector3> dictionary = new Dictionary<double,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Vector3> ParseDecimalVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,Vector3> dictionary = new Dictionary<decimal,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Vector3> ParseDateTimeVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,Vector3> dictionary = new Dictionary<DateTime,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Vector3> ParseColor32Vector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,Vector3> dictionary = new Dictionary<Color32,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,Vector3> ParseColorVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,Vector3> dictionary = new Dictionary<Color,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,Vector3> ParseCharVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,Vector3> dictionary = new Dictionary<char,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,Vector3> ParseByteVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,Vector3> dictionary = new Dictionary<byte,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,Vector3> ParseBooleanVector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,Vector3> dictionary = new Dictionary<bool,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<ushort,Vector2> ParseUInt16Vector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<ushort,Vector2> dictionary = new Dictionary<ushort,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt16.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<ulong,Vector2> ParseUInt64Vector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<ulong,Vector2> dictionary = new Dictionary<ulong,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt64.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<uint,Vector2> ParseUInt32Vector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<uint,Vector2> dictionary = new Dictionary<uint,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt32.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<string,Vector2> ParseStringVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<string,Vector2> dictionary = new Dictionary<string,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(keyValue[0].Substring(1),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<short,Vector2> ParseInt16Vector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<short,Vector2> dictionary = new Dictionary<short,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int16.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,Vector2> ParseSByteVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<sbyte,Vector2> dictionary = new Dictionary<sbyte,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(SByte.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Rect,Vector2> ParseRectVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Rect,Vector2> dictionary = new Dictionary<Rect,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseRect(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Vector2> ParseQuaternionVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,Vector2> dictionary = new Dictionary<Quaternion,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,Vector2> ParseInt64Vector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,Vector2> dictionary = new Dictionary<long,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,Vector2> ParseInt32Vector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,Vector2> dictionary = new Dictionary<int,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,Vector2> ParseSingleVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,Vector2> dictionary = new Dictionary<float,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,Vector2> ParseDoubleVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,Vector2> dictionary = new Dictionary<double,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Vector2> ParseDecimalVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,Vector2> dictionary = new Dictionary<decimal,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Vector2> ParseDateTimeVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,Vector2> dictionary = new Dictionary<DateTime,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Vector2> ParseColor32Vector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,Vector2> dictionary = new Dictionary<Color32,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,Vector2> ParseColorVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,Vector2> dictionary = new Dictionary<Color,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,Vector2> ParseCharVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,Vector2> dictionary = new Dictionary<char,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,Vector2> ParseByteVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,Vector2> dictionary = new Dictionary<byte,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,Vector2> ParseBooleanVector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,Vector2> dictionary = new Dictionary<bool,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<ulong,ushort> ParseUInt64UInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<ulong,ushort> dictionary = new Dictionary<ulong,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt64.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<uint,ushort> ParseUInt32UInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<uint,ushort> dictionary = new Dictionary<uint,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt32.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<string,ushort> ParseStringUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<string,ushort> dictionary = new Dictionary<string,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(keyValue[0].Substring(1),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<short,ushort> ParseInt16UInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<short,ushort> dictionary = new Dictionary<short,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int16.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,ushort> ParseSByteUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<sbyte,ushort> dictionary = new Dictionary<sbyte,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(SByte.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Rect,ushort> ParseRectUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Rect,ushort> dictionary = new Dictionary<Rect,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseRect(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,ushort> ParseQuaternionUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,ushort> dictionary = new Dictionary<Quaternion,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,ushort> ParseInt64UInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,ushort> dictionary = new Dictionary<long,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,ushort> ParseInt32UInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,ushort> dictionary = new Dictionary<int,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,ushort> ParseSingleUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,ushort> dictionary = new Dictionary<float,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,ushort> ParseDoubleUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,ushort> dictionary = new Dictionary<double,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,ushort> ParseDecimalUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,ushort> dictionary = new Dictionary<decimal,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,ushort> ParseDateTimeUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,ushort> dictionary = new Dictionary<DateTime,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,ushort> ParseColor32UInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,ushort> dictionary = new Dictionary<Color32,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,ushort> ParseColorUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,ushort> dictionary = new Dictionary<Color,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,ushort> ParseCharUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,ushort> dictionary = new Dictionary<char,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,ushort> ParseByteUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,ushort> dictionary = new Dictionary<byte,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,ushort> ParseBooleanUInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,ushort> dictionary = new Dictionary<bool,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<uint,ulong> ParseUInt32UInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<uint,ulong> dictionary = new Dictionary<uint,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt32.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<string,ulong> ParseStringUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<string,ulong> dictionary = new Dictionary<string,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(keyValue[0].Substring(1),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<short,ulong> ParseInt16UInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<short,ulong> dictionary = new Dictionary<short,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int16.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,ulong> ParseSByteUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<sbyte,ulong> dictionary = new Dictionary<sbyte,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(SByte.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Rect,ulong> ParseRectUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Rect,ulong> dictionary = new Dictionary<Rect,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseRect(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,ulong> ParseQuaternionUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,ulong> dictionary = new Dictionary<Quaternion,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,ulong> ParseInt64UInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,ulong> dictionary = new Dictionary<long,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,ulong> ParseInt32UInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,ulong> dictionary = new Dictionary<int,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,ulong> ParseSingleUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,ulong> dictionary = new Dictionary<float,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,ulong> ParseDoubleUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,ulong> dictionary = new Dictionary<double,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,ulong> ParseDecimalUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,ulong> dictionary = new Dictionary<decimal,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,ulong> ParseDateTimeUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,ulong> dictionary = new Dictionary<DateTime,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,ulong> ParseColor32UInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,ulong> dictionary = new Dictionary<Color32,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,ulong> ParseColorUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,ulong> dictionary = new Dictionary<Color,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,ulong> ParseCharUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,ulong> dictionary = new Dictionary<char,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,ulong> ParseByteUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,ulong> dictionary = new Dictionary<byte,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,ulong> ParseBooleanUInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,ulong> dictionary = new Dictionary<bool,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<string,uint> ParseStringUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<string,uint> dictionary = new Dictionary<string,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(keyValue[0].Substring(1),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<short,uint> ParseInt16UInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<short,uint> dictionary = new Dictionary<short,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int16.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,uint> ParseSByteUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<sbyte,uint> dictionary = new Dictionary<sbyte,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(SByte.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Rect,uint> ParseRectUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Rect,uint> dictionary = new Dictionary<Rect,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseRect(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,uint> ParseQuaternionUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,uint> dictionary = new Dictionary<Quaternion,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,uint> ParseInt64UInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,uint> dictionary = new Dictionary<long,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,uint> ParseInt32UInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,uint> dictionary = new Dictionary<int,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,uint> ParseSingleUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,uint> dictionary = new Dictionary<float,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,uint> ParseDoubleUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,uint> dictionary = new Dictionary<double,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,uint> ParseDecimalUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,uint> dictionary = new Dictionary<decimal,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,uint> ParseDateTimeUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,uint> dictionary = new Dictionary<DateTime,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,uint> ParseColor32UInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,uint> dictionary = new Dictionary<Color32,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,uint> ParseColorUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,uint> dictionary = new Dictionary<Color,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,uint> ParseCharUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,uint> dictionary = new Dictionary<char,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,uint> ParseByteUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,uint> dictionary = new Dictionary<byte,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,uint> ParseBooleanUInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,uint> dictionary = new Dictionary<bool,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<short,string> ParseInt16StringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<short,string> dictionary = new Dictionary<short,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int16.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,string> ParseSByteStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<sbyte,string> dictionary = new Dictionary<sbyte,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(SByte.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<Rect,string> ParseRectStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Rect,string> dictionary = new Dictionary<Rect,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseRect(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,string> ParseQuaternionStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,string> dictionary = new Dictionary<Quaternion,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<long,string> ParseInt64StringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,string> dictionary = new Dictionary<long,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<int,string> ParseInt32StringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,string> dictionary = new Dictionary<int,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<float,string> ParseSingleStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,string> dictionary = new Dictionary<float,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<double,string> ParseDoubleStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,string> dictionary = new Dictionary<double,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<decimal,string> ParseDecimalStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,string> dictionary = new Dictionary<decimal,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,string> ParseDateTimeStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,string> dictionary = new Dictionary<DateTime,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<Color32,string> ParseColor32StringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,string> dictionary = new Dictionary<Color32,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<Color,string> ParseColorStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,string> dictionary = new Dictionary<Color,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<char,string> ParseCharStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,string> dictionary = new Dictionary<char,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<byte,string> ParseByteStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,string> dictionary = new Dictionary<byte,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<bool,string> ParseBooleanStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,string> dictionary = new Dictionary<bool,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,short> ParseSByteInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<sbyte,short> dictionary = new Dictionary<sbyte,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(SByte.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Rect,short> ParseRectInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Rect,short> dictionary = new Dictionary<Rect,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseRect(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,short> ParseQuaternionInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,short> dictionary = new Dictionary<Quaternion,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,short> ParseInt64Int16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,short> dictionary = new Dictionary<long,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,short> ParseInt32Int16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,short> dictionary = new Dictionary<int,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,short> ParseSingleInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,short> dictionary = new Dictionary<float,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,short> ParseDoubleInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,short> dictionary = new Dictionary<double,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,short> ParseDecimalInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,short> dictionary = new Dictionary<decimal,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,short> ParseDateTimeInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,short> dictionary = new Dictionary<DateTime,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,short> ParseColor32Int16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,short> dictionary = new Dictionary<Color32,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,short> ParseColorInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,short> dictionary = new Dictionary<Color,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,short> ParseCharInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,short> dictionary = new Dictionary<char,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,short> ParseByteInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,short> dictionary = new Dictionary<byte,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,short> ParseBooleanInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,short> dictionary = new Dictionary<bool,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Rect,sbyte> ParseRectSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Rect,sbyte> dictionary = new Dictionary<Rect,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseRect(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,sbyte> ParseQuaternionSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,sbyte> dictionary = new Dictionary<Quaternion,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,sbyte> ParseInt64SByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,sbyte> dictionary = new Dictionary<long,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,sbyte> ParseInt32SByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,sbyte> dictionary = new Dictionary<int,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,sbyte> ParseSingleSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,sbyte> dictionary = new Dictionary<float,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,sbyte> ParseDoubleSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,sbyte> dictionary = new Dictionary<double,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,sbyte> ParseDecimalSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,sbyte> dictionary = new Dictionary<decimal,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,sbyte> ParseDateTimeSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,sbyte> dictionary = new Dictionary<DateTime,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,sbyte> ParseColor32SByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,sbyte> dictionary = new Dictionary<Color32,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,sbyte> ParseColorSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,sbyte> dictionary = new Dictionary<Color,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,sbyte> ParseCharSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,sbyte> dictionary = new Dictionary<char,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,sbyte> ParseByteSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,sbyte> dictionary = new Dictionary<byte,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,sbyte> ParseBooleanSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,sbyte> dictionary = new Dictionary<bool,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Rect> ParseQuaternionRectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,Rect> dictionary = new Dictionary<Quaternion,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,Rect> ParseInt64RectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,Rect> dictionary = new Dictionary<long,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,Rect> ParseInt32RectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,Rect> dictionary = new Dictionary<int,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,Rect> ParseSingleRectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,Rect> dictionary = new Dictionary<float,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,Rect> ParseDoubleRectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,Rect> dictionary = new Dictionary<double,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Rect> ParseDecimalRectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,Rect> dictionary = new Dictionary<decimal,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Rect> ParseDateTimeRectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,Rect> dictionary = new Dictionary<DateTime,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Rect> ParseColor32RectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,Rect> dictionary = new Dictionary<Color32,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,Rect> ParseColorRectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,Rect> dictionary = new Dictionary<Color,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,Rect> ParseCharRectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,Rect> dictionary = new Dictionary<char,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,Rect> ParseByteRectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,Rect> dictionary = new Dictionary<byte,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,Rect> ParseBooleanRectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,Rect> dictionary = new Dictionary<bool,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,Quaternion> ParseInt64QuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,Quaternion> dictionary = new Dictionary<long,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,Quaternion> ParseInt32QuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,Quaternion> dictionary = new Dictionary<int,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,Quaternion> ParseSingleQuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,Quaternion> dictionary = new Dictionary<float,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,Quaternion> ParseDoubleQuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,Quaternion> dictionary = new Dictionary<double,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Quaternion> ParseDecimalQuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,Quaternion> dictionary = new Dictionary<decimal,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Quaternion> ParseDateTimeQuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,Quaternion> dictionary = new Dictionary<DateTime,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Quaternion> ParseColor32QuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,Quaternion> dictionary = new Dictionary<Color32,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,Quaternion> ParseColorQuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,Quaternion> dictionary = new Dictionary<Color,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,Quaternion> ParseCharQuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,Quaternion> dictionary = new Dictionary<char,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,Quaternion> ParseByteQuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,Quaternion> dictionary = new Dictionary<byte,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,Quaternion> ParseBooleanQuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,Quaternion> dictionary = new Dictionary<bool,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,long> ParseInt32Int64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,long> dictionary = new Dictionary<int,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,long> ParseSingleInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,long> dictionary = new Dictionary<float,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,long> ParseDoubleInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,long> dictionary = new Dictionary<double,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,long> ParseDecimalInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,long> dictionary = new Dictionary<decimal,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,long> ParseDateTimeInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,long> dictionary = new Dictionary<DateTime,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,long> ParseColor32Int64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,long> dictionary = new Dictionary<Color32,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,long> ParseColorInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,long> dictionary = new Dictionary<Color,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,long> ParseCharInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,long> dictionary = new Dictionary<char,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,long> ParseByteInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,long> dictionary = new Dictionary<byte,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,long> ParseBooleanInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,long> dictionary = new Dictionary<bool,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,int> ParseSingleInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,int> dictionary = new Dictionary<float,int>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),Int32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,int> ParseDoubleInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,int> dictionary = new Dictionary<double,int>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),Int32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,int> ParseDecimalInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,int> dictionary = new Dictionary<decimal,int>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),Int32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,int> ParseDateTimeInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,int> dictionary = new Dictionary<DateTime,int>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),Int32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,int> ParseColor32Int32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,int> dictionary = new Dictionary<Color32,int>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),Int32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,int> ParseColorInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,int> dictionary = new Dictionary<Color,int>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),Int32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,int> ParseCharInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,int> dictionary = new Dictionary<char,int>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),Int32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,int> ParseByteInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,int> dictionary = new Dictionary<byte,int>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),Int32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,int> ParseBooleanInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,int> dictionary = new Dictionary<bool,int>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),Int32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,float> ParseDoubleSingleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,float> dictionary = new Dictionary<double,float>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),Single.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,float> ParseDecimalSingleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,float> dictionary = new Dictionary<decimal,float>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),Single.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,float> ParseDateTimeSingleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,float> dictionary = new Dictionary<DateTime,float>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),Single.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,float> ParseColor32SingleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,float> dictionary = new Dictionary<Color32,float>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),Single.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,float> ParseColorSingleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,float> dictionary = new Dictionary<Color,float>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),Single.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,float> ParseCharSingleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,float> dictionary = new Dictionary<char,float>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),Single.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,float> ParseByteSingleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,float> dictionary = new Dictionary<byte,float>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),Single.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,float> ParseBooleanSingleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,float> dictionary = new Dictionary<bool,float>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),Single.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,double> ParseDecimalDoubleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,double> dictionary = new Dictionary<decimal,double>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),Double.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,double> ParseDateTimeDoubleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,double> dictionary = new Dictionary<DateTime,double>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),Double.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,double> ParseColor32DoubleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,double> dictionary = new Dictionary<Color32,double>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),Double.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,double> ParseColorDoubleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,double> dictionary = new Dictionary<Color,double>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),Double.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,double> ParseCharDoubleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,double> dictionary = new Dictionary<char,double>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),Double.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,double> ParseByteDoubleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,double> dictionary = new Dictionary<byte,double>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),Double.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,double> ParseBooleanDoubleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,double> dictionary = new Dictionary<bool,double>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),Double.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,decimal> ParseDateTimeDecimalDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,decimal> dictionary = new Dictionary<DateTime,decimal>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),Decimal.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,decimal> ParseColor32DecimalDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,decimal> dictionary = new Dictionary<Color32,decimal>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),Decimal.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,decimal> ParseColorDecimalDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,decimal> dictionary = new Dictionary<Color,decimal>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),Decimal.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,decimal> ParseCharDecimalDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,decimal> dictionary = new Dictionary<char,decimal>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),Decimal.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,decimal> ParseByteDecimalDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,decimal> dictionary = new Dictionary<byte,decimal>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),Decimal.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,decimal> ParseBooleanDecimalDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,decimal> dictionary = new Dictionary<bool,decimal>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),Decimal.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,DateTime> ParseColor32DateTimeDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,DateTime> dictionary = new Dictionary<Color32,DateTime>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),DateTime.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,DateTime> ParseColorDateTimeDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,DateTime> dictionary = new Dictionary<Color,DateTime>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),DateTime.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,DateTime> ParseCharDateTimeDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,DateTime> dictionary = new Dictionary<char,DateTime>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),DateTime.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,DateTime> ParseByteDateTimeDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,DateTime> dictionary = new Dictionary<byte,DateTime>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),DateTime.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,DateTime> ParseBooleanDateTimeDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,DateTime> dictionary = new Dictionary<bool,DateTime>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),DateTime.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,Color32> ParseColorColor32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,Color32> dictionary = new Dictionary<Color,Color32>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),ParseColor32(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,Color32> ParseCharColor32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,Color32> dictionary = new Dictionary<char,Color32>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),ParseColor32(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,Color32> ParseByteColor32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,Color32> dictionary = new Dictionary<byte,Color32>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),ParseColor32(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,Color32> ParseBooleanColor32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,Color32> dictionary = new Dictionary<bool,Color32>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),ParseColor32(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,Color> ParseCharColorDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,Color> dictionary = new Dictionary<char,Color>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),ParseColor(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,Color> ParseByteColorDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,Color> dictionary = new Dictionary<byte,Color>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),ParseColor(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,Color> ParseBooleanColorDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,Color> dictionary = new Dictionary<bool,Color>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),ParseColor(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,char> ParseByteCharDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,char> dictionary = new Dictionary<byte,char>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),Char.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,char> ParseBooleanCharDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,char> dictionary = new Dictionary<bool,char>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),Char.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,byte> ParseBooleanByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,byte> dictionary = new Dictionary<bool,byte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),Byte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<bool,bool> ParseBooleanBooleanDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<bool,bool> dictionary = new Dictionary<bool,bool>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Boolean.Parse(keyValue[0].Substring(1)),Boolean.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<byte,byte> ParseByteByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<byte,byte> dictionary = new Dictionary<byte,byte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Byte.Parse(keyValue[0].Substring(1)),Byte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<char,char> ParseCharCharDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<char,char> dictionary = new Dictionary<char,char>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Char.Parse(keyValue[0].Substring(1)),Char.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color,Color> ParseColorColorDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color,Color> dictionary = new Dictionary<Color,Color>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor(keyValue[0].Substring(1)),ParseColor(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Color32> ParseColor32Color32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Color32,Color32> dictionary = new Dictionary<Color32,Color32>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseColor32(keyValue[0].Substring(1)),ParseColor32(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,DateTime> ParseDateTimeDateTimeDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<DateTime,DateTime> dictionary = new Dictionary<DateTime,DateTime>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(DateTime.Parse(keyValue[0].Substring(1)),DateTime.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<decimal,decimal> ParseDecimalDecimalDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<decimal,decimal> dictionary = new Dictionary<decimal,decimal>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Decimal.Parse(keyValue[0].Substring(1)),Decimal.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<double,double> ParseDoubleDoubleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<double,double> dictionary = new Dictionary<double,double>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Double.Parse(keyValue[0].Substring(1)),Double.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<float,float> ParseSingleSingleDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<float,float> dictionary = new Dictionary<float,float>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Single.Parse(keyValue[0].Substring(1)),Single.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<int,int> ParseInt32Int32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<int,int> dictionary = new Dictionary<int,int>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int32.Parse(keyValue[0].Substring(1)),Int32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<long,long> ParseInt64Int64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<long,long> dictionary = new Dictionary<long,long>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int64.Parse(keyValue[0].Substring(1)),Int64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Quaternion> ParseQuaternionQuaternionDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Quaternion,Quaternion> dictionary = new Dictionary<Quaternion,Quaternion>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseQuaternion(keyValue[0].Substring(1)),ParseQuaternion(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Rect,Rect> ParseRectRectDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Rect,Rect> dictionary = new Dictionary<Rect,Rect>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseRect(keyValue[0].Substring(1)),ParseRect(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,sbyte> ParseSByteSByteDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<sbyte,sbyte> dictionary = new Dictionary<sbyte,sbyte>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(SByte.Parse(keyValue[0].Substring(1)),SByte.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<short,short> ParseInt16Int16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<short,short> dictionary = new Dictionary<short,short>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(Int16.Parse(keyValue[0].Substring(1)),Int16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<string,string> ParseStringStringDictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<string,string> dictionary = new Dictionary<string,string>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(keyValue[0].Substring(1),keyValue[1].Substring(0, keyValue[1].Length - 1));
			}
			return dictionary;
		}
		public static Dictionary<uint,uint> ParseUInt32UInt32Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<uint,uint> dictionary = new Dictionary<uint,uint>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt32.Parse(keyValue[0].Substring(1)),UInt32.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<ulong,ulong> ParseUInt64UInt64Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<ulong,ulong> dictionary = new Dictionary<ulong,ulong>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt64.Parse(keyValue[0].Substring(1)),UInt64.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<ushort,ushort> ParseUInt16UInt16Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<ushort,ushort> dictionary = new Dictionary<ushort,ushort>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(UInt16.Parse(keyValue[0].Substring(1)),UInt16.Parse(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Vector2,Vector2> ParseVector2Vector2Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Vector2,Vector2> dictionary = new Dictionary<Vector2,Vector2>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseVector2(keyValue[0].Substring(1)),ParseVector2(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Vector3,Vector3> ParseVector3Vector3Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Vector3,Vector3> dictionary = new Dictionary<Vector3,Vector3>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseVector3(keyValue[0].Substring(1)),ParseVector3(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
		public static Dictionary<Vector4,Vector4> ParseVector4Vector4Dictionary(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split('|');
			Dictionary<Vector4,Vector4> dictionary = new Dictionary<Vector4,Vector4>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				string[] keyValue = splitValue[i].Split('#');
				dictionary.Add(ParseVector4(keyValue[0].Substring(1)),ParseVector4(keyValue[1].Substring(0, keyValue[1].Length - 1)));
			}
			return dictionary;
		}
	}
}
