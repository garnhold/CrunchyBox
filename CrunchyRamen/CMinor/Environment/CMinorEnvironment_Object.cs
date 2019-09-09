using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyRamen
{
	public class CMinorEnvironment_Object : CMinorEnvironment
	{
        private ILValue obj;

        public CMinorEnvironment_Object(ILValue o)
        {
            obj = o;
        }

        public override ILValue ResolveThis()
        {
            return obj;
        }

        public override ILValue ResolveIdentifierAsValue(string id)
        {
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
