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
    
    public class ILCastInfo_UnboxCopy : ILCastInfo
    {
        public ILCastInfo_UnboxCopy(Type s, Type d) : base(s, d) { }

        public override void EmitCast(ILCanvas canvas, ILValue value)
        {
            value.RenderIL_Load(canvas);

            canvas.Emit_Unbox_Any(GetDestinationType());
        }
    }
}