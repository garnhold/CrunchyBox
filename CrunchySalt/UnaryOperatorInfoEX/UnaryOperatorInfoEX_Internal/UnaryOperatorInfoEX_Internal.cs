using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    public abstract class UnaryOperatorInfoEX_Internal : UnaryOperatorInfoEX
    {
        private Type input_type;

        protected void LoadValue(ILCanvas canvas, ILValue input)
        {
            input.GetILImplicitCast(input_type).RenderIL_Load(canvas);
        }

        public UnaryOperatorInfoEX_Internal(UnaryOperatorType t, Type i, Type o) : base(t, i, o) 
        {
            input_type = i;
        }
    }
}