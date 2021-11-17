using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_MethodInfo_IsPropish : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsPropish INSTANCE = new Filterer_MethodInfo_IsPropish();

        private Filterer_MethodInfo_IsPropish()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsPropish();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsPropish()
        {
            return Filterer_MethodInfo_IsPropish.INSTANCE;
        }
    }
}