using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILBinaryOperatorInvokation : ILValue
    {
        private BinaryOperatorInfoEX operator_info;

        private ILValue left;
        private ILValue right;

        public ILBinaryOperatorInvokation(BinaryOperatorInfoEX o, ILValue l, ILValue r)
        {
            operator_info = o;

            left = l;
            right = r;
        }

        public ILBinaryOperatorInvokation(BinaryOperatorType o, ILValue l, ILValue r) : this(l.GetValueType().GetBinaryOperator(r.GetValueType(), o), l, r) { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            operator_info.RenderIL_Operate(canvas, left, right);
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            throw new InvalidOperationException(GetType() + " doesn't support storing.");
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("(");
                left.RenderText_Value(canvas);

                canvas.AppendToLine(" ");
                canvas.AppendToLine(operator_info.GetOperatorType().GetSymbol());
                canvas.AppendToLine(" ");

                right.RenderText_Value(canvas);
            canvas.AppendToLine(")");
        }

        public override Type GetValueType()
        {
            return operator_info.GetOutputType();
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