using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_IsOriginalMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsOriginalMethod INSTANCE = new Filterer_MethodInfo_IsOriginalMethod();

        private Filterer_MethodInfo_IsOriginalMethod()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsOriginalMethod();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsOriginalMethod()
        {
            return Filterer_MethodInfo_IsOriginalMethod.INSTANCE;
        }
    }
}