using System;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_Convert
    {
        static public bool ConvertEX(this object item, Type type, out object output, bool allow_null_object = false)
        {
            if (item != null)
            {
                if (item.CanConvert(type))
                {
                    output = item;
                    return true;
                }

                BasicMethodInvoker invoker = item.GetType().GetConversionInvoker(type);
                if (invoker != null)
                {
                    output = invoker(null, new object[] { item });
                    return true;
                }
            }

            output = type.GetDefaultValue();

            if (allow_null_object)
            {
                if(item == null)
                    return true;
            }

            return false;
        }
        static public object ConvertEX(this object item, Type type)
        {
            object output;

            item.ConvertEX(type, out output);
            return output;
        }
    }
}