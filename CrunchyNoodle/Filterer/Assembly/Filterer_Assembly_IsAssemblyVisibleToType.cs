using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Assembly_IsAssemblyVisibleToType<T> : Filterer_Assembly_IsAssemblyVisibleToType
    {
        static public readonly Filterer_Assembly_IsAssemblyVisibleToType<T> INSTANCE = new Filterer_Assembly_IsAssemblyVisibleToType<T>();

        private Filterer_Assembly_IsAssemblyVisibleToType() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> IsAssemblyVisibleToType<T>()
        {
            return Filterer_Assembly_IsAssemblyVisibleToType<T>.INSTANCE;
        }
    }

    public class Filterer_Assembly_IsAssemblyVisibleToType : Filterer_General<Assembly, IdentifiableType>
    {
        public Filterer_Assembly_IsAssemblyVisibleToType(Type t) : base(t)
        {
        }

        public override bool Filter(Assembly item)
        {
            return item.IsAssemblyVisibleToType(GetId());
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> IsAssemblyVisibleToType(Type type)
        {
            return new Filterer_Assembly_IsAssemblyVisibleToType(type);
        }
    }
}