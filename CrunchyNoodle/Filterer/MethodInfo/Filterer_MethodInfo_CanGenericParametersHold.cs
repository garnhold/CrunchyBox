using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Filterer_MethodInfo_CanGenericParametersHold : Filterer_General<MethodInfo, IdentifiableEnumerable<IdentifiableType>>
    {
        public Filterer_MethodInfo_CanGenericParametersHold(IEnumerable<Type> p) : base(p.MakeIdentifiable())
        {
        }
        public Filterer_MethodInfo_CanGenericParametersHold(params Type[] p) : this((IEnumerable<Type>)p)
        {
        }

        public Filterer_MethodInfo_CanGenericParametersHold(IEnumerable<object> a) : this(a.Convert(o => o.GetTypeEX())) { }
        public Filterer_MethodInfo_CanGenericParametersHold(params object[] a) : this((IEnumerable<object>)a) { }

        public override bool Filter(MethodInfo item)
        {
            return item.CanGenericParametersHold(GetId().GetValues());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return GetId().Convert(t => Filterer_Assembly.IsTypeVisible(t));
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> CanGenericParametersHold(IEnumerable<Type> parameter_types)
        {
            return new Filterer_MethodInfo_CanGenericParametersHold(parameter_types);
        }
        static public Filterer<MethodInfo> CanGenericParametersHold(params Type[] parameter_types)
        {
            return new Filterer_MethodInfo_CanGenericParametersHold(parameter_types);
        }

        static public Filterer<MethodInfo> CanGenericParametersHold(IEnumerable<object> arguments)
        {
            return new Filterer_MethodInfo_CanGenericParametersHold(arguments);
        }
        static public Filterer<MethodInfo> CanGenericParametersHold(params object[] arguments)
        {
            return new Filterer_MethodInfo_CanGenericParametersHold(arguments);
        }
    }
}