using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropInfo_HasCustomLabeledAttributeOfType<T> : Filterer_PropInfo_HasCustomLabeledAttributeOfType where T : LabeledAttribute
    {
        public Filterer_PropInfo_HasCustomLabeledAttributeOfType(string l) : base(typeof(T), l)
        {
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> HasCustomLabeledAttributeOfType<T>(string label) where T : LabeledAttribute
        {
            return new Filterer_PropInfo_HasCustomLabeledAttributeOfType<T>(label);
        }
    }

    public class Filterer_PropInfo_HasCustomLabeledAttributeOfType : Filterer_General<PropInfoEX, IdentifiableType, IdentifiableString>
    {
        public Filterer_PropInfo_HasCustomLabeledAttributeOfType(Type t, string l) : base(t, l)
        {
        }

        public override bool Filter(PropInfoEX item)
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
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> HasCustomLabeledAttributeOfType(Type type, string label)
        {
            return new Filterer_PropInfo_HasCustomLabeledAttributeOfType(type, label);
        }
    }
}