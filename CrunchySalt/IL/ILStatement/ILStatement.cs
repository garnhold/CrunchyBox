using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract class ILStatement
    {
        public abstract void RenderIL_Execute(ILCanvas canvas);

        public abstract void RenderText_Statement(ILTextCanvas canvas);

        public override string ToString()
        {
            ILTextCanvas canvas = new ILTextCanvas(null);

            RenderText_Statement(canvas);
            return canvas.ToString();
        }
    }
}