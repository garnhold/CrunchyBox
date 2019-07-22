using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Filterer_Type_CanGenericParametersHold<P1> : Filterer_Type_CanGenericParametersHold
    {
        static public readonly Filterer_Type_CanGenericParametersHold<P1> INSTANCE = new Filterer_Type_CanGenericParametersHold<P1>();

        private Filterer_Type_CanGenericParametersHold() : base(typeof(P1))
        {
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> CanGenericParametersHold<P1>()
        {
            return Filterer_Type_CanGenericParametersHold<P1>.INSTANCE;
        }
    }

    public class Filterer_Type_CanGenericParametersHold<P1, P2> : Filterer_Type_CanGenericParametersHold
    {
        static public readonly Filterer_Type_CanGenericParametersHold<P1, P2> INSTANCE = new Filterer_Type_CanGenericParametersHold<P1, P2>();

        private Filterer_Type_CanGenericParametersHold() : base(typeof(P1), typeof(P2))
        {
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> CanGenericParametersHold<P1, P2>()
        {
            return Filterer_Type_CanGenericParametersHold<P1, P2>.INSTANCE;
        }
    }

    public class Filterer_Type_CanGenericParametersHold : Filterer_General<Type, IdentifiableEnumerable<IdentifiableType>>
    {
        public Filterer_Type_CanGenericParametersHold(IEnumerable<Type> p) : base(p.MakeIdentifiable())
        {
        }
        public Filterer_Type_CanGenericParametersHold(params Type[] p) : this((IEnumerable<Type>)p)
        {
        }

        public Filterer_Type_CanGenericParametersHold(IEnumerable<object> a) : this(a.Convert(o => o.GetTypeEX())) { }
        public Filterer_Type_CanGenericParametersHold(params object[] a) : this((IEnumerable<object>)a) { }

        public override bool Filter(Type item)
        {
            return item.CanGenericParametersHold(GetId().GetValues());
        }
    }
    static public partial class Filterer_Type
    {
        static public Filterer<Type> CanGenericParametersHold(IEnumerable<Type> parameter_types)
        {
            return new Filterer_Type_CanGenericParametersHold(parameter_types);
        }
        static public Filterer<Type> CanGenericParametersHold(params Type[] parameter_types)
        {
            return new Filterer_Type_CanGenericParametersHold(parameter_types);
        }

        static public Filterer<Type> CanGenericParametersHold(IEnumerable<object> arguments)
        {
            return new Filterer_Type_CanGenericParametersHold(arguments);
        }
        static public Filterer<Type> CanGenericParametersHold(params object[] arguments)
        {
            return new Filterer_Type_CanGenericParametersHold(arguments);
        }
    }
}