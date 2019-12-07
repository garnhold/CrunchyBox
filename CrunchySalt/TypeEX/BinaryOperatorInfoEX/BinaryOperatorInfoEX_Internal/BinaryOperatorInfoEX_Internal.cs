using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract class BinaryOperatorInfoEX_Internal : BinaryOperatorInfoEX
    {
        private Type input_type;

        protected void LoadValues(ILCanvas canvas, ILValue left, ILValue right)
        {
            left.GetILImplicitCast(input_type).RenderIL_Load(canvas);
            right.GetILImplicitCast(input_type).RenderIL_Load(canvas);
        }

        public BinaryOperatorInfoEX_Internal(BinaryOperatorType t, Type i, Type l, Type r, Type o) : base(t, l, r, o) 
        {
            input_type = i;
        }
    }
}