using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_IsExtensionMethodOf<T> : Filterer_MethodInfo_IsExtensionMethodOf
    {
        static public readonly Filterer_MethodInfo_IsExtensionMethodOf<T> INSTANCE = new Filterer_MethodInfo_IsExtensionMethodOf<T>();

        private Filterer_MethodInfo_IsExtensionMethodOf() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsExtensionMethodOf<T>()
        {
            return Filterer_MethodInfo_IsExtensionMethodOf<T>.INSTANCE;
        }
    }

    public class Filterer_MethodInfo_IsExtensionMethodOf : Filterer_General<MethodInfo, IdentifiableType>
    {
        public Filterer_MethodInfo_IsExtensionMethodOf(Type t) : base(t)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsExtensionMethodOf(GetId());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsTypeVisible(GetId()),
                Filterer_Assembly.ContainsExtensionTypes()
            );
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsExtensionMethodOf(Type type)
        {
            return new Filterer_MethodInfo_IsExtensionMethodOf(type);
        }
    }
}