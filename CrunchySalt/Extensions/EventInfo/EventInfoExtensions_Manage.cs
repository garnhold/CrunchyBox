using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class EventInfoExtensions_Manage
    {
        static public T CreateDynamicEventRegisterDelegate<T>(this EventInfo item)
        {
            return item.GetAddMethod(true).CreateDynamicMethodCallerDelegate<T>();
        }

        static public T CreateDynamicEventDeregisterDelegate<T>(this EventInfo item)
        {
            return item.GetRemoveMethod(true).CreateDynamicMethodCallerDelegate<T>();
        }
    }
}