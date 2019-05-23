using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class MethodBuilderEX : MethodInfoPass
    {
        private MethodBuilder native_method_builder;

        private ParameterInfo[] parameter_infos;

        public MethodBuilderEX(MethodBuilder b, IEnumerable<Type> p)
        {
            native_method_builder = b;

            parameter_infos = p
                .ConvertWithIndex((i, t) => new ParameterInfoEX_Quick(t, i, native_method_builder))
                .ToArray();
        }

        public ILGenerator GetILGenerator()
        {
            return native_method_builder.GetILGenerator();
        }

        public override MethodInfo GetNativeMethodInfo()
        {
            return native_method_builder.GetNativeMethodInfo();
        }

        public override ParameterInfo[] GetParameters()
        {
            return parameter_infos;
        }
    }
}