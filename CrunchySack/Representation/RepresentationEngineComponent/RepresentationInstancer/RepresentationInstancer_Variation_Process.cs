using System;

using CrunchyDough;

namespace CrunchySack
{
    public class RepresentationInstancer_Variation_Process<REPRESENTATION_TYPE> : RepresentationCreator_Variation<REPRESENTATION_TYPE>
    {
        private Process<REPRESENTATION_TYPE> process;

        protected override void VariateInternal(REPRESENTATION_TYPE representation)
        {
            process(representation);
        }

        public RepresentationInstancer_Variation_Process(string t, string b, Process<REPRESENTATION_TYPE> p) : base(t, b)
        {
            process = p;
        }
    }
}