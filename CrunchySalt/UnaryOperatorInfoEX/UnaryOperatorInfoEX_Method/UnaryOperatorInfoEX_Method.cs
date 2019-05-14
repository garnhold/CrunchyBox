using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;
using CrunchySalt;

namespace CrunchySalt
{
    public class UnaryOperatorInfoEX_Method : UnaryOperatorInfoEX
    {
        private MethodInfoEX method;

        public UnaryOperatorInfoEX_Method(UnaryOperatorType t, MethodInfoEX m) : base(t, m.GetTechnicalParameterType(0), m.ReturnType)
        {
            method = m;
        }

        public override void RenderIL_Operate(ILCanvas canvas, ILValue input)
        {
            method.GetStaticILMethodInvokation(input).RenderIL_Load(canvas);
        }
    }
}