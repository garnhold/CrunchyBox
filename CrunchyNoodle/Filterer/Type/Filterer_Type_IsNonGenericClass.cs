using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_IsNonGenericClass : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_IsNonGenericClass INSTANCE = new Filterer_Type_IsNonGenericClass();

        private Filterer_Type_IsNonGenericClass()
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsNonGenericClass();
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsNonGenericClass()
        {
            return Filterer_Type_IsNonGenericClass.INSTANCE;
        }
    }
}