using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_ConstructorInfo_HasCustomLabeledAttributeOfType<T> : Filterer_ConstructorInfo_HasCustomLabeledAttributeOfType where T : LabeledAttribute
    {
        public Filterer_ConstructorInfo_HasCustomLabeledAttributeOfType(string l) : base(typeof(T), l)
        {
        }
    }
    static public partial class Filterer_ConstructorInfo
    {
        static public Filterer<ConstructorInfo> HasCustomLabeledAttributeOfType<T>(string label) where T : LabeledAttribute
        {
            return new Filterer_ConstructorInfo_HasCustomLabeledAttributeOfType<T>(label);
        }
    }

    public class Filterer_ConstructorInfo_HasCustomLabeledAttributeOfType : Filterer_General<ConstructorInfo, IdentifiableType, IdentifiableString>
    {
        public Filterer_ConstructorInfo_HasCustomLabeledAttributeOfType(Type t, string l) : base(t, l)
        {
        }

        public override bool Filter(ConstructorInfo item)
        {
            return item.HasCustomLabeledAttributeOfType(GetId1(), GetId2(), false);
        }
    }
    static public partial class Filterer_ConstructorInfo
    {
        static public Filterer<ConstructorInfo> HasCustomLabeledAttributeOfType(Type attribute_type, string label)
        {
            return new Filterer_ConstructorInfo_HasCustomLabeledAttributeOfType(attribute_type, label);
        }
    }
}