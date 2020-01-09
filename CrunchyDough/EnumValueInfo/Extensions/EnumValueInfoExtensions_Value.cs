using System;

namespace Crunchy.Dough
{
    static public class EnumValueInfoExtensions_Value
    {
        static public long GetLongValue(this EnumValueInfo item)
        {
            return item.GetValue().GetLongValue();
        }

        static public T GetValue<T>(this EnumValueInfo item)
        {
            return item.GetValue().Convert<T>();
        }
    }
}