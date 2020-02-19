using System;

namespace Crunchy.Sack
{
    using Dough;
    
    public class RepresentationModifier_General_Process<REPRESENTATION_TYPE> : RepresentationModifier_General<REPRESENTATION_TYPE>
    {
        private Process<CmlContext, REPRESENTATION_TYPE> process;

        protected override void ApplyInternal(CmlContext context, REPRESENTATION_TYPE representation)
        {
            process(context, representation);
        }

        public RepresentationModifier_General_Process(Process<CmlContext, REPRESENTATION_TYPE> p)
        {
            process = p;
        }

        public RepresentationModifier_General_Process(Process<REPRESENTATION_TYPE> p) : this((e, r) => p(r)) { }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddGeneralModifier<REPRESENTATION_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE> p)
        {
            item.AddGeneralModifier(
                new RepresentationModifier_General_Process<REPRESENTATION_TYPE>(p)
            );
        }

        static public void AddGeneralModifier<REPRESENTATION_TYPE>(this RepresentationEngine item, Process<CmlContext, REPRESENTATION_TYPE> p)
        {
            item.AddGeneralModifier(
                new RepresentationModifier_General_Process<REPRESENTATION_TYPE>(p)
            );
        }
    }
}