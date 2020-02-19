using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class RepresentationInfo_Function<REPRESENTATION_TYPE> : RepresentationInfo
    {
        protected abstract void ApplyFunctionSyncroToRepresentation(REPRESENTATION_TYPE representation, FunctionSyncro function_syncro);

        private bool PushToRepresentationInternal(CmlValue_Function value, object representation, CmlContext context)
        {
            REPRESENTATION_TYPE cast;
            FunctionSyncro function_syncro = new FunctionSyncro(value.GetFunctionInstance());

            context.AddFunctionSyncro(function_syncro);

            if (representation.Convert<REPRESENTATION_TYPE>(out cast))
                ApplyFunctionSyncroToRepresentation(cast, function_syncro);

            return true;
        }

        public RepresentationInfo_Function(string n) : base(n, typeof(REPRESENTATION_TYPE)) { }
    }
}