using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_IsOriginalMethodOf<T> : Filterer_MethodInfo_IsOriginalMethodOf
    {
        static public readonly Filterer_MethodInfo_IsOriginalMethodOf<T> INSTANCE = new Filterer_MethodInfo_IsOriginalMethodOf<T>();

        private Filterer_MethodInfo_IsOriginalMethodOf() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsOriginalMethodOf<T>()
        {
            return Filterer_MethodInfo_IsOriginalMethodOf<T>.INSTANCE;
        }
    }

    public class Filterer_MethodInfo_IsOriginalMethodOf : Filterer_General<MethodInfo, IdentifiableType>
    {
        public Filterer_MethodInfo_IsOriginalMethodOf(Type t) : base(t)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsOriginalMethodOf(GetId());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsTypeDeclaredWithin(GetId())
            );
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsOriginalMethodOf(Type type)
        {
            return new Filterer_MethodInfo_IsOriginalMethodOf(type);
        }
    }
}