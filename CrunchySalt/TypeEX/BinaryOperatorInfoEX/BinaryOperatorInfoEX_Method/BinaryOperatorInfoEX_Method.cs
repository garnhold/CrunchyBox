using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;
using CrunchySalt;

namespace CrunchySalt
{
    public class BinaryOperatorInfoEX_Method : BinaryOperatorInfoEX
    {
        private MethodInfoEX method;

        public BinaryOperatorInfoEX_Method(BinaryOperatorType t, MethodInfoEX m) : base(t, m.GetTechnicalParameterType(0), m.GetTechnicalParameterType(1), m.ReturnType)
        {
            method = m;
        }

        public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
        {
            method.GetStaticILMethodInvokation(left, right).RenderIL_Load(canvas);
        }
    }
}