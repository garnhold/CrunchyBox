using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_MethodInfo : TyonTypeHandler_Substitute_ExplicitType<MethodInfo, MethodReference>
    {
    }

    public class MethodReference
    {
        public readonly Type declaring_type;
        public readonly string name;
        public readonly List<Type> parameter_types;

        static public implicit operator MethodInfo(MethodReference r)
        {
            return r.Resolve();
        }

        static public implicit operator MethodReference(MethodInfo i)
        {
            return new MethodReference(i);
        }

        public MethodReference(Type d, string n, IEnumerable<Type> p)
        {
            declaring_type = d;
            name = n;
            parameter_types = p.ToList();
        }

        public MethodReference() : this(null, "", Empty.IEnumerable<Type>()) { }
        public MethodReference(MethodInfo i) : this(i.DeclaringType, i.Name, i.GetTechnicalParameterTypes()) { }

        public MethodInfo Resolve()
        {
            return declaring_type.GetFilteredMethods(
                Filterer_MethodInfo.IsNamed(name),
                Filterer_MethodInfo.CanTechnicalParametersHold(parameter_types)
            ).GetFirst();
        }
    }
}
