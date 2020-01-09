
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
    
    public class CmlScriptSignature
    {
        private List<CmlScriptParameter> parameters;

        public CmlScriptSignature(IEnumerable<CmlScriptParameter> p)
        {
            parameters = p.ToList();
        }

        public IEnumerable<CmlScriptParameter> GetParameters()
        {
            return parameters;
        }

        public override int GetHashCode()
        {
            return parameters.GetElementsHashCode();
        }

        public override bool Equals(object obj)
        {
            CmlScriptSignature cast;

            if (obj.Convert<CmlScriptSignature>(out cast))
            {
                if (cast.parameters.AreElementsEqual(parameters))
                    return true;
            }

            return false;
        }
    }
}
