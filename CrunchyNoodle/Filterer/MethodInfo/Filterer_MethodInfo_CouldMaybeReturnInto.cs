using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_CouldMaybeReturnInto<T> : Filterer_MethodInfo_CouldMaybeReturnInto
    {
        static public readonly Filterer_MethodInfo_CouldMaybeReturnInto<T> INSTANCE = new Filterer_MethodInfo_CouldMaybeReturnInto<T>();

        private Filterer_MethodInfo_CouldMaybeReturnInto() : base(typeof(T))
        {
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> CouldMaybeReturnInto<T>()
        {
            return Filterer_MethodInfo_CouldMaybeReturnInto<T>.INSTANCE;
        }
    }

    public class Filterer_MethodInfo_CouldMaybeReturnInto : Filterer_General<MethodInfo, IdentifiableType>
    {
        public Filterer_MethodInfo_CouldMaybeReturnInto(Type t) : base(t)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.CouldMaybeReturnInto(GetId());
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
        static public Filterer<MethodInfo> CouldMaybeReturnInto(Type type)
        {
            return new Filterer_MethodInfo_CouldMaybeReturnInto(type);
        }
    }
}