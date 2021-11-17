using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_MethodInfo_IsPropSetCompatible : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsPropSetCompatible INSTANCE = new Filterer_MethodInfo_IsPropSetCompatible();

        private Filterer_MethodInfo_IsPropSetCompatible()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsPropSetCompatible();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsPropSetCompatible()
        {
            return Filterer_MethodInfo_IsPropSetCompatible.INSTANCE;
        }
    }
}