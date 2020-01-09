using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILNothing : ILStatement
    {
        static public readonly ILNothing INSTANCE = new ILNothing();

        private ILNothing() { }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
        }
    }
}