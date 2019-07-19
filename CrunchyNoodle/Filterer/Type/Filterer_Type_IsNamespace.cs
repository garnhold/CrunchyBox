using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_IsNamespace : Filterer_General<Type, IdentifiableString>
    {
        public Filterer_Type_IsNamespace(string l) : base(l)
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsNamespace(GetId());
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsNamespace(string name)
        {
            return new Filterer_Type_IsNamespace(name);
        }
    }
}