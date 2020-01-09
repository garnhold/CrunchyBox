using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_PropInfo_HasCustomAttributeOfType<T> : Filterer_PropInfo_HasCustomAttributeOfType where T : Attribute
    {
        static public readonly Filterer_PropInfo_HasCustomAttributeOfType<T> INSTANCE = new Filterer_PropInfo_HasCustomAttributeOfType<T>();

        private Filterer_PropInfo_HasCustomAttributeOfType() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> HasCustomAttributeOfType<T>() where T : Attribute
        {
            return Filterer_PropInfo_HasCustomAttributeOfType<T>.INSTANCE;
        }
    }

    public class Filterer_PropInfo_HasCustomAttributeOfType : Filterer_General<PropInfoEX, IdentifiableType>
    {
        public Filterer_PropInfo_HasCustomAttributeOfType(Type t) : base(t)
        {
        }

        public override bool Filter(PropInfoEX item)
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
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> HasCustomAttributeOfType(Type type)
        {
            return new Filterer_PropInfo_HasCustomAttributeOfType(type);
        }
    }
}