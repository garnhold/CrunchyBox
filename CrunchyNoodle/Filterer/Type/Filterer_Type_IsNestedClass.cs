using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_IsNestedClass : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_IsNestedClass INSTANCE = new Filterer_Type_IsNestedClass();

        private Filterer_Type_IsNestedClass()
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsNestedClass();
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsNestedClass()
        {
            return Filterer_Type_IsNestedClass.INSTANCE;
        }
    }
}