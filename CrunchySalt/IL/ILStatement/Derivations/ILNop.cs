using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILNop : ILStatement
    {
        static public readonly ILNop INSTANCE = new ILNop();

        private ILNop() { }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            canvas.Emit_Nop();
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            canvas.AppendToLine("nop;");
        }
    }
}