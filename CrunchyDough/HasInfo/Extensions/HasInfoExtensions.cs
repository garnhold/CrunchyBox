using System;

namespace CrunchyDough
{
    static public class HasInfoExtensions
    {
        static public string GetInfoValue(this HasInfo item, string name)
        {
            return item.GetInfoSettings().Lookup(name);
        }

        static public string GetBoolInfoValue(this HasInfo item, string name, string if_true, string if_false)
        {
            return item.GetInfoSettings().ConvertBool(name, if_true, if_false);
        }

        static public bool IsInfoValueDefault(this HasInfo item, string name)
        {
            return item.GetInfoSettings().IsAsBacked(name);
        }

        static public bool IsInfoValueTrue(this HasInfo item, string name)
        {
            return item.GetInfoSettings().IsTrue(name);
        }

        static public bool IsInfoValueFalse(this HasInfo item, string name)
        {
            return item.GetInfoSettings().IsFalse(name);
        }

        static public bool IsInfoValue(this HasInfo item, string name, string value)
        {
            return item.GetInfoSettings().Is(name, value);
        }

        static public bool IsInfoValueNot(this HasInfo item, string name, string value)
        {
            return item.GetInfoSettings().IsNot(name, value);
        }

        static public T ConvertInfoValue<T>(this HasInfo item, string name, Operation<T, string> operation)
        {
            return item.GetInfoSettings().Convert(name, operation);
        }

        static public T ConvertInfoValue<T>(this HasInfo item, string name, Operation<T> default_operation, Operation<T, string> operation)
        {
            return item.GetInfoSettings().Convert(name, default_operation, operation);
        }
    }
}