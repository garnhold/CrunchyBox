using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class MethodBuilderEX : MethodInfoEX
    {
        private MethodBuilder native_method_builder;

        private ParameterInfo[] parameter_infos;

        public MethodBuilderEX(MethodBuilder b, IEnumerable<Type> p) : base(b)
        {
            native_method_builder = b;

            parameter_infos = p
                .ConvertWithIndex((i, t) => new ParameterInfoEX_Quick(t, i, native_method_builder))
                .ToArray();
        }

        public override ParameterInfo[] GetParameters()
        {
            return parameter_infos;
        }

        public ILGenerator GetILGenerator()
        {
            return native_method_builder.GetILGenerator();
        }
    }
}