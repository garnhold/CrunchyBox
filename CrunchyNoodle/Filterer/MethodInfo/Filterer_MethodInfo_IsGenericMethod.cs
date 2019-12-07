using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_IsGenericMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsGenericMethod INSTANCE = new Filterer_MethodInfo_IsGenericMethod();

        private Filterer_MethodInfo_IsGenericMethod()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsGenericMethod();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsGenericMethod()
        {
            return Filterer_MethodInfo_IsGenericMethod.INSTANCE;
        }
    }
}