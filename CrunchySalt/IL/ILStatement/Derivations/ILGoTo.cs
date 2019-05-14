using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILGoTo : ILStatement
    {
        private ILLabel label;

        public ILGoTo(ILLabel l)
        {
            label = l;
        }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            label.RenderIL_Break(canvas);
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            canvas.AppendToLine("goto ");
            label.RenderText_Label(canvas);
            canvas.AppendToLine(";");
        }
    }
}