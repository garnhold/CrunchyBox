using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ConstructorBuilderEX : ConstructorInfoPass
    {
        private ConstructorBuilder native_constructor_builder;

        private ParameterInfo[] parameter_infos;

        public ConstructorBuilderEX(ConstructorBuilder b, IEnumerable<Type> p)
        {
            native_constructor_builder = b;

            parameter_infos = p
                .ConvertWithIndex((i, t) => new ParameterInfoEX_Quick(t, i, native_constructor_builder))
                .ToArray();
        }

        public ILGenerator GetILGenerator()
        {
            return native_constructor_builder.GetILGenerator();
        }

        public override ConstructorInfo GetNativeConstructorInfo()
        {
            return native_constructor_builder.GetNativeConstructorInfo();
        }

        public override ParameterInfo[] GetParameters()
        {
            return parameter_infos;
        }
    }
}