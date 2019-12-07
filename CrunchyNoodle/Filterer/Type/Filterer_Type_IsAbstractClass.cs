using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Type_IsAbstractClass : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_IsAbstractClass INSTANCE = new Filterer_Type_IsAbstractClass();

        private Filterer_Type_IsAbstractClass()
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsAbstractClass();
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsAbstractClass()
        {
            return Filterer_Type_IsAbstractClass.INSTANCE;
        }
    }
}