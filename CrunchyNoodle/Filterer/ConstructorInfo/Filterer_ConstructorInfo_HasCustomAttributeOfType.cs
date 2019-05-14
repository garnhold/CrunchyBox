using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_ConstructorInfo_HasCustomAttributeOfType<T> : Filterer_ConstructorInfo_HasCustomAttributeOfType where T : Attribute
    {
        static public readonly Filterer_ConstructorInfo_HasCustomAttributeOfType<T> INSTANCE = new Filterer_ConstructorInfo_HasCustomAttributeOfType<T>();

        private Filterer_ConstructorInfo_HasCustomAttributeOfType() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_ConstructorInfo
    {
        static public Filterer<ConstructorInfo> HasCustomAttributeOfType<T>() where T : Attribute
        {
            return Filterer_ConstructorInfo_HasCustomAttributeOfType<T>.INSTANCE;
        }
    }

    public class Filterer_ConstructorInfo_HasCustomAttributeOfType : Filterer_General<ConstructorInfo, IdentifiableType>
    {
        public Filterer_ConstructorInfo_HasCustomAttributeOfType(Type t) : base(t)
        {
        }

        public override bool Filter(ConstructorInfo item)
        {
            return item.HasCustomAttributeOfType(GetId(), false);
        }
    }
    static public partial class Filterer_ConstructorInfo
    {
        static public Filterer<ConstructorInfo> HasCustomAttributeOfType(Type attribute_type)
        {
            return new Filterer_ConstructorInfo_HasCustomAttributeOfType(attribute_type);
        }
    }
}