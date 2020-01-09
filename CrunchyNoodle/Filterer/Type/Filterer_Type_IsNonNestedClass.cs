using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Type_IsNonNestedClass : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_IsNonNestedClass INSTANCE = new Filterer_Type_IsNonNestedClass();

        private Filterer_Type_IsNonNestedClass()
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsNonNestedClass();
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsNonNestedClass()
        {
            return Filterer_Type_IsNonNestedClass.INSTANCE;
        }
    }
}