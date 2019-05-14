using System;

using CrunchyDough;

namespace CrunchySack
{
    public class RepresentationModifier_General_Process<REPRESENTATION_TYPE> : RepresentationModifier_General<REPRESENTATION_TYPE>
    {
        private Process<CmlExecution, REPRESENTATION_TYPE> process;

        protected override void ApplyInternal(CmlExecution execution, REPRESENTATION_TYPE representation)
        {
            process(execution, representation);
        }

        public RepresentationModifier_General_Process(Process<CmlExecution, REPRESENTATION_TYPE> p)
        {
            process = p;
        }

        public RepresentationModifier_General_Process(Process<REPRESENTATION_TYPE> p) : this((e, r) => p(r)) { }
    }
}