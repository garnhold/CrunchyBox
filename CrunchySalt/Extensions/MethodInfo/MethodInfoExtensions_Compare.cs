using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodInfoExtensions_Compare
    {
        static public bool IsPropSettish(this MethodInfo item)
        {
            if (item.IsPropSetCompatible() && item.Name.StartsWithAny("set", "Set"))
                return true;

            return false;
        }
        static public bool IsPropGettish(this MethodInfo item)
        {
            if (item.IsPropGetCompatible() && item.Name.StartsWithAny("get", "Get"))
                return true;

            return false;
        }

        static public bool IsPropish(this MethodInfo item)
        {
            if (item.IsPropSettish() || item.IsPropGettish())
                return true;

            return false;
        }

        static public bool IsPropSetCompatible(this MethodInfo item)
        {
            if (item.HasNoReturn() && item.GetNumberEffectiveParameters() == 1)
                return true;

            return false;
        }
        static public bool IsPropGetCompatible(this MethodInfo item)
        {
            if (item.HasReturn() && item.HasNoEffectiveParameters())
                return true;

            return false;
        }

        static public bool IsPropCompatible(this MethodInfo item)
        {
            if (item.IsPropSetCompatible() || item.IsPropGetCompatible())
                return true;

            return false;
        }

        static public bool IsPropOfTypeCompatible(this MethodInfo item, Type type)
        {
            if (item.ReturnType.CanBeTreatedAs(type) && item.HasNoEffectiveParameters())
                return true;

            if (item.HasNoReturn() && item.CanEffectiveParameterHold(0, type))
                return true;

            return false;
        }
    }
}