using UnityEngine;
using System.IO;
using System;
using System.Collections.Generic;
namespace DE
{
	public static partial class BinaryReaderExtension
	{
		public static Color[] ReadColorArray(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseColorArray(value);
		}
		public static Color32[] ReadColor32Array(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseColor32Array(value);
		}
		public static DateTime[] ReadDateTimeArray(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split(',');
			DateTime[] array = new DateTime[splitValue.Length];
			for (int i = 0; i < splitValue.Length; i++)
			{
				array[i] = new DateTime(Int64.Parse(splitValue[i]));
			}
			return array;
		}
		public static Quaternion[] ReadQuaternionArray(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseQuaternionArray(value);
		}
		public static Rect[] ReadRectArray(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseRectArray(value);
		}
		public static Vector2[] ReadVector2Array(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseVector2Array(value);
		}
		public static Vector3[] ReadVector3Array(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseVector3Array(value);
		}
		public static Vector4[] ReadVector4Array(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseVector4Array(value);
		}
		public static T[] ReadArray<T>(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
			{
				return null;
			}
			return DataTableExtension.ParseArray<T>(value);
		}
	}
}
