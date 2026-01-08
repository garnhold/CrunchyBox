using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_CanReturnInto<T> : Filterer_MethodInfo_CanReturnInto
    {
        static public readonly Filterer_MethodInfo_CanReturnInto<T> INSTANCE = new Filterer_MethodInfo_CanReturnInto<T>();

        private Filterer_MethodInfo_CanReturnInto() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> CanReturnInto<T>()
        {
            return Filterer_MethodInfo_CanReturnInto<T>.INSTANCE;
        }

        static public Filterer<MethodInfo> CanReturnInto()
        {
            return Filterer_MethodInfo_HasNoReturn.INSTANCE;
        }
    }

    public class Filterer_MethodInfo_CanReturnInto : Filterer_General<MethodInfo, IdentifiableType>
    {
        public Filterer_MethodInfo_CanReturnInto(Type t) : base(t)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.CanReturnInto(GetId());
        }

        public override bool Filter(MethodInfo item, out MethodInfo adjusted)
        {
            return item.CanReturnInto(out adjusted, GetId());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsTypeVisible(GetId())
            );
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> CanReturnInto(Type type)
        {
            return new Filterer_MethodInfo_CanReturnInto(type);
        }
    }
}