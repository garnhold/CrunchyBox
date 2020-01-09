using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    using Salt;
    
    public class ILNewArray : ILValue
    {
        private Type element_type;
        private ILValue size;

        public ILNewArray(Type e, ILValue s)
        {
            element_type = e;
            size = s;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            size.RenderIL_Load(canvas);

            canvas.Emit_Newarr(element_type);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("new ");
            canvas.AppendToLine(element_type.Name);
            canvas.AppendToLine("[");
                size.RenderText_Value(canvas);
            canvas.AppendToLine("]");
        }

        public override Type GetValueType()
        {
            return element_type.MakeArrayType();
        }

        public override bool IsILCostTrivial()
        {
            return false;
        }

        public override bool CanLoad()
        {
            return true;
        }
    }
}