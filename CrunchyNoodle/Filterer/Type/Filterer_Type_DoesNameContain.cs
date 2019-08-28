using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_DoesNameContain : Filterer_General<Type, IdentifiableString>
    {
        public Filterer_Type_DoesNameContain(string l) : base(l)
        {
        }

        public override bool Filter(Type item)
        {
            return item.DoesNameContain(GetId());
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> DoesNameContain(string name)
        {
            return new Filterer_Type_DoesNameContain(name);
        }
    }
}