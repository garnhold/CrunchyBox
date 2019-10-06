using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropertyInfo_HasCustomLabeledAttributeOfType<T> : Filterer_PropertyInfo_HasCustomLabeledAttributeOfType where T : LabeledAttribute
    {
        public Filterer_PropertyInfo_HasCustomLabeledAttributeOfType(string l) : base(typeof(T), l)
        {
        }
    }
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> HasCustomLabeledAttributeOfType<T>(string label) where T : LabeledAttribute
        {
            return new Filterer_PropertyInfo_HasCustomLabeledAttributeOfType<T>(label);
        }
    }

    public class Filterer_PropertyInfo_HasCustomLabeledAttributeOfType : Filterer_General<PropertyInfo, IdentifiableType, IdentifiableString>
    {
        public Filterer_PropertyInfo_HasCustomLabeledAttributeOfType(Type t, string l) : base(t, l)
        {
        }

        public override bool Filter(PropertyInfo item)
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
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> HasCustomLabeledAttributeOfType(Type type, string label)
        {
            return new Filterer_PropertyInfo_HasCustomLabeledAttributeOfType(type, label);
        }
    }
}