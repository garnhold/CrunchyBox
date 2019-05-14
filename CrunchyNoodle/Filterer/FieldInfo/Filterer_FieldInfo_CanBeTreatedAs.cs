using System;
using System.Reflection;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_FieldInfo_CanBeTreatedAs<T> : Filterer_FieldInfo_CanBeTreatedAs
    {
        static public readonly Filterer_FieldInfo_CanBeTreatedAs<T> INSTANCE = new Filterer_FieldInfo_CanBeTreatedAs<T>();

        private Filterer_FieldInfo_CanBeTreatedAs() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> CanBeTreatedAs<T>()
        {
            return Filterer_FieldInfo_CanBeTreatedAs<T>.INSTANCE;
        }
    }

    public class Filterer_FieldInfo_CanBeTreatedAs : Filterer_General<FieldInfo, IdentifiableType>
    {
        public Filterer_FieldInfo_CanBeTreatedAs(Type t) : base(t)
        {
        }

        public override bool Filter(FieldInfo item)
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
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> CanBeTreatedAs(Type type)
        {
            return new Filterer_FieldInfo_CanBeTreatedAs(type);
        }
    }
}