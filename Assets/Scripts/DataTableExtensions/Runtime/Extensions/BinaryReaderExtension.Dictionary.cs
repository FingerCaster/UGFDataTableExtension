using UnityEngine;
using System.IO;
using System;
using System.Collections.Generic;
namespace DE
{
	public static partial class BinaryReaderExtension
	{
		public static Dictionary<Vector3,Vector4> ReadVector3Vector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,Vector4> dictionary = new Dictionary<Vector3,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector2,Vector4> ReadVector2Vector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,Vector4> dictionary = new Dictionary<Vector2,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ushort,Vector4> ReadUInt16Vector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,Vector4> dictionary = new Dictionary<ushort,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ulong,Vector4> ReadUInt64Vector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,Vector4> dictionary = new Dictionary<ulong,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<uint,Vector4> ReadUInt32Vector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,Vector4> dictionary = new Dictionary<uint,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<string,Vector4> ReadStringVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,Vector4> dictionary = new Dictionary<string,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<short,Vector4> ReadInt16Vector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,Vector4> dictionary = new Dictionary<short,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,Vector4> ReadSByteVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,Vector4> dictionary = new Dictionary<sbyte,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Rect,Vector4> ReadRectVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,Vector4> dictionary = new Dictionary<Rect,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Vector4> ReadQuaternionVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,Vector4> dictionary = new Dictionary<Quaternion,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<long,Vector4> ReadInt64Vector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,Vector4> dictionary = new Dictionary<long,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<int,Vector4> ReadInt32Vector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,Vector4> dictionary = new Dictionary<int,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<float,Vector4> ReadSingleVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,Vector4> dictionary = new Dictionary<float,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<double,Vector4> ReadDoubleVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,Vector4> dictionary = new Dictionary<double,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Vector4> ReadDecimalVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,Vector4> dictionary = new Dictionary<decimal,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Vector4> ReadDateTimeVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,Vector4> dictionary = new Dictionary<DateTime,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Vector4> ReadColor32Vector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,Vector4> dictionary = new Dictionary<Color32,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color,Vector4> ReadColorVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,Vector4> dictionary = new Dictionary<Color,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<char,Vector4> ReadCharVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,Vector4> dictionary = new Dictionary<char,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<byte,Vector4> ReadByteVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,Vector4> dictionary = new Dictionary<byte,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<bool,Vector4> ReadBooleanVector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,Vector4> dictionary = new Dictionary<bool,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),ReadVector4(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector2,Vector3> ReadVector2Vector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,Vector3> dictionary = new Dictionary<Vector2,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ushort,Vector3> ReadUInt16Vector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,Vector3> dictionary = new Dictionary<ushort,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ulong,Vector3> ReadUInt64Vector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,Vector3> dictionary = new Dictionary<ulong,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<uint,Vector3> ReadUInt32Vector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,Vector3> dictionary = new Dictionary<uint,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<string,Vector3> ReadStringVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,Vector3> dictionary = new Dictionary<string,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<short,Vector3> ReadInt16Vector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,Vector3> dictionary = new Dictionary<short,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,Vector3> ReadSByteVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,Vector3> dictionary = new Dictionary<sbyte,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Rect,Vector3> ReadRectVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,Vector3> dictionary = new Dictionary<Rect,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Vector3> ReadQuaternionVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,Vector3> dictionary = new Dictionary<Quaternion,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<long,Vector3> ReadInt64Vector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,Vector3> dictionary = new Dictionary<long,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<int,Vector3> ReadInt32Vector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,Vector3> dictionary = new Dictionary<int,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<float,Vector3> ReadSingleVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,Vector3> dictionary = new Dictionary<float,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<double,Vector3> ReadDoubleVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,Vector3> dictionary = new Dictionary<double,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Vector3> ReadDecimalVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,Vector3> dictionary = new Dictionary<decimal,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Vector3> ReadDateTimeVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,Vector3> dictionary = new Dictionary<DateTime,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Vector3> ReadColor32Vector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,Vector3> dictionary = new Dictionary<Color32,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color,Vector3> ReadColorVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,Vector3> dictionary = new Dictionary<Color,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<char,Vector3> ReadCharVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,Vector3> dictionary = new Dictionary<char,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<byte,Vector3> ReadByteVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,Vector3> dictionary = new Dictionary<byte,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<bool,Vector3> ReadBooleanVector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,Vector3> dictionary = new Dictionary<bool,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ushort,Vector2> ReadUInt16Vector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,Vector2> dictionary = new Dictionary<ushort,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ulong,Vector2> ReadUInt64Vector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,Vector2> dictionary = new Dictionary<ulong,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<uint,Vector2> ReadUInt32Vector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,Vector2> dictionary = new Dictionary<uint,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<string,Vector2> ReadStringVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,Vector2> dictionary = new Dictionary<string,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<short,Vector2> ReadInt16Vector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,Vector2> dictionary = new Dictionary<short,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,Vector2> ReadSByteVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,Vector2> dictionary = new Dictionary<sbyte,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Rect,Vector2> ReadRectVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,Vector2> dictionary = new Dictionary<Rect,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Vector2> ReadQuaternionVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,Vector2> dictionary = new Dictionary<Quaternion,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<long,Vector2> ReadInt64Vector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,Vector2> dictionary = new Dictionary<long,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<int,Vector2> ReadInt32Vector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,Vector2> dictionary = new Dictionary<int,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<float,Vector2> ReadSingleVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,Vector2> dictionary = new Dictionary<float,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<double,Vector2> ReadDoubleVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,Vector2> dictionary = new Dictionary<double,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Vector2> ReadDecimalVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,Vector2> dictionary = new Dictionary<decimal,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Vector2> ReadDateTimeVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,Vector2> dictionary = new Dictionary<DateTime,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Vector2> ReadColor32Vector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,Vector2> dictionary = new Dictionary<Color32,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color,Vector2> ReadColorVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,Vector2> dictionary = new Dictionary<Color,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<char,Vector2> ReadCharVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,Vector2> dictionary = new Dictionary<char,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<byte,Vector2> ReadByteVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,Vector2> dictionary = new Dictionary<byte,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<bool,Vector2> ReadBooleanVector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,Vector2> dictionary = new Dictionary<bool,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ulong,ushort> ReadUInt64UInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,ushort> dictionary = new Dictionary<ulong,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<uint,ushort> ReadUInt32UInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,ushort> dictionary = new Dictionary<uint,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<string,ushort> ReadStringUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,ushort> dictionary = new Dictionary<string,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<short,ushort> ReadInt16UInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,ushort> dictionary = new Dictionary<short,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,ushort> ReadSByteUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,ushort> dictionary = new Dictionary<sbyte,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<Rect,ushort> ReadRectUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,ushort> dictionary = new Dictionary<Rect,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,ushort> ReadQuaternionUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,ushort> dictionary = new Dictionary<Quaternion,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<long,ushort> ReadInt64UInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,ushort> dictionary = new Dictionary<long,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<int,ushort> ReadInt32UInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,ushort> dictionary = new Dictionary<int,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<float,ushort> ReadSingleUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,ushort> dictionary = new Dictionary<float,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<double,ushort> ReadDoubleUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,ushort> dictionary = new Dictionary<double,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<decimal,ushort> ReadDecimalUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,ushort> dictionary = new Dictionary<decimal,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,ushort> ReadDateTimeUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,ushort> dictionary = new Dictionary<DateTime,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<Color32,ushort> ReadColor32UInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,ushort> dictionary = new Dictionary<Color32,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<Color,ushort> ReadColorUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,ushort> dictionary = new Dictionary<Color,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<char,ushort> ReadCharUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,ushort> dictionary = new Dictionary<char,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<byte,ushort> ReadByteUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,ushort> dictionary = new Dictionary<byte,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<bool,ushort> ReadBooleanUInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,ushort> dictionary = new Dictionary<bool,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<uint,ulong> ReadUInt32UInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,ulong> dictionary = new Dictionary<uint,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<string,ulong> ReadStringUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,ulong> dictionary = new Dictionary<string,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadUInt64());
			}
			return dictionary;
		}
		public static Dictionary<short,ulong> ReadInt16UInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,ulong> dictionary = new Dictionary<short,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadUInt64());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,ulong> ReadSByteUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,ulong> dictionary = new Dictionary<sbyte,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadUInt64());
			}
			return dictionary;
		}
		public static Dictionary<Rect,ulong> ReadRectUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,ulong> dictionary = new Dictionary<Rect,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,ulong> ReadQuaternionUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,ulong> dictionary = new Dictionary<Quaternion,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<long,ulong> ReadInt64UInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,ulong> dictionary = new Dictionary<long,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<int,ulong> ReadInt32UInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,ulong> dictionary = new Dictionary<int,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<float,ulong> ReadSingleUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,ulong> dictionary = new Dictionary<float,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadUInt64());
			}
			return dictionary;
		}
		public static Dictionary<double,ulong> ReadDoubleUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,ulong> dictionary = new Dictionary<double,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadUInt64());
			}
			return dictionary;
		}
		public static Dictionary<decimal,ulong> ReadDecimalUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,ulong> dictionary = new Dictionary<decimal,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadUInt64());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,ulong> ReadDateTimeUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,ulong> dictionary = new Dictionary<DateTime,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<Color32,ulong> ReadColor32UInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,ulong> dictionary = new Dictionary<Color32,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<Color,ulong> ReadColorUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,ulong> dictionary = new Dictionary<Color,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<char,ulong> ReadCharUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,ulong> dictionary = new Dictionary<char,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadUInt64());
			}
			return dictionary;
		}
		public static Dictionary<byte,ulong> ReadByteUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,ulong> dictionary = new Dictionary<byte,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadUInt64());
			}
			return dictionary;
		}
		public static Dictionary<bool,ulong> ReadBooleanUInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,ulong> dictionary = new Dictionary<bool,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadUInt64());
			}
			return dictionary;
		}
		public static Dictionary<string,uint> ReadStringUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,uint> dictionary = new Dictionary<string,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadUInt32());
			}
			return dictionary;
		}
		public static Dictionary<short,uint> ReadInt16UInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,uint> dictionary = new Dictionary<short,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadUInt32());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,uint> ReadSByteUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,uint> dictionary = new Dictionary<sbyte,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadUInt32());
			}
			return dictionary;
		}
		public static Dictionary<Rect,uint> ReadRectUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,uint> dictionary = new Dictionary<Rect,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,uint> ReadQuaternionUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,uint> dictionary = new Dictionary<Quaternion,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<long,uint> ReadInt64UInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,uint> dictionary = new Dictionary<long,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<int,uint> ReadInt32UInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,uint> dictionary = new Dictionary<int,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<float,uint> ReadSingleUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,uint> dictionary = new Dictionary<float,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadUInt32());
			}
			return dictionary;
		}
		public static Dictionary<double,uint> ReadDoubleUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,uint> dictionary = new Dictionary<double,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadUInt32());
			}
			return dictionary;
		}
		public static Dictionary<decimal,uint> ReadDecimalUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,uint> dictionary = new Dictionary<decimal,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadUInt32());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,uint> ReadDateTimeUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,uint> dictionary = new Dictionary<DateTime,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<Color32,uint> ReadColor32UInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,uint> dictionary = new Dictionary<Color32,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<Color,uint> ReadColorUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,uint> dictionary = new Dictionary<Color,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<char,uint> ReadCharUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,uint> dictionary = new Dictionary<char,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadUInt32());
			}
			return dictionary;
		}
		public static Dictionary<byte,uint> ReadByteUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,uint> dictionary = new Dictionary<byte,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadUInt32());
			}
			return dictionary;
		}
		public static Dictionary<bool,uint> ReadBooleanUInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,uint> dictionary = new Dictionary<bool,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadUInt32());
			}
			return dictionary;
		}
		public static Dictionary<short,string> ReadInt16StringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,string> dictionary = new Dictionary<short,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,string> ReadSByteStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,string> dictionary = new Dictionary<sbyte,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<Rect,string> ReadRectStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,string> dictionary = new Dictionary<Rect,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,string> ReadQuaternionStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,string> dictionary = new Dictionary<Quaternion,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<long,string> ReadInt64StringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,string> dictionary = new Dictionary<long,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<int,string> ReadInt32StringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,string> dictionary = new Dictionary<int,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<float,string> ReadSingleStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,string> dictionary = new Dictionary<float,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<double,string> ReadDoubleStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,string> dictionary = new Dictionary<double,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<decimal,string> ReadDecimalStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,string> dictionary = new Dictionary<decimal,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,string> ReadDateTimeStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,string> dictionary = new Dictionary<DateTime,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<Color32,string> ReadColor32StringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,string> dictionary = new Dictionary<Color32,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<Color,string> ReadColorStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,string> dictionary = new Dictionary<Color,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<char,string> ReadCharStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,string> dictionary = new Dictionary<char,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<byte,string> ReadByteStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,string> dictionary = new Dictionary<byte,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<bool,string> ReadBooleanStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,string> dictionary = new Dictionary<bool,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,short> ReadSByteInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,short> dictionary = new Dictionary<sbyte,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<Rect,short> ReadRectInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,short> dictionary = new Dictionary<Rect,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,short> ReadQuaternionInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,short> dictionary = new Dictionary<Quaternion,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<long,short> ReadInt64Int16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,short> dictionary = new Dictionary<long,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<int,short> ReadInt32Int16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,short> dictionary = new Dictionary<int,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<float,short> ReadSingleInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,short> dictionary = new Dictionary<float,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<double,short> ReadDoubleInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,short> dictionary = new Dictionary<double,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<decimal,short> ReadDecimalInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,short> dictionary = new Dictionary<decimal,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,short> ReadDateTimeInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,short> dictionary = new Dictionary<DateTime,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<Color32,short> ReadColor32Int16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,short> dictionary = new Dictionary<Color32,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<Color,short> ReadColorInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,short> dictionary = new Dictionary<Color,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<char,short> ReadCharInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,short> dictionary = new Dictionary<char,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<byte,short> ReadByteInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,short> dictionary = new Dictionary<byte,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<bool,short> ReadBooleanInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,short> dictionary = new Dictionary<bool,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<Rect,sbyte> ReadRectSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,sbyte> dictionary = new Dictionary<Rect,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,sbyte> ReadQuaternionSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,sbyte> dictionary = new Dictionary<Quaternion,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<long,sbyte> ReadInt64SByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,sbyte> dictionary = new Dictionary<long,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<int,sbyte> ReadInt32SByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,sbyte> dictionary = new Dictionary<int,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<float,sbyte> ReadSingleSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,sbyte> dictionary = new Dictionary<float,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<double,sbyte> ReadDoubleSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,sbyte> dictionary = new Dictionary<double,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<decimal,sbyte> ReadDecimalSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,sbyte> dictionary = new Dictionary<decimal,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,sbyte> ReadDateTimeSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,sbyte> dictionary = new Dictionary<DateTime,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<Color32,sbyte> ReadColor32SByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,sbyte> dictionary = new Dictionary<Color32,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<Color,sbyte> ReadColorSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,sbyte> dictionary = new Dictionary<Color,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<char,sbyte> ReadCharSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,sbyte> dictionary = new Dictionary<char,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<byte,sbyte> ReadByteSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,sbyte> dictionary = new Dictionary<byte,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<bool,sbyte> ReadBooleanSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,sbyte> dictionary = new Dictionary<bool,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Rect> ReadQuaternionRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,Rect> dictionary = new Dictionary<Quaternion,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<long,Rect> ReadInt64RectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,Rect> dictionary = new Dictionary<long,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<int,Rect> ReadInt32RectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,Rect> dictionary = new Dictionary<int,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<float,Rect> ReadSingleRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,Rect> dictionary = new Dictionary<float,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<double,Rect> ReadDoubleRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,Rect> dictionary = new Dictionary<double,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Rect> ReadDecimalRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,Rect> dictionary = new Dictionary<decimal,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Rect> ReadDateTimeRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,Rect> dictionary = new Dictionary<DateTime,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Rect> ReadColor32RectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,Rect> dictionary = new Dictionary<Color32,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color,Rect> ReadColorRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,Rect> dictionary = new Dictionary<Color,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<char,Rect> ReadCharRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,Rect> dictionary = new Dictionary<char,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<byte,Rect> ReadByteRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,Rect> dictionary = new Dictionary<byte,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<bool,Rect> ReadBooleanRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,Rect> dictionary = new Dictionary<bool,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<long,Quaternion> ReadInt64QuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,Quaternion> dictionary = new Dictionary<long,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<int,Quaternion> ReadInt32QuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,Quaternion> dictionary = new Dictionary<int,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<float,Quaternion> ReadSingleQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,Quaternion> dictionary = new Dictionary<float,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<double,Quaternion> ReadDoubleQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,Quaternion> dictionary = new Dictionary<double,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Quaternion> ReadDecimalQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,Quaternion> dictionary = new Dictionary<decimal,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Quaternion> ReadDateTimeQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,Quaternion> dictionary = new Dictionary<DateTime,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Quaternion> ReadColor32QuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,Quaternion> dictionary = new Dictionary<Color32,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color,Quaternion> ReadColorQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,Quaternion> dictionary = new Dictionary<Color,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<char,Quaternion> ReadCharQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,Quaternion> dictionary = new Dictionary<char,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<byte,Quaternion> ReadByteQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,Quaternion> dictionary = new Dictionary<byte,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<bool,Quaternion> ReadBooleanQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,Quaternion> dictionary = new Dictionary<bool,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<int,long> ReadInt32Int64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,long> dictionary = new Dictionary<int,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<float,long> ReadSingleInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,long> dictionary = new Dictionary<float,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadInt64());
			}
			return dictionary;
		}
		public static Dictionary<double,long> ReadDoubleInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,long> dictionary = new Dictionary<double,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadInt64());
			}
			return dictionary;
		}
		public static Dictionary<decimal,long> ReadDecimalInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,long> dictionary = new Dictionary<decimal,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadInt64());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,long> ReadDateTimeInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,long> dictionary = new Dictionary<DateTime,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<Color32,long> ReadColor32Int64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,long> dictionary = new Dictionary<Color32,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<Color,long> ReadColorInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,long> dictionary = new Dictionary<Color,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<char,long> ReadCharInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,long> dictionary = new Dictionary<char,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadInt64());
			}
			return dictionary;
		}
		public static Dictionary<byte,long> ReadByteInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,long> dictionary = new Dictionary<byte,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadInt64());
			}
			return dictionary;
		}
		public static Dictionary<bool,long> ReadBooleanInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,long> dictionary = new Dictionary<bool,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadInt64());
			}
			return dictionary;
		}
		public static Dictionary<float,int> ReadSingleInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,int> dictionary = new Dictionary<float,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadInt32());
			}
			return dictionary;
		}
		public static Dictionary<double,int> ReadDoubleInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,int> dictionary = new Dictionary<double,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadInt32());
			}
			return dictionary;
		}
		public static Dictionary<decimal,int> ReadDecimalInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,int> dictionary = new Dictionary<decimal,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadInt32());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,int> ReadDateTimeInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,int> dictionary = new Dictionary<DateTime,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<Color32,int> ReadColor32Int32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,int> dictionary = new Dictionary<Color32,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<Color,int> ReadColorInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,int> dictionary = new Dictionary<Color,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<char,int> ReadCharInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,int> dictionary = new Dictionary<char,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadInt32());
			}
			return dictionary;
		}
		public static Dictionary<byte,int> ReadByteInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,int> dictionary = new Dictionary<byte,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadInt32());
			}
			return dictionary;
		}
		public static Dictionary<bool,int> ReadBooleanInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,int> dictionary = new Dictionary<bool,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadInt32());
			}
			return dictionary;
		}
		public static Dictionary<double,float> ReadDoubleSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,float> dictionary = new Dictionary<double,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<decimal,float> ReadDecimalSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,float> dictionary = new Dictionary<decimal,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,float> ReadDateTimeSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,float> dictionary = new Dictionary<DateTime,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<Color32,float> ReadColor32SingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,float> dictionary = new Dictionary<Color32,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<Color,float> ReadColorSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,float> dictionary = new Dictionary<Color,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<char,float> ReadCharSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,float> dictionary = new Dictionary<char,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<byte,float> ReadByteSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,float> dictionary = new Dictionary<byte,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<bool,float> ReadBooleanSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,float> dictionary = new Dictionary<bool,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<decimal,double> ReadDecimalDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,double> dictionary = new Dictionary<decimal,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,double> ReadDateTimeDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,double> dictionary = new Dictionary<DateTime,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<Color32,double> ReadColor32DoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,double> dictionary = new Dictionary<Color32,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<Color,double> ReadColorDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,double> dictionary = new Dictionary<Color,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<char,double> ReadCharDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,double> dictionary = new Dictionary<char,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<byte,double> ReadByteDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,double> dictionary = new Dictionary<byte,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<bool,double> ReadBooleanDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,double> dictionary = new Dictionary<bool,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,decimal> ReadDateTimeDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,decimal> dictionary = new Dictionary<DateTime,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<Color32,decimal> ReadColor32DecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,decimal> dictionary = new Dictionary<Color32,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<Color,decimal> ReadColorDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,decimal> dictionary = new Dictionary<Color,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<char,decimal> ReadCharDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,decimal> dictionary = new Dictionary<char,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<byte,decimal> ReadByteDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,decimal> dictionary = new Dictionary<byte,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<bool,decimal> ReadBooleanDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,decimal> dictionary = new Dictionary<bool,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<Color32,DateTime> ReadColor32DateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,DateTime> dictionary = new Dictionary<Color32,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color,DateTime> ReadColorDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,DateTime> dictionary = new Dictionary<Color,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<char,DateTime> ReadCharDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,DateTime> dictionary = new Dictionary<char,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<byte,DateTime> ReadByteDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,DateTime> dictionary = new Dictionary<byte,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<bool,DateTime> ReadBooleanDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,DateTime> dictionary = new Dictionary<bool,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color,Color32> ReadColorColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,Color32> dictionary = new Dictionary<Color,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<char,Color32> ReadCharColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,Color32> dictionary = new Dictionary<char,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<byte,Color32> ReadByteColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,Color32> dictionary = new Dictionary<byte,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<bool,Color32> ReadBooleanColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,Color32> dictionary = new Dictionary<bool,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<char,Color> ReadCharColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,Color> dictionary = new Dictionary<char,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<byte,Color> ReadByteColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,Color> dictionary = new Dictionary<byte,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<bool,Color> ReadBooleanColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,Color> dictionary = new Dictionary<bool,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<byte,char> ReadByteCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,char> dictionary = new Dictionary<byte,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<bool,char> ReadBooleanCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,char> dictionary = new Dictionary<bool,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<bool,byte> ReadBooleanByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,byte> dictionary = new Dictionary<bool,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,Vector3> ReadVector4Vector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,Vector3> dictionary = new Dictionary<Vector4,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector4,Vector2> ReadVector4Vector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,Vector2> dictionary = new Dictionary<Vector4,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector4,ushort> ReadVector4UInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,ushort> dictionary = new Dictionary<Vector4,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,ulong> ReadVector4UInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,ulong> dictionary = new Dictionary<Vector4,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,uint> ReadVector4UInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,uint> dictionary = new Dictionary<Vector4,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,string> ReadVector4StringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,string> dictionary = new Dictionary<Vector4,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,short> ReadVector4Int16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,short> dictionary = new Dictionary<Vector4,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,sbyte> ReadVector4SByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,sbyte> dictionary = new Dictionary<Vector4,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,Rect> ReadVector4RectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,Rect> dictionary = new Dictionary<Vector4,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector4,Quaternion> ReadVector4QuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,Quaternion> dictionary = new Dictionary<Vector4,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector4,long> ReadVector4Int64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,long> dictionary = new Dictionary<Vector4,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,int> ReadVector4Int32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,int> dictionary = new Dictionary<Vector4,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,float> ReadVector4SingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,float> dictionary = new Dictionary<Vector4,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,double> ReadVector4DoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,double> dictionary = new Dictionary<Vector4,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,decimal> ReadVector4DecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,decimal> dictionary = new Dictionary<Vector4,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,DateTime> ReadVector4DateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,DateTime> dictionary = new Dictionary<Vector4,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector4,Color32> ReadVector4Color32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,Color32> dictionary = new Dictionary<Vector4,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector4,Color> ReadVector4ColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,Color> dictionary = new Dictionary<Vector4,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector4,char> ReadVector4CharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,char> dictionary = new Dictionary<Vector4,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,byte> ReadVector4ByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,byte> dictionary = new Dictionary<Vector4,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<Vector4,bool> ReadVector4BooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,bool> dictionary = new Dictionary<Vector4,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,Vector2> ReadVector3Vector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,Vector2> dictionary = new Dictionary<Vector3,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector3,ushort> ReadVector3UInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,ushort> dictionary = new Dictionary<Vector3,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,ulong> ReadVector3UInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,ulong> dictionary = new Dictionary<Vector3,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,uint> ReadVector3UInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,uint> dictionary = new Dictionary<Vector3,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,string> ReadVector3StringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,string> dictionary = new Dictionary<Vector3,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,short> ReadVector3Int16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,short> dictionary = new Dictionary<Vector3,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,sbyte> ReadVector3SByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,sbyte> dictionary = new Dictionary<Vector3,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,Rect> ReadVector3RectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,Rect> dictionary = new Dictionary<Vector3,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector3,Quaternion> ReadVector3QuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,Quaternion> dictionary = new Dictionary<Vector3,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector3,long> ReadVector3Int64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,long> dictionary = new Dictionary<Vector3,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,int> ReadVector3Int32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,int> dictionary = new Dictionary<Vector3,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,float> ReadVector3SingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,float> dictionary = new Dictionary<Vector3,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,double> ReadVector3DoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,double> dictionary = new Dictionary<Vector3,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,decimal> ReadVector3DecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,decimal> dictionary = new Dictionary<Vector3,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,DateTime> ReadVector3DateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,DateTime> dictionary = new Dictionary<Vector3,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector3,Color32> ReadVector3Color32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,Color32> dictionary = new Dictionary<Vector3,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector3,Color> ReadVector3ColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,Color> dictionary = new Dictionary<Vector3,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector3,char> ReadVector3CharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,char> dictionary = new Dictionary<Vector3,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,byte> ReadVector3ByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,byte> dictionary = new Dictionary<Vector3,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<Vector3,bool> ReadVector3BooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,bool> dictionary = new Dictionary<Vector3,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,ushort> ReadVector2UInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,ushort> dictionary = new Dictionary<Vector2,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,ulong> ReadVector2UInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,ulong> dictionary = new Dictionary<Vector2,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,uint> ReadVector2UInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,uint> dictionary = new Dictionary<Vector2,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,string> ReadVector2StringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,string> dictionary = new Dictionary<Vector2,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,short> ReadVector2Int16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,short> dictionary = new Dictionary<Vector2,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,sbyte> ReadVector2SByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,sbyte> dictionary = new Dictionary<Vector2,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,Rect> ReadVector2RectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,Rect> dictionary = new Dictionary<Vector2,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector2,Quaternion> ReadVector2QuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,Quaternion> dictionary = new Dictionary<Vector2,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector2,long> ReadVector2Int64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,long> dictionary = new Dictionary<Vector2,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,int> ReadVector2Int32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,int> dictionary = new Dictionary<Vector2,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,float> ReadVector2SingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,float> dictionary = new Dictionary<Vector2,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,double> ReadVector2DoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,double> dictionary = new Dictionary<Vector2,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,decimal> ReadVector2DecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,decimal> dictionary = new Dictionary<Vector2,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,DateTime> ReadVector2DateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,DateTime> dictionary = new Dictionary<Vector2,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector2,Color32> ReadVector2Color32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,Color32> dictionary = new Dictionary<Vector2,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector2,Color> ReadVector2ColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,Color> dictionary = new Dictionary<Vector2,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector2,char> ReadVector2CharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,char> dictionary = new Dictionary<Vector2,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,byte> ReadVector2ByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,byte> dictionary = new Dictionary<Vector2,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,bool> ReadVector2BooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,bool> dictionary = new Dictionary<Vector2,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<ushort,ulong> ReadUInt16UInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,ulong> dictionary = new Dictionary<ushort,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadUInt64());
			}
			return dictionary;
		}
		public static Dictionary<ushort,uint> ReadUInt16UInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,uint> dictionary = new Dictionary<ushort,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadUInt32());
			}
			return dictionary;
		}
		public static Dictionary<ushort,string> ReadUInt16StringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,string> dictionary = new Dictionary<ushort,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<ushort,short> ReadUInt16Int16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,short> dictionary = new Dictionary<ushort,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<ushort,sbyte> ReadUInt16SByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,sbyte> dictionary = new Dictionary<ushort,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<ushort,Rect> ReadUInt16RectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,Rect> dictionary = new Dictionary<ushort,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ushort,Quaternion> ReadUInt16QuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,Quaternion> dictionary = new Dictionary<ushort,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ushort,long> ReadUInt16Int64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,long> dictionary = new Dictionary<ushort,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadInt64());
			}
			return dictionary;
		}
		public static Dictionary<ushort,int> ReadUInt16Int32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,int> dictionary = new Dictionary<ushort,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadInt32());
			}
			return dictionary;
		}
		public static Dictionary<ushort,float> ReadUInt16SingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,float> dictionary = new Dictionary<ushort,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<ushort,double> ReadUInt16DoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,double> dictionary = new Dictionary<ushort,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<ushort,decimal> ReadUInt16DecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,decimal> dictionary = new Dictionary<ushort,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<ushort,DateTime> ReadUInt16DateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,DateTime> dictionary = new Dictionary<ushort,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ushort,Color32> ReadUInt16Color32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,Color32> dictionary = new Dictionary<ushort,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ushort,Color> ReadUInt16ColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,Color> dictionary = new Dictionary<ushort,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ushort,char> ReadUInt16CharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,char> dictionary = new Dictionary<ushort,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<ushort,byte> ReadUInt16ByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,byte> dictionary = new Dictionary<ushort,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<ushort,bool> ReadUInt16BooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,bool> dictionary = new Dictionary<ushort,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<ulong,uint> ReadUInt64UInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,uint> dictionary = new Dictionary<ulong,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<ulong,string> ReadUInt64StringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,string> dictionary = new Dictionary<ulong,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<ulong,short> ReadUInt64Int16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,short> dictionary = new Dictionary<ulong,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<ulong,sbyte> ReadUInt64SByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,sbyte> dictionary = new Dictionary<ulong,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<ulong,Rect> ReadUInt64RectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,Rect> dictionary = new Dictionary<ulong,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ulong,Quaternion> ReadUInt64QuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,Quaternion> dictionary = new Dictionary<ulong,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ulong,long> ReadUInt64Int64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,long> dictionary = new Dictionary<ulong,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<ulong,int> ReadUInt64Int32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,int> dictionary = new Dictionary<ulong,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<ulong,float> ReadUInt64SingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,float> dictionary = new Dictionary<ulong,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<ulong,double> ReadUInt64DoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,double> dictionary = new Dictionary<ulong,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<ulong,decimal> ReadUInt64DecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,decimal> dictionary = new Dictionary<ulong,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<ulong,DateTime> ReadUInt64DateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,DateTime> dictionary = new Dictionary<ulong,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ulong,Color32> ReadUInt64Color32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,Color32> dictionary = new Dictionary<ulong,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ulong,Color> ReadUInt64ColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,Color> dictionary = new Dictionary<ulong,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(), ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<ulong,char> ReadUInt64CharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,char> dictionary = new Dictionary<ulong,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<ulong,byte> ReadUInt64ByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,byte> dictionary = new Dictionary<ulong,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<ulong,bool> ReadUInt64BooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,bool> dictionary = new Dictionary<ulong,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<uint,string> ReadUInt32StringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,string> dictionary = new Dictionary<uint,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<uint,short> ReadUInt32Int16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,short> dictionary = new Dictionary<uint,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<uint,sbyte> ReadUInt32SByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,sbyte> dictionary = new Dictionary<uint,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<uint,Rect> ReadUInt32RectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,Rect> dictionary = new Dictionary<uint,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<uint,Quaternion> ReadUInt32QuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,Quaternion> dictionary = new Dictionary<uint,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<uint,long> ReadUInt32Int64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,long> dictionary = new Dictionary<uint,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<uint,int> ReadUInt32Int32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,int> dictionary = new Dictionary<uint,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<uint,float> ReadUInt32SingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,float> dictionary = new Dictionary<uint,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<uint,double> ReadUInt32DoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,double> dictionary = new Dictionary<uint,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<uint,decimal> ReadUInt32DecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,decimal> dictionary = new Dictionary<uint,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<uint,DateTime> ReadUInt32DateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,DateTime> dictionary = new Dictionary<uint,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<uint,Color32> ReadUInt32Color32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,Color32> dictionary = new Dictionary<uint,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<uint,Color> ReadUInt32ColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,Color> dictionary = new Dictionary<uint,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(), ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<uint,char> ReadUInt32CharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,char> dictionary = new Dictionary<uint,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<uint,byte> ReadUInt32ByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,byte> dictionary = new Dictionary<uint,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<uint,bool> ReadUInt32BooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,bool> dictionary = new Dictionary<uint,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<string,short> ReadStringInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,short> dictionary = new Dictionary<string,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<string,sbyte> ReadStringSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,sbyte> dictionary = new Dictionary<string,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<string,Rect> ReadStringRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,Rect> dictionary = new Dictionary<string,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<string,Quaternion> ReadStringQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,Quaternion> dictionary = new Dictionary<string,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<string,long> ReadStringInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,long> dictionary = new Dictionary<string,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadInt64());
			}
			return dictionary;
		}
		public static Dictionary<string,int> ReadStringInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,int> dictionary = new Dictionary<string,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadInt32());
			}
			return dictionary;
		}
		public static Dictionary<string,float> ReadStringSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,float> dictionary = new Dictionary<string,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<string,double> ReadStringDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,double> dictionary = new Dictionary<string,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<string,decimal> ReadStringDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,decimal> dictionary = new Dictionary<string,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<string,DateTime> ReadStringDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,DateTime> dictionary = new Dictionary<string,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<string,Color32> ReadStringColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,Color32> dictionary = new Dictionary<string,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<string,Color> ReadStringColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,Color> dictionary = new Dictionary<string,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<string,char> ReadStringCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,char> dictionary = new Dictionary<string,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<string,byte> ReadStringByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,byte> dictionary = new Dictionary<string,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<string,bool> ReadStringBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,bool> dictionary = new Dictionary<string,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<short,sbyte> ReadInt16SByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,sbyte> dictionary = new Dictionary<short,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<short,Rect> ReadInt16RectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,Rect> dictionary = new Dictionary<short,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<short,Quaternion> ReadInt16QuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,Quaternion> dictionary = new Dictionary<short,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<short,long> ReadInt16Int64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,long> dictionary = new Dictionary<short,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadInt64());
			}
			return dictionary;
		}
		public static Dictionary<short,int> ReadInt16Int32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,int> dictionary = new Dictionary<short,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadInt32());
			}
			return dictionary;
		}
		public static Dictionary<short,float> ReadInt16SingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,float> dictionary = new Dictionary<short,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<short,double> ReadInt16DoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,double> dictionary = new Dictionary<short,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<short,decimal> ReadInt16DecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,decimal> dictionary = new Dictionary<short,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<short,DateTime> ReadInt16DateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,DateTime> dictionary = new Dictionary<short,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<short,Color32> ReadInt16Color32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,Color32> dictionary = new Dictionary<short,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<short,Color> ReadInt16ColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,Color> dictionary = new Dictionary<short,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<short,char> ReadInt16CharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,char> dictionary = new Dictionary<short,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<short,byte> ReadInt16ByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,byte> dictionary = new Dictionary<short,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<short,bool> ReadInt16BooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,bool> dictionary = new Dictionary<short,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,Rect> ReadSByteRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,Rect> dictionary = new Dictionary<sbyte,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,Quaternion> ReadSByteQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,Quaternion> dictionary = new Dictionary<sbyte,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,long> ReadSByteInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,long> dictionary = new Dictionary<sbyte,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadInt64());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,int> ReadSByteInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,int> dictionary = new Dictionary<sbyte,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadInt32());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,float> ReadSByteSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,float> dictionary = new Dictionary<sbyte,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,double> ReadSByteDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,double> dictionary = new Dictionary<sbyte,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,decimal> ReadSByteDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,decimal> dictionary = new Dictionary<sbyte,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,DateTime> ReadSByteDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,DateTime> dictionary = new Dictionary<sbyte,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,Color32> ReadSByteColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,Color32> dictionary = new Dictionary<sbyte,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,Color> ReadSByteColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,Color> dictionary = new Dictionary<sbyte,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,char> ReadSByteCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,char> dictionary = new Dictionary<sbyte,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,byte> ReadSByteByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,byte> dictionary = new Dictionary<sbyte,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<sbyte,bool> ReadSByteBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,bool> dictionary = new Dictionary<sbyte,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<Rect,Quaternion> ReadRectQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,Quaternion> dictionary = new Dictionary<Rect,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Rect,long> ReadRectInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,long> dictionary = new Dictionary<Rect,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<Rect,int> ReadRectInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,int> dictionary = new Dictionary<Rect,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<Rect,float> ReadRectSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,float> dictionary = new Dictionary<Rect,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<Rect,double> ReadRectDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,double> dictionary = new Dictionary<Rect,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<Rect,decimal> ReadRectDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,decimal> dictionary = new Dictionary<Rect,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<Rect,DateTime> ReadRectDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,DateTime> dictionary = new Dictionary<Rect,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Rect,Color32> ReadRectColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,Color32> dictionary = new Dictionary<Rect,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Rect,Color> ReadRectColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,Color> dictionary = new Dictionary<Rect,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Rect,char> ReadRectCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,char> dictionary = new Dictionary<Rect,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<Rect,byte> ReadRectByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,byte> dictionary = new Dictionary<Rect,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<Rect,bool> ReadRectBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,bool> dictionary = new Dictionary<Rect,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,long> ReadQuaternionInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,long> dictionary = new Dictionary<Quaternion,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,int> ReadQuaternionInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,int> dictionary = new Dictionary<Quaternion,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,float> ReadQuaternionSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,float> dictionary = new Dictionary<Quaternion,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,double> ReadQuaternionDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,double> dictionary = new Dictionary<Quaternion,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,decimal> ReadQuaternionDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,decimal> dictionary = new Dictionary<Quaternion,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,DateTime> ReadQuaternionDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,DateTime> dictionary = new Dictionary<Quaternion,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Color32> ReadQuaternionColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,Color32> dictionary = new Dictionary<Quaternion,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Color> ReadQuaternionColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,Color> dictionary = new Dictionary<Quaternion,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,char> ReadQuaternionCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,char> dictionary = new Dictionary<Quaternion,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,byte> ReadQuaternionByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,byte> dictionary = new Dictionary<Quaternion,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,bool> ReadQuaternionBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,bool> dictionary = new Dictionary<Quaternion,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<long,int> ReadInt64Int32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,int> dictionary = new Dictionary<long,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<long,float> ReadInt64SingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,float> dictionary = new Dictionary<long,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<long,double> ReadInt64DoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,double> dictionary = new Dictionary<long,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<long,decimal> ReadInt64DecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,decimal> dictionary = new Dictionary<long,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<long,DateTime> ReadInt64DateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,DateTime> dictionary = new Dictionary<long,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<long,Color32> ReadInt64Color32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,Color32> dictionary = new Dictionary<long,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<long,Color> ReadInt64ColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,Color> dictionary = new Dictionary<long,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(), ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<long,char> ReadInt64CharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,char> dictionary = new Dictionary<long,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<long,byte> ReadInt64ByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,byte> dictionary = new Dictionary<long,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<long,bool> ReadInt64BooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,bool> dictionary = new Dictionary<long,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<int,float> ReadInt32SingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,float> dictionary = new Dictionary<int,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<int,double> ReadInt32DoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,double> dictionary = new Dictionary<int,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<int,decimal> ReadInt32DecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,decimal> dictionary = new Dictionary<int,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<int,DateTime> ReadInt32DateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,DateTime> dictionary = new Dictionary<int,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<int,Color32> ReadInt32Color32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,Color32> dictionary = new Dictionary<int,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<int,Color> ReadInt32ColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,Color> dictionary = new Dictionary<int,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(), ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<int,char> ReadInt32CharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,char> dictionary = new Dictionary<int,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<int,byte> ReadInt32ByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,byte> dictionary = new Dictionary<int,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<int,bool> ReadInt32BooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,bool> dictionary = new Dictionary<int,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<float,double> ReadSingleDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,double> dictionary = new Dictionary<float,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<float,decimal> ReadSingleDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,decimal> dictionary = new Dictionary<float,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<float,DateTime> ReadSingleDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,DateTime> dictionary = new Dictionary<float,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<float,Color32> ReadSingleColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,Color32> dictionary = new Dictionary<float,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<float,Color> ReadSingleColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,Color> dictionary = new Dictionary<float,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<float,char> ReadSingleCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,char> dictionary = new Dictionary<float,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<float,byte> ReadSingleByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,byte> dictionary = new Dictionary<float,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<float,bool> ReadSingleBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,bool> dictionary = new Dictionary<float,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<double,decimal> ReadDoubleDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,decimal> dictionary = new Dictionary<double,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<double,DateTime> ReadDoubleDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,DateTime> dictionary = new Dictionary<double,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<double,Color32> ReadDoubleColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,Color32> dictionary = new Dictionary<double,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<double,Color> ReadDoubleColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,Color> dictionary = new Dictionary<double,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<double,char> ReadDoubleCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,char> dictionary = new Dictionary<double,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<double,byte> ReadDoubleByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,byte> dictionary = new Dictionary<double,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<double,bool> ReadDoubleBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,bool> dictionary = new Dictionary<double,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<decimal,DateTime> ReadDecimalDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,DateTime> dictionary = new Dictionary<decimal,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Color32> ReadDecimalColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,Color32> dictionary = new Dictionary<decimal,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<decimal,Color> ReadDecimalColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,Color> dictionary = new Dictionary<decimal,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<decimal,char> ReadDecimalCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,char> dictionary = new Dictionary<decimal,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<decimal,byte> ReadDecimalByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,byte> dictionary = new Dictionary<decimal,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<decimal,bool> ReadDecimalBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,bool> dictionary = new Dictionary<decimal,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Color32> ReadDateTimeColor32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,Color32> dictionary = new Dictionary<DateTime,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,Color> ReadDateTimeColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,Color> dictionary = new Dictionary<DateTime,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,char> ReadDateTimeCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,char> dictionary = new Dictionary<DateTime,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,byte> ReadDateTimeByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,byte> dictionary = new Dictionary<DateTime,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<DateTime,bool> ReadDateTimeBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,bool> dictionary = new Dictionary<DateTime,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<Color32,Color> ReadColor32ColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,Color> dictionary = new Dictionary<Color32,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color32,char> ReadColor32CharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,char> dictionary = new Dictionary<Color32,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<Color32,byte> ReadColor32ByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,byte> dictionary = new Dictionary<Color32,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<Color32,bool> ReadColor32BooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,bool> dictionary = new Dictionary<Color32,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<Color,char> ReadColorCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,char> dictionary = new Dictionary<Color,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<Color,byte> ReadColorByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,byte> dictionary = new Dictionary<Color,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<Color,bool> ReadColorBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,bool> dictionary = new Dictionary<Color,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<char,byte> ReadCharByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,byte> dictionary = new Dictionary<char,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<char,bool> ReadCharBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,bool> dictionary = new Dictionary<char,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<byte,bool> ReadByteBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,bool> dictionary = new Dictionary<byte,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<bool,bool> ReadBooleanBooleanDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<bool,bool> dictionary = new Dictionary<bool,bool>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadBoolean(),binaryReader.ReadBoolean());
			}
			return dictionary;
		}
		public static Dictionary<byte,byte> ReadByteByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<byte,byte> dictionary = new Dictionary<byte,byte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadByte(),binaryReader.ReadByte());
			}
			return dictionary;
		}
		public static Dictionary<char,char> ReadCharCharDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<char,char> dictionary = new Dictionary<char,char>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadChar(),binaryReader.ReadChar());
			}
			return dictionary;
		}
		public static Dictionary<Color,Color> ReadColorColorDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color,Color> dictionary = new Dictionary<Color,Color>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor(binaryReader),ReadColor(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Color32,Color32> ReadColor32Color32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Color32,Color32> dictionary = new Dictionary<Color32,Color32>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadColor32(binaryReader),ReadColor32(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<DateTime,DateTime> ReadDateTimeDateTimeDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<DateTime,DateTime> dictionary = new Dictionary<DateTime,DateTime>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadDateTime(binaryReader),ReadDateTime(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<decimal,decimal> ReadDecimalDecimalDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<decimal,decimal> dictionary = new Dictionary<decimal,decimal>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDecimal(),binaryReader.ReadDecimal());
			}
			return dictionary;
		}
		public static Dictionary<double,double> ReadDoubleDoubleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<double,double> dictionary = new Dictionary<double,double>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadDouble(),binaryReader.ReadDouble());
			}
			return dictionary;
		}
		public static Dictionary<float,float> ReadSingleSingleDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<float,float> dictionary = new Dictionary<float,float>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSingle(),binaryReader.ReadSingle());
			}
			return dictionary;
		}
		public static Dictionary<int,int> ReadInt32Int32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<int,int> dictionary = new Dictionary<int,int>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt32(),binaryReader.Read7BitEncodedInt32());
			}
			return dictionary;
		}
		public static Dictionary<long,long> ReadInt64Int64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<long,long> dictionary = new Dictionary<long,long>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedInt64(),binaryReader.Read7BitEncodedInt64());
			}
			return dictionary;
		}
		public static Dictionary<Quaternion,Quaternion> ReadQuaternionQuaternionDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Quaternion,Quaternion> dictionary = new Dictionary<Quaternion,Quaternion>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadQuaternion(binaryReader),ReadQuaternion(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Rect,Rect> ReadRectRectDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Rect,Rect> dictionary = new Dictionary<Rect,Rect>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadRect(binaryReader),ReadRect(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<sbyte,sbyte> ReadSByteSByteDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<sbyte,sbyte> dictionary = new Dictionary<sbyte,sbyte>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadSByte(),binaryReader.ReadSByte());
			}
			return dictionary;
		}
		public static Dictionary<short,short> ReadInt16Int16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<short,short> dictionary = new Dictionary<short,short>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadInt16(),binaryReader.ReadInt16());
			}
			return dictionary;
		}
		public static Dictionary<string,string> ReadStringStringDictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<string,string> dictionary = new Dictionary<string,string>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadString(),binaryReader.ReadString());
			}
			return dictionary;
		}
		public static Dictionary<uint,uint> ReadUInt32UInt32Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<uint,uint> dictionary = new Dictionary<uint,uint>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt32(),binaryReader.Read7BitEncodedUInt32());
			}
			return dictionary;
		}
		public static Dictionary<ulong,ulong> ReadUInt64UInt64Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ulong,ulong> dictionary = new Dictionary<ulong,ulong>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.Read7BitEncodedUInt64(),binaryReader.Read7BitEncodedUInt64());
			}
			return dictionary;
		}
		public static Dictionary<ushort,ushort> ReadUInt16UInt16Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<ushort,ushort> dictionary = new Dictionary<ushort,ushort>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(binaryReader.ReadUInt16(),binaryReader.ReadUInt16());
			}
			return dictionary;
		}
		public static Dictionary<Vector2,Vector2> ReadVector2Vector2Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector2,Vector2> dictionary = new Dictionary<Vector2,Vector2>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector2(binaryReader),ReadVector2(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector3,Vector3> ReadVector3Vector3Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector3,Vector3> dictionary = new Dictionary<Vector3,Vector3>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector3(binaryReader),ReadVector3(binaryReader));
			}
			return dictionary;
		}
		public static Dictionary<Vector4,Vector4> ReadVector4Vector4Dictionary(this BinaryReader binaryReader)
		{
			int count = binaryReader.Read7BitEncodedInt32();
			Dictionary<Vector4,Vector4> dictionary = new Dictionary<Vector4,Vector4>(count);
			for (int i = 0; i < count; i++)
			{
				dictionary.Add(ReadVector4(binaryReader),ReadVector4(binaryReader));
			}
			return dictionary;
		}
	}
}
