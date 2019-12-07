using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILNull : ILLiteral
    {
        static public readonly ILNull INSTANCE = new ILNull();

        private ILNull() { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            canvas.Emit_Ldnull();
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("null");
        }

        public override Type GetValueType()
        {
            return typeof(object);
        }

        public override object GetLiteralValue()
        {
            return null;
        }
    }
}