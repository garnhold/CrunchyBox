using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILCalculate : ILStatement
    {
        private ILValue value;

        public ILCalculate(ILValue v)
        {
            value = v;
        }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            value.RenderIL_Load(canvas);

            if (value.GetValueType().IsVoidType() == false)
                canvas.Emit_Pop();
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            value.RenderText_Value(canvas);
            canvas.AppendToLine(";");
        }
    }
}