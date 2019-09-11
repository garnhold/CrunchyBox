using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyRamen
{
	public class CMinorEnvironment_ObjectAndParams : CMinorEnvironment
	{
        private ILValue obj;
        private Dictionary<string, ILValue> parameters;

        public CMinorEnvironment_ObjectAndParams(ILValue o, IEnumerable<KeyValuePair<string, ILValue>> p)
        {
            obj = o;
            parameters = p.ToDictionary();
        }

        public override ILValue ResolveThis()
        {
            return obj;
        }

        public override ILValue ResolveIdentifierAsValue(string id)
        {
            ILValue value;
            if (parameters.TryGetValue(id, out value))
                return value;

            return obj.GetILProp(id);
        }

        public override ILValue ResolveIdentifierAsInvokation(string id, IEnumerable<ILValue> arguments)
        {
            return obj.GetILInvoke(id, arguments);
        }

        public override ILValue ResolveIdentifierAsGenericInvokation(string id, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return obj.GetILGenericInvoke(id, generic_arguments, arguments);
        }
	}
	
}
