using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_ConstructorInfo_HasNoEffectiveParameters : Filterer_ConstructorInfo_CanEffectiveParametersHold
    {
        static public readonly Filterer_ConstructorInfo_HasNoEffectiveParameters INSTANCE = new Filterer_ConstructorInfo_HasNoEffectiveParameters();

        private Filterer_ConstructorInfo_HasNoEffectiveParameters() : base(null)
        {
        }
    }
    static public partial class Filterer_ConstructorInfo
    {
        static public Filterer<ConstructorInfo> HasNoEffectiveParameters()
        {
            return Filterer_ConstructorInfo_HasNoEffectiveParameters.INSTANCE;
        }
    }

    public class Filterer_ConstructorInfo_CanEffectiveParametersHold : Filterer_General<ConstructorInfo, IdentifiableEnumerable<IdentifiableType>>
    {
        public Filterer_ConstructorInfo_CanEffectiveParametersHold(IEnumerable<Type> p) : base(p.MakeIdentifiable())
        {
        }
        public Filterer_ConstructorInfo_CanEffectiveParametersHold(params Type[] p) : this((IEnumerable<Type>)p)
        {
        }

        public Filterer_ConstructorInfo_CanEffectiveParametersHold(IEnumerable<object> a) : this(a.Convert(o => o.GetTypeEX())) { }
        public Filterer_ConstructorInfo_CanEffectiveParametersHold(params object[] a) : this((IEnumerable<object>)a) { }
        public Filterer_ConstructorInfo_CanEffectiveParametersHold() : this(Empty.IEnumerable<Type>()) { }

        public override bool Filter(ConstructorInfo item)
        {
            return item.CanEffectiveParametersHold(GetId().GetValues());
        }
    }
    static public partial class Filterer_ConstructorInfo
    {
        static public Filterer<ConstructorInfo> CanEffectiveParametersHold(IEnumerable<Type> parameter_types)
        {
            return new Filterer_ConstructorInfo_CanEffectiveParametersHold(parameter_types);
        }
        static public Filterer<ConstructorInfo> CanEffectiveParametersHold(params Type[] parameter_types)
        {
            return new Filterer_ConstructorInfo_CanEffectiveParametersHold(parameter_types);
        }

        static public Filterer<ConstructorInfo> CanEffectiveParametersHold(IEnumerable<object> arguments)
        {
            return new Filterer_ConstructorInfo_CanEffectiveParametersHold(arguments);
        }
        static public Filterer<ConstructorInfo> CanEffectiveParametersHold(params object[] arguments)
        {
            return new Filterer_ConstructorInfo_CanEffectiveParametersHold(arguments);
        }
    }
}