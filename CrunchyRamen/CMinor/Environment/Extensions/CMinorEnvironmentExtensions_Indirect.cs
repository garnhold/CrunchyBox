using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    static public class CMinorEnvironmentExtensions_Indirect
	{
        static public ILValue ResolveIndirectIdentifierAsValue(this CMinorEnvironment item, ILValue context, string id)
        {
            return item.ResolveIdentifierAsValue(context, id);
        }

        static public ILValue ResolveIndirectIdentifierAsIndexed(this CMinorEnvironment item, ILValue context, string id, ILValue index)
        {
            return item.ResolveIdentifierAsIndexed(context, id, index);
        }

        static public ILValue ResolveIndirectIdentifierAsInvokation(this CMinorEnvironment item, ILValue context, string id, IEnumerable<ILValue> arguments)
        {
            return item.ResolveIdentifierAsInvokation(context, id, arguments);
        }

        static public ILValue ResolveIndirectIdentifierAsGenericInvokation(this CMinorEnvironment item, ILValue context, string id, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            return item.ResolveIdentifierAsGenericInvokation(context, id, generic_arguments, arguments);
        }
	}
	
}
