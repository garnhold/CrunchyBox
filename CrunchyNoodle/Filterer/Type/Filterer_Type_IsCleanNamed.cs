using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_IsCleanNamed : Filterer_General<Type, IdentifiableString>
    {
        public Filterer_Type_IsCleanNamed(string l) : base(l)
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsCleanName(GetId());
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsCleanNamed(string name)
        {
            return new Filterer_Type_IsCleanNamed(name);
        }
    }
}