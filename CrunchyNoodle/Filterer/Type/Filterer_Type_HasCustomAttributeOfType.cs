using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Type_HasCustomAttributeOfType<T> : Filterer_Type_HasCustomAttributeOfType where T : Attribute
    {
        static public readonly Filterer_Type_HasCustomAttributeOfType<T> INSTANCE_INHERIT_FALSE = new Filterer_Type_HasCustomAttributeOfType<T>(false);
        static public readonly Filterer_Type_HasCustomAttributeOfType<T> INSTANCE_INHERIT_TRUE = new Filterer_Type_HasCustomAttributeOfType<T>(true);
        static public Filterer_Type_HasCustomAttributeOfType<T> GetInstance(bool inherit)
        {
            return inherit.ConvertBool(INSTANCE_INHERIT_TRUE, INSTANCE_INHERIT_FALSE);
        }

        private Filterer_Type_HasCustomAttributeOfType(bool i) : base(typeof(T), i)
        {
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> HasCustomAttributeOfType<T>(bool inherit) where T : Attribute
        {
            return Filterer_Type_HasCustomAttributeOfType<T>.GetInstance(inherit);
        }
    }

    public class Filterer_Type_HasCustomAttributeOfType : Filterer_General<Type, IdentifiableType, IdentifiableBool>
    {
        public Filterer_Type_HasCustomAttributeOfType(Type t, bool i) : base(t, i)
        {
        }

        public override bool Filter(Type item)
        {
            return item.HasCustomAttributeOfType(GetId1(), GetId2());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsTypeVisible(GetId1())
            );
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> HasCustomAttributeOfType(Type attribute_type, bool inherit)
        {
            return new Filterer_Type_HasCustomAttributeOfType(attribute_type, inherit);
        }
    }
}