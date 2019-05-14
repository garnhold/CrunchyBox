using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_CanHaveChildTypes : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_CanHaveChildTypes INSTANCE = new Filterer_Type_CanHaveChildTypes();

        private Filterer_Type_CanHaveChildTypes()
        {
        }

        public override bool Filter(Type item)
        {
            return item.CanHaveChildTypes();
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> CanHaveChildTypes()
        {
            return Filterer_Type_CanHaveChildTypes.INSTANCE;
        }
    }
}