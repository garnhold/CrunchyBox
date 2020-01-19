using System;

namespace Crunchy.Sack
{
    using Dough;
    
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

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddVariationInstancer<REPRESENTATION_TYPE>(this RepresentationEngine item, string t, string b, Process<REPRESENTATION_TYPE> p)
        {
            item.AddInstancer(
                new RepresentationInstancer_Variation_Process<REPRESENTATION_TYPE>(t, b, p)
            );
        }
    }
}