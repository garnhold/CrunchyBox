using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_FieldInfo_HasCustomLabeledAttributeOfType<T> : Filterer_FieldInfo_HasCustomLabeledAttributeOfType where T : LabeledAttribute
    {
        public Filterer_FieldInfo_HasCustomLabeledAttributeOfType(string l) : base(typeof(T), l)
        {
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> HasCustomLabeledAttributeOfType<T>(string label) where T : LabeledAttribute
        {
            return new Filterer_FieldInfo_HasCustomLabeledAttributeOfType<T>(label);
        }
    }

    public class Filterer_FieldInfo_HasCustomLabeledAttributeOfType : Filterer_General<FieldInfo, IdentifiableType, IdentifiableString>
    {
        public Filterer_FieldInfo_HasCustomLabeledAttributeOfType(Type t, string l) : base(t, l)
        {
        }

        public override bool Filter(FieldInfo item)
        {
            return item.HasCustomLabeledAttributeOfType(GetId1(), GetId2(), false);
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsTypeVisible(GetId1())
            );
        }
    }
    static public partial class Filterer_FieldInfo
    {
        static public Filterer<FieldInfo> HasCustomLabeledAttributeOfType(Type type, string label)
        {
            return new Filterer_FieldInfo_HasCustomLabeledAttributeOfType(type, label);
        }
    }
}