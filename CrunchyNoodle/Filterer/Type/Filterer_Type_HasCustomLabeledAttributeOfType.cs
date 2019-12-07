using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Type_HasCustomLabeledAttributeOfType<T> : Filterer_Type_HasCustomLabeledAttributeOfType where T : LabeledAttribute
    {
        public Filterer_Type_HasCustomLabeledAttributeOfType(string l, bool i) : base(typeof(T), l, i)
        {
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> HasCustomLabeledAttributeOfType<T>(string label, bool inherit) where T : LabeledAttribute
        {
            return new Filterer_Type_HasCustomLabeledAttributeOfType<T>(label, inherit);
        }
    }

    public class Filterer_Type_HasCustomLabeledAttributeOfType : Filterer_General<Type, IdentifiableType, IdentifiableString, IdentifiableBool>
    {
        public Filterer_Type_HasCustomLabeledAttributeOfType(Type t, string l, bool i) : base(t, l, i)
        {
        }

        public override bool Filter(Type item)
        {
            return item.HasCustomLabeledAttributeOfType(GetId1(), GetId2(), GetId3());
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
        static public Filterer<Type> HasCustomLabeledAttributeOfType(Type attribute_type, string label, bool inherit)
        {
            return new Filterer_Type_HasCustomLabeledAttributeOfType(attribute_type, label, inherit);
        }
    }
}