using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Assembly_IsTypeVisible<T> : Filterer_Assembly_IsTypeVisible
    {
        static public readonly Filterer_Assembly_IsTypeVisible<T> INSTANCE = new Filterer_Assembly_IsTypeVisible<T>();

        private Filterer_Assembly_IsTypeVisible() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> IsTypeVisible<T>()
        {
            return Filterer_Assembly_IsTypeVisible<T>.INSTANCE;
        }
    }

    public class Filterer_Assembly_IsTypeVisible : Filterer_General<Assembly, IdentifiableType>
    {
        public Filterer_Assembly_IsTypeVisible(Type t) : base(t)
        {
        }

        public override bool Filter(Assembly item)
        {
            return item.IsTypeVisible(GetId());
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> IsTypeVisible(Type type)
        {
            return new Filterer_Assembly_IsTypeVisible(type);
        }
    }
}