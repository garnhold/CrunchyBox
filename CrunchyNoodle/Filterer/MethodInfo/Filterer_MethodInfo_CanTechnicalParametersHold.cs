using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_CanTechnicalParametersHold : Filterer_General<MethodInfo, IdentifiableEnumerable<IdentifiableType>>
    {
        public Filterer_MethodInfo_CanTechnicalParametersHold(IEnumerable<Type> p) : base(p.MakeIdentifiable())
        {
        }
        public Filterer_MethodInfo_CanTechnicalParametersHold(params Type[] p) : this((IEnumerable<Type>)p)
        {
        }

        public Filterer_MethodInfo_CanTechnicalParametersHold(IEnumerable<object> a) : this(a.Convert(o => o.GetTypeEX())) { }
        public Filterer_MethodInfo_CanTechnicalParametersHold(params object[] a) : this((IEnumerable<object>)a) { }
        public Filterer_MethodInfo_CanTechnicalParametersHold() : this(Empty.IEnumerable<Type>()) { }

        public override bool Filter(MethodInfo item)
        {
            return item.CanTechnicalParametersHold(GetId().GetValues());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return GetId().Convert(t => Filterer_Assembly.IsTypeVisible(t));
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> CanTechnicalParametersHold(IEnumerable<Type> parameter_types)
        {
            return new Filterer_MethodInfo_CanTechnicalParametersHold(parameter_types);
        }
        static public Filterer<MethodInfo> CanTechnicalParametersHold(params Type[] parameter_types)
        {
            return new Filterer_MethodInfo_CanTechnicalParametersHold(parameter_types);
        }
        static public Filterer<MethodInfo> CanTechnicalParametersHold()
        {
            return Filterer_MethodInfo_HasNoTechnicalParameters.INSTANCE;
        }

        static public Filterer<MethodInfo> CanTechnicalParametersHold(IEnumerable<object> arguments)
        {
            return new Filterer_MethodInfo_CanTechnicalParametersHold(arguments);
        }
        static public Filterer<MethodInfo> CanTechnicalParametersHold(params object[] arguments)
        {
            return new Filterer_MethodInfo_CanTechnicalParametersHold(arguments);
        }
    }
}