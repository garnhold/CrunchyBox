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

        public override ILValue ResolveIdentifierAsValue(ILValue context, string id)
        {
            return base.ResolveIdentifierAsValue(context ?? obj, id);
        }

        public override ILValue ResolveIdentifierAsInvokation(ILValue context, string id, IEnumerable<ILValue> arguments)
        {
            return base.ResolveIdentifierAsInvokation(context ?? obj, id, arguments);
        }

        public override ILValue ResolveIdentifierAsGenericInvokation(ILValue context, string id, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return base.ResolveIdentifierAsGenericInvokation(context ?? obj, id, generic_arguments, arguments);
        }
	}
	
}
