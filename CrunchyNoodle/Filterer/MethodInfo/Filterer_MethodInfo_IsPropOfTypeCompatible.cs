using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_MethodInfo_IsPropOfTypeCompatible<T> : Filterer_MethodInfo_IsPropOfTypeCompatible
    {
        static public readonly Filterer_MethodInfo_IsPropOfTypeCompatible<T> INSTANCE = new Filterer_MethodInfo_IsPropOfTypeCompatible<T>();

        private Filterer_MethodInfo_IsPropOfTypeCompatible() : base(typeof(T)) { }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsPropOfTypeCompatible<T>()
        {
            return Filterer_MethodInfo_IsPropOfTypeCompatible<T>.INSTANCE;
        }
    }

    public class Filterer_MethodInfo_IsPropOfTypeCompatible : Filterer_General<MethodInfo, IdentifiableType>
    {
        public Filterer_MethodInfo_IsPropOfTypeCompatible(Type t) : base(t)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsPropOfTypeCompatible(GetId());
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsPropOfTypeCompatible(Type type)
        {
            return new Filterer_MethodInfo_IsPropOfTypeCompatible(type);
        }
    }
}