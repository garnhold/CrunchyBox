using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_PropertyInfo_HasCustomAttributeOfType<T> : Filterer_PropertyInfo_HasCustomAttributeOfType where T : Attribute
    {
        static public readonly Filterer_PropertyInfo_HasCustomAttributeOfType<T> INSTANCE = new Filterer_PropertyInfo_HasCustomAttributeOfType<T>();

        private Filterer_PropertyInfo_HasCustomAttributeOfType() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> HasCustomAttributeOfType<T>() where T : Attribute
        {
            return Filterer_PropertyInfo_HasCustomAttributeOfType<T>.INSTANCE;
        }
    }

    public class Filterer_PropertyInfo_HasCustomAttributeOfType : Filterer_General<PropertyInfo, IdentifiableType>
    {
        public Filterer_PropertyInfo_HasCustomAttributeOfType(Type t) : base(t)
        {
        }

        public override bool Filter(PropertyInfo item)
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
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> HasCustomAttributeOfType(Type type)
        {
            return new Filterer_PropertyInfo_HasCustomAttributeOfType(type);
        }
    }
}