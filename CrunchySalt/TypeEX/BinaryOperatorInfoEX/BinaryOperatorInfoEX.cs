using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    public abstract class BinaryOperatorInfoEX
    {
        private BinaryOperatorType operator_type;

        private Type left_type;
        private Type right_type;

        private Type output_type;

        public abstract void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right);

        public BinaryOperatorInfoEX(BinaryOperatorType t, Type l, Type r, Type o)
        {
            operator_type = t;

            left_type = l;
            right_type = r;

            output_type = o;
        }

        public BinaryOperatorType GetOperatorType()
        {
            return operator_type;
        }

        public Type GetLeftType()
        {
            return left_type;
        }

        public Type GetRightType()
        {
            return right_type;
        }

        public Type GetOutputType()
        {
            return output_type;
        }
    }
}