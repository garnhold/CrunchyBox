using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_HasNoReturn : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_HasNoReturn INSTANCE = new Filterer_MethodInfo_HasNoReturn();

        private Filterer_MethodInfo_HasNoReturn()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.HasNoReturn();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasNoReturn()
        {
            return Filterer_MethodInfo_HasNoReturn.INSTANCE;
        }
    }
}