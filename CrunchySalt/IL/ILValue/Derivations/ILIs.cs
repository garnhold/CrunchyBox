using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchySalt
{
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
            canvas.Emit_Ceq();
            canvas.Emit_Not();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            throw new InvalidOperationException(GetType() + " doesn't support storing.");
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("(");
                value.RenderText_Value(canvas);

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

        public override bool CanStore()
        {
            return false;
        }
    }
}