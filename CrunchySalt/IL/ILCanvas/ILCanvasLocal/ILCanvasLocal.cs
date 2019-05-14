using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public abstract class ILCanvasLocal
    {
        public abstract Type GetLocalType();
        public abstract int GetLocalIndex();
    }
}