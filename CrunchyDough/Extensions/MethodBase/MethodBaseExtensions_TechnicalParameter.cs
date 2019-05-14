using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class MethodBaseExtensions_TechnicalParameter
    {
        static public ParameterInfo[] GetTechnicalParameters(this MethodBase item)
        {
            return item.GetParameters();
        }

        static public IEnumerable<Type> GetTechnicalParameterTypes(this MethodBase item)
        {
            return item.GetTechnicalParameters().Convert(p => p.ParameterType);
        }

        static public int GetNumberTechnicalParameters(this MethodBase item)
        {
            return item.GetTechnicalParameters().Length;
        }
        static public bool HasTechnicalParameters(this MethodBase item)
        {
            if (item.GetNumberTechnicalParameters() >= 1)
                return true;

            return false;
        }
        static public bool HasNoTechnicalParameters(this MethodBase item)
        {
            if (item.HasTechnicalParameters() == false)
                return true;

            return false;
        }

        static public bool TryGetTechnicalParameter(this MethodBase item, int index, out ParameterInfo output)
        {
            return item.GetTechnicalParameters().TryGet(index, out output);
        }

        static public ParameterInfo GetTechnicalParameter(this MethodBase item, int index)
        {
            return item.GetTechnicalParameters().Get(index);
        }

        static public Type GetTechnicalParameterType(this MethodBase item, int index)
        {
            ParameterInfo parameter_info;

            if (item.TryGetTechnicalParameter(index, out parameter_info))
                return parameter_info.ParameterType;

            return null;
        }

        static public bool CanTechnicalParameterHold(this MethodBase item, int index, Type type)
        {
            ParameterInfo parameter_info;

            if (item.TryGetTechnicalParameter(index, out parameter_info))
                return parameter_info.CanHold(type);

            return false;
        }

        static public bool CanTechnicalParametersHold(this MethodBase item, IEnumerable<Type> parameter_types)
        {
            if (item.GetTechnicalParameters().AreElements(parameter_types, (p1, p2) => p1.CanHold(p2)))
                return true;

            return false;
        }
        static public bool CanTechnicalParametersHold(this MethodBase item, params Type[] parameter_types)
        {
            return item.CanTechnicalParametersHold((IEnumerable<Type>)parameter_types);
        }

        static public bool CanTechnicalParametersHold<P1>(this MethodBase item)
        {
            return item.CanTechnicalParametersHold(typeof(P1));
        }

        static public bool CanTechnicalParametersHold<P1, P2>(this MethodBase item)
        {
            return item.CanTechnicalParametersHold(typeof(P1), typeof(P2));
        }
    }
}