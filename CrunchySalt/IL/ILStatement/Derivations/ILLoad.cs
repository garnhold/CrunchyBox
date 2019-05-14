using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILLoad : ILStatement
    {
        private ILValue value;

        public ILLoad(ILValue v)
        {
            value = v;
        }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            value.RenderIL_Load(canvas);
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            canvas.AppendToLine("push ");
            value.RenderText_Value(canvas);
            canvas.AppendToLine(";");
        }
    }
}