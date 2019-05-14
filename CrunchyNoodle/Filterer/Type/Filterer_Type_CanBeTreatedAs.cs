using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_CanBeTreatedAs<T> : Filterer_Type_CanBeTreatedAs
    {
        static public readonly Filterer_Type_CanBeTreatedAs<T> INSTANCE = new Filterer_Type_CanBeTreatedAs<T>();

        private Filterer_Type_CanBeTreatedAs() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> CanBeTreatedAs<T>()
        {
            return Filterer_Type_CanBeTreatedAs<T>.INSTANCE;
        }
    }

    public class Filterer_Type_CanBeTreatedAs : Filterer_General<Type, IdentifiableType>
    {
        public Filterer_Type_CanBeTreatedAs(Type t) : base(t)
        {
        }

        public override bool Filter(Type item)
        {
            return item.CanBeTreatedAs(GetId());
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
        static public Filterer<Type> CanBeTreatedAs(Type type)
        {
            return new Filterer_Type_CanBeTreatedAs(type);
        }
    }
}