using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_MethodInfo_IsPropCompatible : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsPropCompatible INSTANCE = new Filterer_MethodInfo_IsPropCompatible();

        private Filterer_MethodInfo_IsPropCompatible()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsPropCompatible();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsPropCompatible()
        {
            return Filterer_MethodInfo_IsPropCompatible.INSTANCE;
        }
    }
}