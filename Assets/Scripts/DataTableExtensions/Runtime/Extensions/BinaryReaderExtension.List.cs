using UnityEngine;
using System.IO;
using System;
using System.Collections.Generic;
namespace DE
{
	public static partial class BinaryReaderExtension
	{
		public static List<Color> ReadColorList(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseColorList(value);
		}
		public static List<Color32> ReadColor32List(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseColor32List(value);
		}
		public static List<DateTime> ReadDateTimeList(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split(',');
			List<DateTime> list = new List<DateTime>(splitValue.Length);
			for (int i = 0; i < splitValue.Length; i++)
			{
				list.Add(new DateTime(Int64.Parse(splitValue[i])));
			}
			return list;
		}
		public static List<Quaternion> ReadQuaternionList(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseQuaternionList(value);
		}
		public static List<Rect> ReadRectList(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseRectList(value);
		}
		public static List<Vector2> ReadVector2List(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseVector2List(value);
		}
		public static List<Vector3> ReadVector3List(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseVector3List(value);
		}
		public static List<Vector4> ReadVector4List(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
				return null;
			return DataTableExtension.ParseVector4List(value);
		}
		public static List<T> ReadList<T>(this BinaryReader binaryReader)
		{
			string value = binaryReader.ReadString();
			if (string.IsNullOrEmpty(value))
			{
				return null;
			}
			return DataTableExtension.ParseList<T>(value);
		}
	}
}
