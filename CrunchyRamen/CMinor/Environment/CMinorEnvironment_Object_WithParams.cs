using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyRamen
{
	public class CMinorEnvironment_Object_WithParams : CMinorEnvironment_Object
	{
        private Dictionary<string, ILValue> parameters;

        public CMinorEnvironment_Object_WithParams(ILValue o, IEnumerable<KeyValuePair<string, ILValue>> p) : base(o)
        {
            parameters = p.ToDictionary();
        }

        public override ILValue ResolveIdentifierAsValue(ILValue context, string id)
        {
            if (context == null)
            {
                ILValue value;
                if (parameters.TryGetValue(id, out value))
                    return value;
            }

            return base.ResolveIdentifierAsValue(context, id);
        }
	}
	
}
