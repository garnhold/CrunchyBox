using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class MethodBaseExtensions_IL_EffectiveParameters
    {
        static public ILParameter GetEffectiveILParameter(this MethodBase item, int index)
        {
            return item.GetEffectiveParameter(index)
                .IfNotNull(p => new ILParameter(p));
        }

        static public IEnumerable<ILParameter> GetEffectiveILParameterRange(this MethodBase item, int start, int end)
        {
            for (int i = start; i < end; i++)
                yield return item.GetEffectiveILParameter(i);
        }

        static public IEnumerable<ILParameter> GetAllEffectiveILParameters(this MethodBase item)
        {
            return item.GetEffectiveILParameterRange(0, item.GetNumberEffectiveParameters());
        }
    }
}