using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILCanvasLabel_ILTextCanvas : ILCanvasLabel
    {
        private int id;
        private ILTextCanvas canvas;

        static private int NEXT_LABEL_ID = 1;

        public ILCanvasLabel_ILTextCanvas(ILTextCanvas c)
        {
            id = NEXT_LABEL_ID++;
            canvas = c;
        }

        public override void Emit_Label()
        {
            canvas.AppendInstruction("*label", id.ToString());
        }

        public override void Emit_Br()
        {
            canvas.AppendInstruction("Br", id.ToString());
        }

        public override void Emit_Brtrue()
        {
            canvas.AppendInstruction("Brtrue", id.ToString());
        }

        public override void Emit_Brfalse()
        {
            canvas.AppendInstruction("Brfalse", id.ToString());
        }
    }
}