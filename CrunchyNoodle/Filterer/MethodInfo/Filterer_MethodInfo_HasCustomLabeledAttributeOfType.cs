using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_HasCustomLabeledAttributeOfType<T> : Filterer_MethodInfo_HasCustomLabeledAttributeOfType where T : LabeledAttribute
    {
        public Filterer_MethodInfo_HasCustomLabeledAttributeOfType(string l) : base(typeof(T), l)
        {
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasCustomLabeledAttributeOfType<T>(string label) where T : LabeledAttribute
        {
            return new Filterer_MethodInfo_HasCustomLabeledAttributeOfType<T>(label);
        }
    }

    public class Filterer_MethodInfo_HasCustomLabeledAttributeOfType : Filterer_General<MethodInfo, IdentifiableType, IdentifiableString>
    {
        public Filterer_MethodInfo_HasCustomLabeledAttributeOfType(Type t, string l) : base(t, l)
        {
        }

        public override bool Filter(MethodInfo item)
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
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasCustomLabeledAttributeOfType(Type type, string label)
        {
            return new Filterer_MethodInfo_HasCustomLabeledAttributeOfType(type, label);
        }
    }
}