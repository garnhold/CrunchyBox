using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class RepresentationInfo_Attribute_Function<REPRESENTATION_TYPE> : RepresentationInfo_Attribute
    {
        protected abstract void ApplyFunctionSyncroToRepresentation(REPRESENTATION_TYPE representation, FunctionSyncro function_syncro);

        public RepresentationInfo_Attribute_Function(string n) : base(n, typeof(REPRESENTATION_TYPE)) { }

        public override void InjectRepresentationFunction(CmlExecution execution, object representation, FunctionSyncro function_syncro)
        {
            REPRESENTATION_TYPE cast;

            if (representation.Convert<REPRESENTATION_TYPE>(out cast))
                ApplyFunctionSyncroToRepresentation(cast, function_syncro);
        }
    }
}