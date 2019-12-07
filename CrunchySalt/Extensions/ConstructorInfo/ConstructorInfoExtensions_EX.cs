using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ConstructorInfoExtensions_EX
    {
        static public ConstructorInfoEX GetConstructorInfoEX(this ConstructorInfo item)
        {
            return ConstructorInfoEX.GetConstructorInfoEX(item);
        }

        static public BasicConstructorInvoker GetBasicConstructorInvoker(this ConstructorInfo item)
        {
            return item.GetConstructorInfoEX().GetBasicConstructorInvoker();
        }

        static public BasicMethodInvoker GetBasicMethodInvoker(this ConstructorInfo item)
        {
            return item.GetConstructorInfoEX().GetBasicMethodInvoker();
        }

        static public ConstructorInvoker<T> GetConstructorInvoker<T>(this ConstructorInfo item)
        {
            return item.GetConstructorInfoEX().GetConstructorInvoker<T>();
        }
    }
}