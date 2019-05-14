using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class EnumExtensions_Index
    {
        static public int GetIndex(this Enum item)
        {
            int index;

            item.GetEnumInfo().TryConvertValueToIndex(item, out index);
            return index;
        }
    }
}