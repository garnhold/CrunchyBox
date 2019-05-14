using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_IsNamed : Filterer_General<Type, IdentifiableString>
    {
        public Filterer_Type_IsNamed(string l) : base(l)
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsNamed(GetId());
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsNamed(string name)
        {
            return new Filterer_Type_IsNamed(name);
        }
    }
}