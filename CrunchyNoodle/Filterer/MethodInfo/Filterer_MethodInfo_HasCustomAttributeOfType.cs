using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_HasCustomAttributeOfType<T> : Filterer_MethodInfo_HasCustomAttributeOfType where T : Attribute
    {
        static public readonly Filterer_MethodInfo_HasCustomAttributeOfType<T> INSTANCE = new Filterer_MethodInfo_HasCustomAttributeOfType<T>();

        private Filterer_MethodInfo_HasCustomAttributeOfType() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasCustomAttributeOfType<T>() where T : Attribute
        {
            return Filterer_MethodInfo_HasCustomAttributeOfType<T>.INSTANCE;
        }
    }

    public class Filterer_MethodInfo_HasCustomAttributeOfType : Filterer_General<MethodInfo, IdentifiableType>
    {
        public Filterer_MethodInfo_HasCustomAttributeOfType(Type t) : base(t)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.HasCustomAttributeOfType(GetId(), false);
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsTypeVisible(GetId())
            );
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasCustomAttributeOfType(Type type)
        {
            return new Filterer_MethodInfo_HasCustomAttributeOfType(type);
        }
    }
}