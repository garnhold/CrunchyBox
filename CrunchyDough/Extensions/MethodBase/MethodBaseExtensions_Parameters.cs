using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	static public class MethodBaseExtensions_Parameter
    {
		static public ParameterInfo[] GetTechnicalParameters(this MethodBase item)
        {
            return item.GetParameters();
        }

		static private OperationCache<ParameterInfo[], MethodBase> GET_EFFECTIVE_PARAMETERS = ReflectionCache.Get().NewOperationCache("GET_EFFECTIVE_PARAMETERS", delegate(MethodBase item) {
            if (item.IsExtensionMethod())
                return item.GetParameters().Offset(1).ToArray();

            return item.GetParameters();
        });
        static public ParameterInfo[] GetEffectiveParameters(this MethodBase item)
        {
            return GET_EFFECTIVE_PARAMETERS.Fetch(item);
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

		static public bool CanTechnicalParametersHold(this MethodInfo item, out MethodInfo output, IEnumerable<Type> parameter_types)
        {
            if (item.IsGenericTypelessMethod())
            {
                Type[] generic_arguments = new Type[item.GetNumberGenericParameters()];

                if(item.GetTechnicalParameterTypes()
                    .PairStrict(parameter_types)
					.AreAll(p => p.item1.FillGenericArgumentsToHold(p.item2, generic_arguments)))
				{
					if (generic_arguments.AreAllNotNull())
						item = item.MakeGenericMethod(generic_arguments);
				}
            }

            output = item;
            return item.CanTechnicalParametersHold(parameter_types);
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

		static public bool CanEffectiveParametersHold(this MethodInfo item, out MethodInfo output, IEnumerable<Type> parameter_types)
        {
            if (item.IsGenericTypelessMethod())
            {
                Type[] generic_arguments = new Type[item.GetNumberGenericParameters()];

                if(item.GetEffectiveParameterTypes()
                    .PairStrict(parameter_types)
					.AreAll(p => p.item1.FillGenericArgumentsToHold(p.item2, generic_arguments)))
				{
					if (generic_arguments.AreAllNotNull())
						item = item.MakeGenericMethod(generic_arguments);
				}
            }

            output = item;
            return item.CanEffectiveParametersHold(parameter_types);
        }
	}
}