using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_IsDeclaredWithin : Filterer_General<MethodInfo, IdentifiableType>
    {
        public Filterer_MethodInfo_IsDeclaredWithin(Type l) : base(l)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.IsDeclaredWithin(GetId());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsTypeDeclaredWithin(GetId())
            );
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> IsDeclaredWithin(Type type)
        {
            return new Filterer_MethodInfo_IsDeclaredWithin(type);
        }
    }
}