using UnityEngine;

namespace DE
{
    public static partial class DataTableExtension
    {
        internal static readonly char[] DataSplitSeparators = {'\t'};
        internal static readonly char[] DataTrimSeparators = {'\"'};

        public static Color32 ParseColor32(string value)
        {
            var splitValue = value.Split(',');
            return new Color32(byte.Parse(splitValue[0]), byte.Parse(splitValue[1]), byte.Parse(splitValue[2]),
                byte.Parse(splitValue[3]));
        }

        public static Color ParseColor(string value)
        {
            var splitValue = value.Split(',');
            return new Color(float.Parse(splitValue[0]), float.Parse(splitValue[1]), float.Parse(splitValue[2]),
                float.Parse(splitValue[3]));
        }

        public static Quaternion ParseQuaternion(string value)
        {
            var splitValue = value.Split(',');
            return new Quaternion(float.Parse(splitValue[0]), float.Parse(splitValue[1]), float.Parse(splitValue[2]),
                float.Parse(splitValue[3]));
        }

        public static Rect ParseRect(string value)
        {
            var splitValue = value.Split(',');
            return new Rect(float.Parse(splitValue[0]), float.Parse(splitValue[1]), float.Parse(splitValue[2]),
                float.Parse(splitValue[3]));
        }

        public static Vector2 ParseVector2(string value)
        {
            var splitValue = value.Split(',');
            return new Vector2(float.Parse(splitValue[0]), float.Parse(splitValue[1]));
        }

        public static Vector3 ParseVector3(string value)
        {
            var splitValue = value.Split(',');
            return new Vector3(float.Parse(splitValue[0]), float.Parse(splitValue[1]), float.Parse(splitValue[2]));
        }

        public static Vector4 ParseVector4(string value)
        {
            var splitValue = value.Split(',');
            return new Vector4(float.Parse(splitValue[0]), float.Parse(splitValue[1]), float.Parse(splitValue[2]),
                float.Parse(splitValue[3]));
        }
    }
}