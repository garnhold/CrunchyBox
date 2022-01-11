using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ObjectExtensions_IL
    {
        static public ILValue CreateILLiteral(this object item)
        {
            return ILLiteral.New(item);
        }
    }
}