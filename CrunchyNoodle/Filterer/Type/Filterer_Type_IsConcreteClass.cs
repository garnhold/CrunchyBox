using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_IsConcreteClass : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_IsConcreteClass INSTANCE = new Filterer_Type_IsConcreteClass();

        private Filterer_Type_IsConcreteClass()
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsConcreteClass();
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsConcreteClass()
        {
            return Filterer_Type_IsConcreteClass.INSTANCE;
        }
    }
}