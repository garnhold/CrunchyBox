using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_FieldInfo_CanHold<T> : Filterer_FieldInfo_CanHold
    {
        static public readonly Filterer_FieldInfo_CanHold<T> INSTANCE = new Filterer_FieldInfo_CanHold<T>();

        private Filterer_FieldInfo_CanHold() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> CanHold<T>()
        {
            return Filterer_FieldInfo_CanHold<T>.INSTANCE;
        }
    }

    public class Filterer_FieldInfo_CanHold : Filterer_General<FieldInfo, IdentifiableType>
    {
        public Filterer_FieldInfo_CanHold(Type t) : base(t)
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.CanHold(GetId());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsAssemblyVisibleToType(GetId())
            );
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> CanHold(Type type)
        {
            return new Filterer_FieldInfo_CanHold(type);
        }
    }
}