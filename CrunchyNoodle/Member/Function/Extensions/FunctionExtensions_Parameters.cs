using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class FunctionExtensions_Parameters
    {
        static public bool HasNoParameters(this Function item)
        {
            if (item.GetNumberParameters() == 0)
                return true;

            return false;
        }
        static public bool HasParameters(this Function item)
        {
            if (item.HasNoParameters() == false)
                return true;

            return false;
        }

        static public bool CanParametersHold(this Function item, IEnumerable<Type> types)
        {
            if (item.GetParameterTypes().AreElements(types, (t1, t2) => t1.CanHold(t2)))
                return true;

            return false;
        }
        static public bool CanParametersHold(this Function item, params Type[] types)
        {
            return item.CanParametersHold((IEnumerable<Type>)types);
        }

        static public bool CanParametersHold<P1>(this Function item)
        {
            return item.CanParametersHold(typeof(P1));
        }

        static public bool CanParametersHold<P1, P2>(this Function item)
        {
            return item.CanParametersHold(typeof(P1), typeof(P2));
        }

        static public bool CanParametersHold<P1, P2, P3>(this Function item)
        {
            return item.CanParametersHold(typeof(P1), typeof(P2), typeof(P3));
        }

        static public bool CanParametersHold<P1, P2, P3, P4>(this Function item)
        {
            return item.CanParametersHold(typeof(P1), typeof(P2), typeof(P3), typeof(P4));
        }

        static public bool CanParametersHold<P1, P2, P3, P4, P5>(this Function item)
        {
            return item.CanParametersHold(typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5));
        }
    }
}