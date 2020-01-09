using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_IsExtensionMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsExtensionMethod INSTANCE = new Filterer_MethodInfo_IsExtensionMethod();

        private Filterer_MethodInfo_IsExtensionMethod()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsExtensionMethod();
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.ContainsExtensionTypes()
            );
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsExtensionMethod()
        {
            return Filterer_MethodInfo_IsExtensionMethod.INSTANCE;
        }
    }
}