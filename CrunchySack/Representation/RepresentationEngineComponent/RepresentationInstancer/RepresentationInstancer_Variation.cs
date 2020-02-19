using System;

namespace Crunchy.Sack
{
    using Dough;
    
    public abstract class RepresentationCreator_Variation<REPRESENTATION_TYPE> : RepresentationInstancer
    {
        private string base_tag;

        protected abstract void VariateInternal(REPRESENTATION_TYPE representation);

        public RepresentationCreator_Variation(string t, string b) : base(t)
        {
            base_tag = b;
        }

        public override object Instance(CmlContext context)
        {
            REPRESENTATION_TYPE representation = GetEngine().AssertInstance(context, base_tag).Convert<REPRESENTATION_TYPE>();

            VariateInternal(representation);
            return representation;
        }
    }
}