using System;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class RepresentationInfo_Attribute_Function<REPRESENTATION_TYPE> : RepresentationInfo_Attribute
    {
        protected abstract void ApplyFunctionSyncroToRepresentation(REPRESENTATION_TYPE representation, FunctionSyncro function_syncro);

        public RepresentationInfo_Attribute_Function(string n) : base(n, typeof(REPRESENTATION_TYPE)) { }

        public override void InjectRepresentationFunction(object representation, FunctionSyncro function_syncro)
        {
            REPRESENTATION_TYPE cast;

            if (representation.Convert<REPRESENTATION_TYPE>(out cast))
                ApplyFunctionSyncroToRepresentation(cast, function_syncro);
        }
    }
}