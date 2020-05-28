using UnityEngine;
using System.IO;
using System;
using System.Collections.Generic;
namespace DE
{
	public static partial class DataTableExtension
	{
		public static Color[] ParseColorArray(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split(',');
			Color[] array = new Color[splitValue.Length];
			for (int i = 0; i < splitValue.Length; i++)
			{
				array[i] = ParseColor(splitValue[i]);
			}

			return array;
		}
		public static Color32[] ParseColor32Array(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split(',');
			Color32[] array = new Color32[splitValue.Length];
			for (int i = 0; i < splitValue.Length; i++)
			{
				array[i] = ParseColor32(splitValue[i]);
			}

			return array;
		}
		public static Quaternion[] ParseQuaternionArray(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split(',');
			Quaternion[] array = new Quaternion[splitValue.Length];
			for (int i = 0; i < splitValue.Length; i++)
			{
				array[i] = ParseQuaternion(splitValue[i]);
			}

			return array;
		}
		public static Rect[] ParseRectArray(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split(',');
			Rect[] array = new Rect[splitValue.Length];
			for (int i = 0; i < splitValue.Length; i++)
			{
				array[i] = ParseRect(splitValue[i]);
			}

			return array;
		}
		public static Vector2[] ParseVector2Array(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split(',');
			Vector2[] array = new Vector2[splitValue.Length];
			for (int i = 0; i < splitValue.Length; i++)
			{
				array[i] = ParseVector2(splitValue[i]);
			}

			return array;
		}
		public static Vector3[] ParseVector3Array(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split(',');
			Vector3[] array = new Vector3[splitValue.Length];
			for (int i = 0; i < splitValue.Length; i++)
			{
				array[i] = ParseVector3(splitValue[i]);
			}

			return array;
		}
		public static Vector4[] ParseVector4Array(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			string[] splitValue = value.Split(',');
			Vector4[] array = new Vector4[splitValue.Length];
			for (int i = 0; i < splitValue.Length; i++)
			{
				array[i] = ParseVector4(splitValue[i]);
			}

			return array;
		}
		public static T[] ParseArray<T>(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return null;
			}
			string[] splitValue = value.Split(',');
			T[] array = new T[splitValue.Length];
			for (int i = 0; i < splitValue.Length; i++)
			{
				T t = DataTableExtensionHelper.Parse<T>(splitValue[i]);
				array[i] = t;
			}
			 return array;
		}
	}
}
