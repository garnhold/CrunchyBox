using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract class UnaryOperatorInfoEX
    {
        private UnaryOperatorType operator_type;

        private Type input_type;
        private Type output_type;

        public abstract void RenderIL_Operate(ILCanvas canvas, ILValue input);

        public UnaryOperatorInfoEX(UnaryOperatorType t, Type i, Type o)
        {
            operator_type = t;

            input_type = i;
            output_type = o;
        }

        public UnaryOperatorType GetOperatorType()
        {
            return operator_type;
        }

        public Type GetInputType()
        {
            return input_type;
        }

        public Type GetOutputType()
        {
            return output_type;
        }
    }
}