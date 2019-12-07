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
    
    public class ILIfValue : ILValue
    {
        private ILValue condition;

        private ILValue true_value;
        private ILValue false_value;

        public ILIfValue(ILValue c, ILValue t, ILValue f)
        {
            condition = c;

            true_value = t;
            false_value = f;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            new ILIf(
                condition,
                new ILLoad(true_value),
                new ILLoad(false_value)
            ).RenderIL_Execute(canvas);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("(");
            condition.RenderText_Value(canvas);
            canvas.AppendToLine(")");

            canvas.AppendToLine(" ? ");

            true_value.RenderText_Value(canvas);
            canvas.AppendToLine(" : ");
            false_value.RenderText_Value(canvas);
        }

        public override Type GetValueType()
        {
            return true_value.GetValueType().GetCommonAncestor(false_value.GetValueType());
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