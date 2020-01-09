using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_IsNonGenericMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsNonGenericMethod INSTANCE = new Filterer_MethodInfo_IsNonGenericMethod();

        private Filterer_MethodInfo_IsNonGenericMethod()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsNonGenericMethod();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsNonGenericMethod()
        {
            return Filterer_MethodInfo_IsNonGenericMethod.INSTANCE;
        }
    }
}