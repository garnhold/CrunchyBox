using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    static public class CMinorEnvironmentExtensions_Direct
	{
        static public ILValue ResolveDirectIdentifierAsValue(this CMinorEnvironment item, string id)
        {
            return item.ResolveIdentifierAsValue(null, id);
        }

        static public ILValue ResolveDirectIdentifierAsIndexed(this CMinorEnvironment item, string id, ILValue index)
        {
            return item.ResolveIdentifierAsIndexed(null, id, index);
        }

        static public ILValue ResolveDirectIdentifierAsInvokation(this CMinorEnvironment item, string id, IEnumerable<ILValue> arguments)
        {
            return item.ResolveIdentifierAsInvokation(null, id, arguments);
        }

        static public ILValue ResolveDirectIdentifierAsGenericInvokation(this CMinorEnvironment item, string id, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return item.ResolveIdentifierAsGenericInvokation(null, id, generic_arguments, arguments);
        }
	}
	
}
