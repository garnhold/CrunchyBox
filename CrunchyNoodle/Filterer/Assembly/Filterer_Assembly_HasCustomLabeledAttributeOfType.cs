using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Assembly_HasCustomLabeledAttributeOfType<T> : Filterer_Assembly_HasCustomLabeledAttributeOfType where T : LabeledAttribute
    {
        public Filterer_Assembly_HasCustomLabeledAttributeOfType(string l) : base(typeof(T), l)
        {
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> HasCustomLabeledAttributeOfType<T>(string label) where T : LabeledAttribute
        {
            return new Filterer_Assembly_HasCustomLabeledAttributeOfType<T>(label);
        }
    }

    public class Filterer_Assembly_HasCustomLabeledAttributeOfType : Filterer_General<Assembly, IdentifiableType, IdentifiableString>
    {
        public Filterer_Assembly_HasCustomLabeledAttributeOfType(Type t, string l) : base(t, l)
        {
        }

        public override bool Filter(Assembly item)
        {
            return item.HasCustomLabeledAttributeOfType(GetId1(), GetId2(), false);
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> HasCustomLabeledAttributeOfType(Type attribute_type, string label)
        {
            return new Filterer_Assembly_HasCustomLabeledAttributeOfType(attribute_type, label);
        }
    }
}