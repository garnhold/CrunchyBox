using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRamen
{
	public abstract class CMinorEnvironment
	{
        public virtual ILValue ResolveThis()
        {
            throw new InvalidOperationException(GetType() + " doesn't support resolving to this.");
        }

        public virtual ILValue ResolveIdentifierAsValue(string id)
        {
            throw new InvalidOperationException(GetType() + " doesn't support resolving to values.");
        }

        public virtual ILValue ResolveIdentifierAsInvokation(string id, IEnumerable<ILValue> arguments)
        {
            throw new InvalidOperationException(GetType() + " doesn't support resolving to invokations.");
        }

        public virtual ILValue ResolveIdentifierAsGenericInvokation(string id, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            throw new InvalidOperationException(GetType() + " doesn't support resolving to generic invokations.");
        }
	}
	
}
