
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlParameterSpace
	{
        private Dictionary<string, CmlParameter> parameters;

        public CmlParameterSpace(IEnumerable<CmlParameter> f)
        {
            parameters = f.ToDictionaryValues(z => z.GetName());
        }

        public CmlParameter GetParameter(string name)
        {
            return parameters.GetValue(name);
        }

        public IEnumerable<CmlParameter> GetParameters()
        {
            return parameters.Values;
        }

        public T GetParameterForcedSystemValue<T>(CmlContext context, string name)
        {
            return GetParameter(name).Solidify().ForceSystemValueEX<T>();
        }
	}
	
}
