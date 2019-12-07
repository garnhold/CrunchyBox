using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodBaseExtensions_IL_TechnicalParameters
    {
        static public ILParameter GetTechnicalILParameter(this MethodBase item, int index)
        {
            return item.GetTechnicalParameter(index)
                .IfNotNull(p => new ILParameter(p));
        }

        static public IEnumerable<ILParameter> GetTechnicalILParameterRange(this MethodBase item, int start, int end)
        {
            for (int i = start; i < end; i++)
                yield return item.GetTechnicalILParameter(i);
        }

        static public IEnumerable<ILParameter> GetAllTechnicalILParameters(this MethodBase item)
        {
            return item.GetTechnicalILParameterRange(0, item.GetNumberTechnicalParameters());
        }
    }
}