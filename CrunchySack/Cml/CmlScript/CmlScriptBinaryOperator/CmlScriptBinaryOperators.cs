
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:33:22 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlScriptBinaryOperator_Multiplicative_Times : CmlScriptBinaryOperator_Multiplicative
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.Multiply; } }
    public partial class CmlScriptBinaryOperator_Multiplicative_Divide : CmlScriptBinaryOperator_Multiplicative
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.Divide; } }
    public partial class CmlScriptBinaryOperator_Multiplicative_Modulo : CmlScriptBinaryOperator_Multiplicative
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.Modulo; } }

    public partial class CmlScriptBinaryOperator_Additive_Plus : CmlScriptBinaryOperator_Additive
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.Add; } }
    public partial class CmlScriptBinaryOperator_Additive_Minus : CmlScriptBinaryOperator_Additive
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.Subtract; } }

    public partial class CmlScriptBinaryOperator_Boolean_And : CmlScriptBinaryOperator_Boolean
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.And; } }
    public partial class CmlScriptBinaryOperator_Boolean_Or : CmlScriptBinaryOperator_Boolean
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.Or; } }

    public partial class CmlScriptBinaryOperator_Comparative_IsEqualTo : CmlScriptBinaryOperator_Comparative
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.EqualTo; } }
    public partial class CmlScriptBinaryOperator_Comparative_IsNotEqualTo : CmlScriptBinaryOperator_Comparative
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.NotEqualTo; } }

    public partial class CmlScriptBinaryOperator_Comparative_IsLessThan : CmlScriptBinaryOperator_Comparative
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.LessThan; } }
    public partial class CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo : CmlScriptBinaryOperator_Comparative
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.LessThanOrEqualTo; } }

    public partial class CmlScriptBinaryOperator_Comparative_IsGreaterThan : CmlScriptBinaryOperator_Comparative
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.GreaterThan; } }
    public partial class CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo : CmlScriptBinaryOperator_Comparative
    { public override BinaryOperatorType GetOperatorType() { return BinaryOperatorType.GreaterThanOrEqualTo; } }
}
