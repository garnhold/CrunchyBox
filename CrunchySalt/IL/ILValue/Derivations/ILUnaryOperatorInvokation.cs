using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILUnaryOperatorInvokation : ILValue
    {
        private UnaryOperatorInfoEX operator_info;

        private ILValue input;

        public ILUnaryOperatorInvokation(UnaryOperatorInfoEX o, ILValue i)
        {
            operator_info = o;

            input = i;
        }

        public ILUnaryOperatorInvokation(UnaryOperatorType o, ILValue i) : this(i.GetValueType().GetUnaryOperator(o), i) { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            operator_info.RenderIL_Operate(canvas, input);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("(");
                canvas.AppendToLine(operator_info.GetOperatorType().GetSymbol());
                input.RenderText_ValueEX(canvas);
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
    }
}