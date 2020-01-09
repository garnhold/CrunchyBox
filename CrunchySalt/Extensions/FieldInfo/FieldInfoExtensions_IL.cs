using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class FieldInfoExtensions_IL
    {
        static public ILField GetStaticILField(this FieldInfo item)
        {
            return new ILField(null, item);
        }
    }
}