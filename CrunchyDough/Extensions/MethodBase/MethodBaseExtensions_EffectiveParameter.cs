using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class MethodBaseExtensions_EffectiveParameter
    {
        static private OperationCache<ParameterInfo[], MethodBase> GET_EFFECTIVE_PARAMETERS = ReflectionCache.Get().NewOperationCache(delegate(MethodBase item) {
            if (item.IsExtensionMethod())
                return item.GetParameters().Offset(1).ToArray();

            return item.GetParameters();
        });
        static public ParameterInfo[] GetEffectiveParameters(this MethodBase item)
        {
            return GET_EFFECTIVE_PARAMETERS.Fetch(item);
        }

        static public IEnumerable<Type> GetEffectiveParameterTypes(this MethodBase item)
        {
            return item.GetEffectiveParameters().Convert(p => p.ParameterType);
        }

        static public int GetNumberEffectiveParameters(this MethodBase item)
        {
            return item.GetEffectiveParameters().Length;
        }
        static public bool HasEffectiveParameters(this MethodBase item)
        {
            if (item.GetNumberEffectiveParameters() >= 1)
                return true;

            return false;
        }
        static public bool HasNoEffectiveParameters(this MethodBase item)
        {
            if (item.HasEffectiveParameters() == false)
                return true;

            return false;
        }

        static public bool TryGetEffectiveParameter(this MethodBase item, int index, out ParameterInfo output)
        {
            return item.GetEffectiveParameters().TryGet(index, out output);
        }

        static public ParameterInfo GetEffectiveParameter(this MethodBase item, int index)
        {
            return item.GetEffectiveParameters().Get(index);
        }

        static public Type GetEffectiveParameterType(this MethodBase item, int index)
        {
            ParameterInfo parameter_info;

            if (item.TryGetEffectiveParameter(index, out parameter_info))
                return parameter_info.ParameterType;

            return null;
        }

        static public bool CanEffectiveParameterHold(this MethodBase item, int index, Type type)
        {
            ParameterInfo parameter_info;

            if (item.TryGetEffectiveParameter(index, out parameter_info))
                return parameter_info.CanHold(type);

            return false;
        }

        static public bool CanEffectiveParametersHold(this MethodBase item, IEnumerable<Type> parameter_types)
        {
            if (item.GetEffectiveParameters().AreElements(parameter_types, (p1, p2) => p1.CanHold(p2)))
                return true;

            return false;
        }
        static public bool CanEffectiveParametersHold(this MethodBase item, params Type[] parameter_types)
        {
            return item.CanEffectiveParametersHold((IEnumerable<Type>)parameter_types);
        }

        static public bool CanEffectiveParametersHold<P1>(this MethodBase item)
        {
            return item.CanEffectiveParametersHold(typeof(P1));
        }

        static public bool CanEffectiveParametersHold<P1, P2>(this MethodBase item)
        {
            return item.CanEffectiveParametersHold(typeof(P1), typeof(P2));
        }
    }
}