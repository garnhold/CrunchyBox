using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_IsSealedClass : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_IsSealedClass INSTANCE = new Filterer_Type_IsSealedClass();

        private Filterer_Type_IsSealedClass()
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsSealedClass();
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsSealedClass()
        {
            return Filterer_Type_IsSealedClass.INSTANCE;
        }
    }
}