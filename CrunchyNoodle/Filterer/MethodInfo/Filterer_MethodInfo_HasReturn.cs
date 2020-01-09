using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_HasReturn : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_HasReturn INSTANCE = new Filterer_MethodInfo_HasReturn();

        private Filterer_MethodInfo_HasReturn()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.HasReturn();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasReturn()
        {
            return Filterer_MethodInfo_HasReturn.INSTANCE;
        }
    }
}