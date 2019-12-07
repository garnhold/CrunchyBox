using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Type_HasCustomForTypeAttributeOfType<T> : Filterer_Type_HasCustomForTypeAttributeOfType where T : ForTypeAttribute
    {
        public Filterer_Type_HasCustomForTypeAttributeOfType(Type t) : base(typeof(T), t)
        {
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> HasCustomForTypeAttributeOfType<T>(Type type) where T : ForTypeAttribute
        {
            return new Filterer_Type_HasCustomForTypeAttributeOfType<T>(type);
        }
    }

    public class Filterer_Type_HasCustomForTypeAttributeOfType : Filterer_General<Type, IdentifiableType, IdentifiableType>
    {
        public Filterer_Type_HasCustomForTypeAttributeOfType(Type a, Type t) : base(a, t)
        {
        }

        public override bool Filter(Type item)
        {
            return item.HasCustomForTypeAttributeOfType(GetId1(), GetId2());
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
        static public Filterer<Type> HasCustomForTypeAttributeOfType(Type attribute_type, Type type)
        {
            return new Filterer_Type_HasCustomForTypeAttributeOfType(attribute_type, type);
        }
    }
}