using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Type_IsBasicNamed : Filterer_General<Type, IdentifiableString>
    {
        public Filterer_Type_IsBasicNamed(string l) : base(l)
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsBasicName(GetId());
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsBasicNamed(string name)
        {
            return new Filterer_Type_IsBasicNamed(name);
        }
    }
}