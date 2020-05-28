using UnityEngine;
using System.IO;
using System;
using System.Collections.Generic;
namespace DE
{
	public static partial class DataTableExtension
	{
		public static List<Color> ParseColorList(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] items = value.Split('|');
			List<Color> list = new List<Color>(items.Length);
			foreach (string item in items)
			{
				string[] splitValue = value.Split(',');
				for (int i = 0; i < splitValue.Length; i++)
				{
					list.Add(ParseColor(splitValue[i]));
				}
			}
			return list;
		}
		public static List<Color32> ParseColor32List(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] items = value.Split('|');
			List<Color32> list = new List<Color32>(items.Length);
			foreach (string item in items)
			{
				string[] splitValue = value.Split(',');
				for (int i = 0; i < splitValue.Length; i++)
				{
					list.Add(ParseColor32(splitValue[i]));
				}
			}
			return list;
		}
		public static List<Quaternion> ParseQuaternionList(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] items = value.Split('|');
			List<Quaternion> list = new List<Quaternion>(items.Length);
			foreach (string item in items)
			{
				string[] splitValue = value.Split(',');
				for (int i = 0; i < splitValue.Length; i++)
				{
					list.Add(ParseQuaternion(splitValue[i]));
				}
			}
			return list;
		}
		public static List<Rect> ParseRectList(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] items = value.Split('|');
			List<Rect> list = new List<Rect>(items.Length);
			foreach (string item in items)
			{
				string[] splitValue = value.Split(',');
				for (int i = 0; i < splitValue.Length; i++)
				{
					list.Add(ParseRect(splitValue[i]));
				}
			}
			return list;
		}
		public static List<Vector2> ParseVector2List(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] items = value.Split('|');
			List<Vector2> list = new List<Vector2>(items.Length);
			foreach (string item in items)
			{
				string[] splitValue = value.Split(',');
				for (int i = 0; i < splitValue.Length; i++)
				{
					list.Add(ParseVector2(splitValue[i]));
				}
			}
			return list;
		}
		public static List<Vector3> ParseVector3List(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] items = value.Split('|');
			List<Vector3> list = new List<Vector3>(items.Length);
			foreach (string item in items)
			{
				string[] splitValue = value.Split(',');
				for (int i = 0; i < splitValue.Length; i++)
				{
					list.Add(ParseVector3(splitValue[i]));
				}
			}
			return list;
		}
		public static List<Vector4> ParseVector4List(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] items = value.Split('|');
			List<Vector4> list = new List<Vector4>(items.Length);
			foreach (string item in items)
			{
				string[] splitValue = value.Split(',');
				for (int i = 0; i < splitValue.Length; i++)
				{
					list.Add(ParseVector4(splitValue[i]));
				}
			}
			return list;
		}
		public static List<T> ParseList<T>(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return null;
			}
			string[] items = value.Split('|');
			List<T> list = new List<T>(items.Length);
			foreach (string item in items)
			{
				string[] splitValue = value.Split(',');
				for (int i = 0; i < splitValue.Length; i++)
				{
					T t = DataTableExtensionHelper.Parse<T>(splitValue[i]);
					list.Add(t);
				}
			}
			return list;
		}
	}
}
