using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Type_IsStaticClass : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_IsStaticClass INSTANCE = new Filterer_Type_IsStaticClass();

        private Filterer_Type_IsStaticClass()
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsStaticClass();
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsStaticClass()
        {
            return Filterer_Type_IsStaticClass.INSTANCE;
        }
    }
}