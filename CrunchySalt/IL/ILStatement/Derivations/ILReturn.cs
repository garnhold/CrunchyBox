using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILReturn : ILStatement
    {
        private ILValue value;

        public ILReturn(ILValue v)
        {
            value = v;
        }

        public ILReturn() : this(null) { }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            if (value != null)
            {
                value.GetILImplicitCast(canvas.GetMethod().GetReturnType())
                    .RenderIL_Load(canvas);
            }

            canvas.Emit_Ret();
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            if (value != null)
            {
                canvas.AppendToLine("return ");
                value.RenderText_Value(canvas);
                canvas.AppendToLine(";");
            }
            else
            {
                canvas.AppendToLine("return;");
            }
        }

        public ILValue GetValue()
        {
            return value;
        }
    }
}