using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_IsEffectivelyInstanceMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsEffectivelyInstanceMethod INSTANCE = new Filterer_MethodInfo_IsEffectivelyInstanceMethod();

        private Filterer_MethodInfo_IsEffectivelyInstanceMethod()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsEffectivelyInstanceMethod();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsInstanceMethod()
        {
            return Filterer_MethodInfo_IsEffectivelyInstanceMethod.INSTANCE;
        }
    }
}