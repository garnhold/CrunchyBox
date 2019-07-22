using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_IsNonExtensionMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsNonExtensionMethod INSTANCE = new Filterer_MethodInfo_IsNonExtensionMethod();

        private Filterer_MethodInfo_IsNonExtensionMethod()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsNonExtensionMethod();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsNonExtensionMethod()
        {
            return Filterer_MethodInfo_IsNonExtensionMethod.INSTANCE;
        }
    }
}