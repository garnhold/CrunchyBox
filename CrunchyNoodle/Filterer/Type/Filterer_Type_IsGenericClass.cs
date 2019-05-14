using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_IsGenericClass : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_IsGenericClass INSTANCE = new Filterer_Type_IsGenericClass();

        private Filterer_Type_IsGenericClass()
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsGenericClass();
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsGenericClass()
        {
            return Filterer_Type_IsGenericClass.INSTANCE;
        }
    }
}