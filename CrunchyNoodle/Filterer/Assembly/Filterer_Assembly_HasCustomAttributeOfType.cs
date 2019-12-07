using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Assembly_HasCustomAttributeOfType<T> : Filterer_Assembly_HasCustomAttributeOfType where T : Attribute
    {
        static public readonly Filterer_Assembly_HasCustomAttributeOfType<T> INSTANCE = new Filterer_Assembly_HasCustomAttributeOfType<T>();

        private Filterer_Assembly_HasCustomAttributeOfType() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> HasCustomAttributeOfType<T>() where T : Attribute
        {
            return Filterer_Assembly_HasCustomAttributeOfType<T>.INSTANCE;
        }
    }

    public class Filterer_Assembly_HasCustomAttributeOfType : Filterer_General<Assembly, IdentifiableType>
    {
        public Filterer_Assembly_HasCustomAttributeOfType(Type t) : base(t)
        {
        }

        public override bool Filter(Assembly item)
        {
            return item.HasCustomAttributeOfType(GetId(), false);
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> HasCustomAttributeOfType(Type attribute_type)
        {
            return new Filterer_Assembly_HasCustomAttributeOfType(attribute_type);
        }
    }
}