
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:09:21 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class CmlScriptParameter_Host : CmlScriptParameter
    {
        private List<CmlScriptParameter> parameters;

        public CmlScriptParameter_Host(IEnumerable<CmlScriptParameter> p)
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
            CmlScriptParameter_Host cast;

            if (obj.Convert<CmlScriptParameter_Host>(out cast))
            {
                if (cast.parameters.AreElementsEqual(parameters))
                    return true;
            }

            return false;
        }
    }
	
}
