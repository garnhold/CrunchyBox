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
    
    public class ILIs : ILValue
    {
        private Type check_type;

        private ILValue value;

        public ILIs(Type c, ILValue v)
        {
            check_type = c;

            value = v;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            value.RenderIL_Load(canvas);

            canvas.Emit_Isinst(check_type);

            canvas.Emit_Ldnull();
            canvas.Emit_Cneq();
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("(");
                value.RenderText_ValueEX(canvas);

                canvas.AppendToLine(" is ");
                canvas.AppendToLine(check_type.Name);
            canvas.AppendToLine(")");
        }

        public override Type GetValueType()
        {
            return typeof(bool);
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