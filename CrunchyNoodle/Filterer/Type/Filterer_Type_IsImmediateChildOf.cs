using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Type_IsImmediateChildOf<T> : Filterer_Type_IsImmediateChildOf
    {
        static public readonly Filterer_Type_IsImmediateChildOf<T> INSTANCE = new Filterer_Type_IsImmediateChildOf<T>();

        private Filterer_Type_IsImmediateChildOf() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsImmediateChildOf<T>()
        {
            return Filterer_Type_IsImmediateChildOf<T>.INSTANCE;
        }
    }

    public class Filterer_Type_IsImmediateChildOf : Filterer_General<Type, IdentifiableType>
    {
        public Filterer_Type_IsImmediateChildOf(Type t) : base(t)
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsImmediateChildOf(GetId());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsTypeVisible(GetId())
            );
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsImmediateChildOf(Type type)
        {
            return new Filterer_Type_IsImmediateChildOf(type);
        }
    }
}