using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_IsPrivateMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsPrivateMethod INSTANCE = new Filterer_MethodInfo_IsPrivateMethod();

        private Filterer_MethodInfo_IsPrivateMethod()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsPrivateMethod();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsPrivateMethod()
        {
            return Filterer_MethodInfo_IsPrivateMethod.INSTANCE;
        }
    }
}