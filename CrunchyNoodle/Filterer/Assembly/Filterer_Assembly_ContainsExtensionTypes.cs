using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_Assembly_ContainsExtensionTypes : Filterer_Simple<Assembly>
    {
        static public readonly Filterer_Assembly_ContainsExtensionTypes INSTANCE = new Filterer_Assembly_ContainsExtensionTypes();

        private Filterer_Assembly_ContainsExtensionTypes()
        {
        }

        public override bool Filter(Assembly item)
        {
            return item.ContainsExtensionTypes();
        }
    }
    static public partial class Filterer_Assembly
    {
        static public Filterer<Assembly> ContainsExtensionTypes()
        {
            return Filterer_Assembly_ContainsExtensionTypes.INSTANCE;
        }
    }
}