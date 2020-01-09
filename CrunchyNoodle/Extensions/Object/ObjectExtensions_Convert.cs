using System;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class ObjectExtensions_Convert
    {
        static public bool ConvertEX(this object item, Type type, out object output, bool allow_null_object = false)
        {
            if (item.CanConvert(type, allow_null_object))
            {
                output = item;
                return true;
            }

            if (item != null)
            {
                BasicMethodInvoker invoker = item.GetType().GetConversionInvoker(type);
                if (invoker != null)
                {
                    output = invoker(null, new object[] { item });
                    return true;
                }
            }

            output = type.GetDefaultValue();
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