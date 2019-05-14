using System;
using System.Collections;
using System.Collections.Generic;

using System.Text.RegularExpressions;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_MemberAttributes
    {
        static private CompileTimeCache<bool, IdentifiableType, IdentifiableType> HAS_CUSTOM_ATTRIBUTE_OF_TYPE_ON_AN_INSTANCE_MEMBER = ReflectionCache.Get().NewCompileTimeCache("HAS_CUSTOM_ATTRIBUTE_OF_TYPE_ON_AN_INSTANCE_MEMBER", BoolHusker.INSTANCE, delegate(IdentifiableType item, IdentifiableType attribute_type) {
            if (item.GetType().HasCustomAttributeOfTypeOnAnInstanceField(attribute_type))
                return true;

            if (item.GetType().HasCustomAttributeOfTypeOnAnInstanceMethod(attribute_type))
                return true;

            return false;
        });
        static public bool HasCustomAttributeOfTypeOnAnInstanceMember(this Type item, Type attribute_type)
        {
            return HAS_CUSTOM_ATTRIBUTE_OF_TYPE_ON_AN_INSTANCE_MEMBER.Fetch(item, attribute_type);
        }
        static public bool HasCustomAttributeOfTypeOnAnInstanceMember<T>(this Type item) where T : Attribute
        {
            return item.HasCustomAttributeOfTypeOnAnInstanceMember(typeof(T));
        }
    }
}