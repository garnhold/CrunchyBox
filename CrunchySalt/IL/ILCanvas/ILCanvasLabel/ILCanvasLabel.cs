using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public abstract class ILCanvasLabel
    {
        public abstract void Emit_Label();

        public abstract void Emit_Br();
        public abstract void Emit_Brtrue();
        public abstract void Emit_Brfalse();
    }
}