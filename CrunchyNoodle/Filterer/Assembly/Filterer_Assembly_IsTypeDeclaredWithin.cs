using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Assembly_IsTypeDeclaredWithin : Filterer_General<Assembly, IdentifiableType>
    {
        public Filterer_Assembly_IsTypeDeclaredWithin(Type t) : base(t)
        {
        }

        public override bool Filter(Assembly item)
        {
            return item.IsTypeDeclaredWithin(GetId());
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> IsTypeDeclaredWithin(Type type)
        {
            return new Filterer_Assembly_IsTypeDeclaredWithin(type);
        }
    }
}