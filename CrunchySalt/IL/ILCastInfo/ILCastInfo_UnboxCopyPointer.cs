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
    
    public class ILCastInfo_UnboxCopyPointer : ILCastInfo
    {
        public ILCastInfo_UnboxCopyPointer(Type s, Type d) : base(s, d) { }

        public override void EmitCast(ILCanvas canvas, ILValue value)
        {
            value.RenderIL_Load(canvas);

            canvas.Emit_Unbox_Any(GetDestinationType().GetElementType());
            canvas.MakeAddressImmediate(GetDestinationType().GetElementType());
        }
    }
}