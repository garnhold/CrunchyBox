using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class ConstructorBuilderEX : ConstructorInfoEX
    {
        private ConstructorBuilder native_constructor_builder;

        private ParameterInfo[] parameter_infos;

        public ConstructorBuilderEX(ConstructorBuilder b, IEnumerable<Type> p) : base(b)
        {
            native_constructor_builder = b;

            parameter_infos = p
                .ConvertWithIndex((i, t) => new ParameterInfoEX_Quick(t, i, native_constructor_builder))
                .ToArray();
        }

        public override ParameterInfo[] GetParameters()
        {
            return parameter_infos;
        }

        public ILGenerator GetILGenerator()
        {
            return native_constructor_builder.GetILGenerator();
        }
    }
}