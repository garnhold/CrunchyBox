using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_IsAnyExtensionMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsAnyExtensionMethod INSTANCE = new Filterer_MethodInfo_IsAnyExtensionMethod();

        private Filterer_MethodInfo_IsAnyExtensionMethod()
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
            return Filterer_MethodInfo_IsAnyExtensionMethod.INSTANCE;
        }
    }
}