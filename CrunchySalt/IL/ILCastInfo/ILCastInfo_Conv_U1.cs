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
    
    public class ILCastInfo_Conv_U1 : ILCastInfo
    {
        public ILCastInfo_Conv_U1(Type s) : base(s, typeof(byte)) { }

        public override void EmitCast(ILCanvas canvas, ILValue value)
        {
            value.RenderIL_Load(canvas);

            canvas.Emit_Conv_U1();
        }
    }
}