using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_MethodInfo_IsPropGetCompatible : Filterer_Simple<MethodInfo>
    {
        static public readonly Filterer_MethodInfo_IsPropGetCompatible INSTANCE = new Filterer_MethodInfo_IsPropGetCompatible();

        private Filterer_MethodInfo_IsPropGetCompatible()
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsPropGetCompatible();
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsPropGetCompatible()
        {
            return Filterer_MethodInfo_IsPropGetCompatible.INSTANCE;
        }
    }
}