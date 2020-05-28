using System;
using UnityGameFramework.Runtime;

namespace DE
{
    public static class DataTableExtensionHelper
    {
        /// <summary>返回一个指定类型的对象，该对象的值等效于指定的对象。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <typeparam  name="T">要返回的对象的类型。</typeparam>
        /// <returns>
        ///   一个对象，其类型为 <typeparam name="T" />，并且其值等效于 <paramref name="value" />。
        /// 
        ///   - 或 -
        /// 
        ///   如果 <see langword="Nothing" /> 为 <paramref name="value" />，并且 <see langword="null" /> 不是值类型，则为空引用（在 Visual Basic 中为 <typeparam name="T" />）。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// 
        ///   - 或 -
        /// 
        ///   <paramref name="value" /> 是 <see langword="null" /> 并且 <typeparam name="T" /> 是一个值类型。
        /// 
        ///   - 或 -
        /// 
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不是 <typeparam name="T" /> 可识别的格式。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示不在 <typeparam name="T" /> 的范围内的数字。
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <typeparam name="T" /> 为 <see langword="null" />。
        /// </exception>
        public static T Parse<T>(string value)
        {
            T ret = default;
            try
            {
                ret = (T) Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                Log.Error($"{value} 不是{typeof(T)}类型");
            }
            return ret;
        }
    }
}