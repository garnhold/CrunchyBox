using System;
using System.Collections;
using System.Collections.Generic;

using System.Text.RegularExpressions;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_MemberAttributes_Field
    {
        static private CompileTimeCache<bool, IdentifiableType, IdentifiableType> HAS_CUSTOM_ATTRIBUTE_OF_TYPE_ON_AN_INSTANCE_FIELD = ReflectionCache.Get().NewCompileTimeCache("HAS_CUSTOM_ATTRIBUTE_OF_TYPE_ON_AN_INSTANCE_FIELD", BoolHusker.INSTANCE, delegate(IdentifiableType item, IdentifiableType attribute_type) {
            if (item.GetValue().GetFilteredInstanceFields(Filterer_FieldInfo.HasCustomAttributeOfType(attribute_type)).IsNotEmpty())
                return true;

            return false;
        });
        static public bool HasCustomAttributeOfTypeOnAnInstanceField(this Type item, Type attribute_type)
        {
            return HAS_CUSTOM_ATTRIBUTE_OF_TYPE_ON_AN_INSTANCE_FIELD.Fetch(item, attribute_type);
        }
        static public bool HasCustomAttributeOfTypeOnAnInstanceField<T>(this Type item) where T : Attribute
        {
            return item.HasCustomAttributeOfTypeOnAnInstanceField(typeof(T));
        }
    }
}