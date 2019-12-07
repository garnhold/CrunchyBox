using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Type_IsExtensionClass : Filterer_Simple<Type>
    {
        static public readonly Filterer_Type_IsExtensionClass INSTANCE = new Filterer_Type_IsExtensionClass();

        private Filterer_Type_IsExtensionClass()
        {
        }

        public override bool Filter(Type item)
        {
            return item.IsExtensionClass();
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.ContainsExtensionTypes()
            );
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> IsExtensionClass()
        {
            return Filterer_Type_IsExtensionClass.INSTANCE;
        }
    }
}