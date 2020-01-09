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
    
    public class ILCastInfo_Conv_R8 : ILCastInfo
    {
        public ILCastInfo_Conv_R8(Type s) : base(s, typeof(double)) { }

        public override void EmitCast(ILCanvas canvas, ILValue value)
        {
            value.RenderIL_Load(canvas);

            canvas.Emit_Conv_R8();
        }
    }
}