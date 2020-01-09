using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_IsEffectivelyStaticMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsEffectivelyStaticMethod INSTANCE = new Filterer_MethodInfo_IsEffectivelyStaticMethod();

        private Filterer_MethodInfo_IsEffectivelyStaticMethod()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsEffectivelyStaticMethod();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsStaticMethod()
        {
            return Filterer_MethodInfo_IsEffectivelyStaticMethod.INSTANCE;
        }
    }
}