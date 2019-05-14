﻿using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_MethodInfo_HasNoEffectiveParameters : Filterer_MethodInfo_CanEffectiveParametersHold
    {
        static public readonly Filterer_MethodInfo_HasNoEffectiveParameters INSTANCE = new Filterer_MethodInfo_HasNoEffectiveParameters();

        private Filterer_MethodInfo_HasNoEffectiveParameters() : base(Empty.IEnumerable<Type>())
        {
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> HasNoEffectiveParameters()
        {
            return Filterer_MethodInfo_HasNoEffectiveParameters.INSTANCE;
        }
    }

    public class Filterer_MethodInfo_CanEffectiveParametersHold : Filterer_General<MethodInfo, IdentifiableEnumerable<IdentifiableType>>
    {
        public Filterer_MethodInfo_CanEffectiveParametersHold(IEnumerable<Type> p) : base(p.MakeIdentifiable())
        {
        }
        public Filterer_MethodInfo_CanEffectiveParametersHold(params Type[] p) : this((IEnumerable<Type>)p)
        {
        }

        public Filterer_MethodInfo_CanEffectiveParametersHold(IEnumerable<object> a) : this(a.Convert(o => o.GetTypeEX())) { }
        public Filterer_MethodInfo_CanEffectiveParametersHold(params object[] a) : this((IEnumerable<object>)a) { }
        public Filterer_MethodInfo_CanEffectiveParametersHold() : this(Empty.IEnumerable<Type>()) { }

        public override bool Filter(MethodInfo item)
        {
            return item.CanEffectiveParametersHold(GetId().GetValues());
        }

        public override IEnumerable<Filterer<Assembly>> GetAssemblyFilters()
        {
            return GetId().Convert(t => Filterer_Assembly.IsTypeVisible(t));
        }
    }
    static public partial class Filterer_MethodInfo
    {
        static public Filterer<MethodInfo> CanEffectiveParametersHold(IEnumerable<Type> parameter_types)
        {
            return new Filterer_MethodInfo_CanEffectiveParametersHold(parameter_types);
        }
        static public Filterer<MethodInfo> CanEffectiveParametersHold(params Type[] parameter_types)
        {
            return new Filterer_MethodInfo_CanEffectiveParametersHold(parameter_types);
        }
        static public Filterer<MethodInfo> CanEffectiveParametersHold()
        {
            return Filterer_MethodInfo_HasNoEffectiveParameters.INSTANCE;
        }

        static public Filterer<MethodInfo> CanEffectiveParametersHold(IEnumerable<object> arguments)
        {
            return new Filterer_MethodInfo_CanEffectiveParametersHold(arguments);
        }
        static public Filterer<MethodInfo> CanEffectiveParametersHold(params object[] arguments)
        {
            return new Filterer_MethodInfo_CanEffectiveParametersHold(arguments);
        }
    }
}