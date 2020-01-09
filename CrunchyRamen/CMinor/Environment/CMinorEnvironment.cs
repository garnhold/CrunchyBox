using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public abstract class CMinorEnvironment
	{
        public virtual Type ResolveTypeAsNormal(string id)
        {
            return Types.GetFilteredTypes(
                Filterer_Type.IsBasicNamed(id),
                Filterer_Type.IsNonGenericClass()
            ).GetFirst()
            .AssertNotNull(() => new CMinorCompileException("Unable to resolve type " + id));
        }

        public virtual Type ResolveTypeAsTemplated(string id, IEnumerable<Type> generic_arguments)
        {
            Type[] arguments = generic_arguments.ToArray();
            string display = id + "<" + arguments.ToString(", ") + ">";

            return Types.GetFilteredTypes(
                Filterer_Type.IsBasicNamed(id),
                Filterer_Type.IsGenericClass(),
                Filterer_Type.CanGenericParametersHold(arguments)
            ).GetFirst()
            .AssertNotNull(() => new CMinorCompileException("Unable to resolve the generic type " + display))
            .MakeGenericType(arguments);
        }

        public virtual ILValue ResolveThis()
        {
            throw new CMinorCompileException("Unable to resolve this");
        }

        public virtual ILValue ResolveIdentifierAsIndexed(ILValue context, string id, ILValue index)
        {
            if (context != null)
            {
                return context.GetILProp(id)
                    .AssertNotNull(() => new CMinorCompileException("Unable to resolve " + id + " of " + context.GetValueType() + " for indexing"))
                    .GetILIndexed(index)
                    .AssertNotNull(() => new CMinorCompileException("Unable to resolve indexing of " + context.GetValueType()));
            }

            throw new CMinorCompileException("Unable to resolve []");
        }

        public virtual ILValue ResolveIdentifierAsValue(ILValue context, string id)
        {
            if(context != null)
            {
                return context.GetILProp(id)
                    .AssertNotNull(() => new CMinorCompileException("Unable to resolve " + id + " as a value of " + context.GetValueType()));
            }

            throw new CMinorCompileException("Unable to resolve " + id + " as a value");
        }

        public virtual ILValue ResolveIdentifierAsInvokation(ILValue context, string id, IEnumerable<ILValue> arguments)
        {
            string display = id + "(" + arguments.GetValueTypes().ToString(", ") + ")";

            if (context != null)
            {
                return context.GetILInvoke(id, arguments)
                    .AssertNotNull(() => new CMinorCompileException("Unable to resolve " + display + " as an invokation of " + context.GetValueType()));
            }

            throw new CMinorCompileException("Unable to resolve " + display + " as an invokation");
        }

        public virtual ILValue ResolveIdentifierAsGenericInvokation(ILValue context, string id, IEnumerable<Type> generic_arguments, IEnumerable<ILValue> arguments)
        {
            string display = id + "<" + generic_arguments.ToString(", ") + ">(" + arguments.GetValueTypes().ToString(", ") + ")";

            if (context != null)
            {
                return context.GetILGenericInvoke(id, generic_arguments, arguments)
                    .AssertNotNull(() => new CMinorCompileException("Unable to resolve " + display + " as a generic invokation of " + context.GetValueType()));
            }

            throw new CMinorCompileException("Unable to resolve " + display + " as a generic invokation");
        }
	}
	
}
