using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_IsExtensionMethod<T> : Filterer_MethodInfo_IsExtensionMethod
    {
        static public readonly Filterer_MethodInfo_IsExtensionMethod<T> INSTANCE = new Filterer_MethodInfo_IsExtensionMethod<T>();

        private Filterer_MethodInfo_IsExtensionMethod() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsExtensionMethod<T>()
        {
            return Filterer_MethodInfo_IsExtensionMethod<T>.INSTANCE;
        }
    }

    public class Filterer_MethodInfo_IsExtensionMethod : Filterer_General<MethodInfo, IdentifiableType>
    {
        public Filterer_MethodInfo_IsExtensionMethod(Type t) : base(t)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsExtensionMethod(GetId());
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
        static public Filterer<MethodInfo> IsExtensionMethod(Type type)
        {
            return new Filterer_MethodInfo_IsExtensionMethod(type);
        }
    }
}