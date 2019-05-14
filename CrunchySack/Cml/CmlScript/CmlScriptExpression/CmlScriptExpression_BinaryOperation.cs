
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:33:22 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public abstract partial class CmlScriptExpression_BinaryOperation : CmlScriptExpression
	{
        public abstract CmlScriptExpression GetLeft();
        public abstract CmlScriptExpression GetRight();

        public abstract CmlScriptBinaryOperator GetOperator();

        protected override CmlScriptValue CompileValue(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetLeft().Compile(execution, request, this_value);
            GetRight().Compile(execution, request, this_value);

            GetOperator().Compile(execution, request, this_value, GetLeft().GetValue(), GetRight().GetValue());
            return GetOperator().GetValue();
        }
	}

    public partial class CmlScriptExpression_BinaryOperation_Multiplicative : CmlScriptExpression_BinaryOperation
    { public override CmlScriptBinaryOperator GetOperator() { return GetOperatorMultiplicative(); } }

    public partial class CmlScriptExpression_BinaryOperation_Additive : CmlScriptExpression_BinaryOperation
    { public override CmlScriptBinaryOperator GetOperator() { return GetOperatorAdditive(); } }

    public partial class CmlScriptExpression_BinaryOperation_Comparative : CmlScriptExpression_BinaryOperation
    { public override CmlScriptBinaryOperator GetOperator() { return GetOperatorComparative(); } }

    public partial class CmlScriptExpression_BinaryOperation_Boolean : CmlScriptExpression_BinaryOperation
    { public override CmlScriptBinaryOperator GetOperator() { return GetOperatorBoolean(); } }
}
