using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class TyonSettingsExtensions_Convience
    {
        static public string Serialize(this TyonSettings item, object obj)
        {
            return item.CreateContext().Serialize(obj);
        }
        static public string SerializeValue(this TyonSettings item, Type type, object value)
        {
            return item.CreateContext().SerializeValue(type, value);
        }

        static public object Deserialize(this TyonSettings item, string text, TyonHydrationMode mode)
        {
            return item.CreateContext().Deserialize(text, mode);
        }
        static public T Deserialize<T>(this TyonSettings item, string text, TyonHydrationMode mode)
        {
            return item.Deserialize(text, mode).Convert<T>();
        }

        static public object DeserializeValue(this TyonSettings item, Type type, string text, TyonHydrationMode mode)
        {
            return item.CreateContext().DeserializeValue(type, text, mode);
        }
        static public T DeserializeValue<T>(this TyonSettings item, Type type, string text, TyonHydrationMode mode)
        {
            return item.DeserializeValue(type, text, mode).Convert<T>();
        }
        static public T DeserializeValue<T>(this TyonSettings item, string text, TyonHydrationMode mode)
        {
            return item.DeserializeValue<T>(typeof(T), text, mode);
        }

        static public void DeserializeInto(this TyonSettings item, object obj, string text, TyonHydrationMode mode)
        {
            item.CreateContext().DeserializeInto(obj, text, mode);
        }
    }
}
