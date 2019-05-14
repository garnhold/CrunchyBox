using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_IsImmediateParentOf<T> : Filterer_Type_IsImmediateParentOf
    {
        static public readonly Filterer_Type_IsImmediateParentOf<T> INSTANCE = new Filterer_Type_IsImmediateParentOf<T>();

        private Filterer_Type_IsImmediateParentOf() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsImmediateParentOf<T>()
        {
            return Filterer_Type_IsImmediateParentOf<T>.INSTANCE;
        }
    }

    public class Filterer_Type_IsImmediateParentOf : Filterer_General<Type, IdentifiableType>
    {
        public Filterer_Type_IsImmediateParentOf(Type t) : base(t)
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsImmediateParentOf(GetId());
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsImmediateParentOf(Type type)
        {
            return new Filterer_Type_IsImmediateParentOf(type);
        }
    }
}