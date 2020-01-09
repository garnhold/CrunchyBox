using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILAssign : ILStatement
    {
        private ILValue destination;
        private ILValue source;

        public ILAssign(ILValue d, ILValue s)
        {
            destination = d;
            source = s;
        }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            destination.RenderIL_Store(canvas, source);
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            destination.RenderText_Value(canvas);
            canvas.AppendToLine(" = ");
            source.RenderText_Value(canvas);
            canvas.AppendToLine(";");
        }
    }
}