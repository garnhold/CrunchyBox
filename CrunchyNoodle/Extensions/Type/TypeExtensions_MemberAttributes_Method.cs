using System;
using System.Collections;
using System.Collections.Generic;

using System.Text.RegularExpressions;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_MemberAttributes_Method
    {
        static private CompileTimeCache<bool, IdentifiableType, IdentifiableType> HAS_CUSTOM_ATTRIBUTE_OF_TYPE_ON_AN_INSTANCE_METHOD = ReflectionCache.Get().NewCompileTimeCache("HAS_CUSTOM_ATTRIBUTE_OF_TYPE_ON_AN_INSTANCE_METHOD", BoolHusker.INSTANCE, delegate(IdentifiableType item, IdentifiableType attribute_type) {
            if (item.GetValue().GetFilteredInstanceMethods(Filterer_MethodInfo.HasCustomAttributeOfType(attribute_type)).IsNotEmpty())
                return true;

            return false;
        });
        static public bool HasCustomAttributeOfTypeOnAnInstanceMethod(this Type item, Type attribute_type)
        {
            return HAS_CUSTOM_ATTRIBUTE_OF_TYPE_ON_AN_INSTANCE_METHOD.Fetch(item, attribute_type);
        }
        static public bool HasCustomAttributeOfTypeOnAnInstanceMethod<T>(this Type item) where T : Attribute
        {
            return item.HasCustomAttributeOfTypeOnAnInstanceMethod(typeof(T));
        }
    }
}