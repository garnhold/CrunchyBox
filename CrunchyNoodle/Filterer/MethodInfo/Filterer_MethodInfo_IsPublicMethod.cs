using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_IsPublicMethod : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsPublicMethod INSTANCE = new Filterer_MethodInfo_IsPublicMethod();

        private Filterer_MethodInfo_IsPublicMethod()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsPublicMethod();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsPublicMethod()
        {
            return Filterer_MethodInfo_IsPublicMethod.INSTANCE;
        }
    }
}