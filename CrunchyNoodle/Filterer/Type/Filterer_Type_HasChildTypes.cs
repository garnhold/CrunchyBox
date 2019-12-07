using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Type_HasChildTypes : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_HasChildTypes INSTANCE = new Filterer_Type_HasChildTypes();

        private Filterer_Type_HasChildTypes()
        {
        }

        public override bool Filter(Type item)
        {
            return item.HasChildTypes();
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> HasChildTypes()
        {
            return Filterer_Type_HasChildTypes.INSTANCE;
        }
    }
}