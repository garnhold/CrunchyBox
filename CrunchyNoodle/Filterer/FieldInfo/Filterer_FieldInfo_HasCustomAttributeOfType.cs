using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_FieldInfo_HasCustomAttributeOfType<T> : Filterer_FieldInfo_HasCustomAttributeOfType where T : Attribute
    {
        static public readonly Filterer_FieldInfo_HasCustomAttributeOfType<T> INSTANCE = new Filterer_FieldInfo_HasCustomAttributeOfType<T>();

        private Filterer_FieldInfo_HasCustomAttributeOfType() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> HasCustomAttributeOfType<T>() where T : Attribute
        {
            return Filterer_FieldInfo_HasCustomAttributeOfType<T>.INSTANCE;
        }
    }

    public class Filterer_FieldInfo_HasCustomAttributeOfType : Filterer_General<FieldInfo, IdentifiableType>
    {
        public Filterer_FieldInfo_HasCustomAttributeOfType(Type t) : base(t)
        {
        }

        public override bool Filter(FieldInfo item)
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
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> HasCustomAttributeOfType(Type type)
        {
            return new Filterer_FieldInfo_HasCustomAttributeOfType(type);
        }
    }
}