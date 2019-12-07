using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract class ILCanvasLocal
    {
        public abstract Type GetLocalType();
        public abstract int GetLocalIndex();
    }
}