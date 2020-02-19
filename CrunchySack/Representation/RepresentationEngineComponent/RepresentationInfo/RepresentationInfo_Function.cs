using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class RepresentationInfo_Function<REPRESENTATION_TYPE> : RepresentationInfo
    {
        protected abstract void ApplyFunctionSyncroToRepresentation(REPRESENTATION_TYPE representation, FunctionSyncro function_syncro);

        public RepresentationInfo_Function(string n) : base(n, typeof(REPRESENTATION_TYPE)) { }

        public override void InjectFunction(CmlContext context, object representation, FunctionInstance function_instance)
        {
            REPRESENTATION_TYPE cast;
            FunctionSyncro function_syncro = new FunctionSyncro(function_instance);

            context.AddFunctionSyncro(function_syncro);

            if (representation.Convert<REPRESENTATION_TYPE>(out cast))
                ApplyFunctionSyncroToRepresentation(cast, function_syncro);
        }
    }
}