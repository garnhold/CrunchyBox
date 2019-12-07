using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_IsDerivedMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsDerivedMethod INSTANCE = new Filterer_MethodInfo_IsDerivedMethod();

        private Filterer_MethodInfo_IsDerivedMethod()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsDerivedMethod();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsDerivedMethod()
        {
            return Filterer_MethodInfo_IsDerivedMethod.INSTANCE;
        }
    }
}