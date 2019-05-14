using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILLabel : ILStatement
    {
        private string name;
        private ILCanvasLabel label;

        private ILCanvasLabel FetchLabel(ILCanvas canvas)
        {
            if (label == null)
                label = canvas.CreateLabel();

            return label;
        }

        public ILLabel(string n)
        {
            name = n.StyleAsVariableName();
        }

        public ILLabel() : this(null) { }

        public ILGoTo CreateGoTo()
        {
            return new ILGoTo(this);
        }

        public void RenderIL_Break(ILCanvas canvas)
        {
            FetchLabel(canvas).Emit_Br();
        }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            FetchLabel(canvas).Emit_Label();
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            canvas.AppendToLine("label ");
            RenderText_Label(canvas);
            canvas.AppendToLine(";");
        }

        public void RenderText_Label(ILTextCanvas canvas)
        {
            canvas.AppendToLine(name);
        }
    }
}