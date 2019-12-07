
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:09:21 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlScriptParameter_Single : CmlScriptParameter
    {
        private Type parameter_type;

        public CmlScriptParameter_Single(Type p)
        {
            parameter_type = p;
        }

        public Type GetParameterType()
        {
            return parameter_type;
        }

        public override int GetHashCode()
        {
            return parameter_type.GetHashCodeEX();
        }

        public override bool Equals(object obj)
        {
            CmlScriptParameter_Single cast;

            if (obj.Convert<CmlScriptParameter_Single>(out cast))
            {
                if (cast.parameter_type == parameter_type)
                    return true;
            }

            return false;
        }
    }
	
}
