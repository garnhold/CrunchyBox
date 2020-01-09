using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    using Salt;
    
    public class ILCastInfo_ConversionMethod : ILCastInfo
    {
        private MethodInfo method;

        public ILCastInfo_ConversionMethod(Type s, Type d, MethodInfo m) : base(s, d)
        {
            method = m;
        }

        public override void EmitCast(ILCanvas canvas, ILValue value)
        {
            value.RenderIL_Load(canvas);

            canvas.Emit_Call(method);
        }
    }
}