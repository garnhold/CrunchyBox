using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILInitializeLocal : ILStatement
    {
        private ILLocal local;

        public ILInitializeLocal(ILLocal l)
        {
            local = l;
        }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            local.RenderIL_Initialize(canvas);
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            local.RenderText_Declaration(canvas);
        }
    }
}