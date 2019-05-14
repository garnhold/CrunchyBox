using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_CanNthEffectiveParameterHold : Filterer_General<MethodInfo, IdentifiableInt, IdentifiableType>
    {
        public Filterer_MethodInfo_CanNthEffectiveParameterHold(int n, Type t) : base(n, t)
        {
        }

        public override bool Filter(MethodInfo item)
        {
            return item.GetEffectiveParameter(GetId1()).CanHold(GetId2());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return Enumerable.New(
                Filterer_Assembly.IsTypeVisible(GetId2())
            );
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> CanNthEffectiveParameterHold(int n, Type type)
        {
            return new Filterer_MethodInfo_CanNthEffectiveParameterHold(n, type);
        }
    }
}