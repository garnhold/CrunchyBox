using System;

namespace Crunchy.Sack
{
    using Dough;
    
    public abstract class RepresentationModifier_General<REPRESENTATION_TYPE> : RepresentationModifier_General
    {
        protected abstract void ApplyInternal(CmlContext context, REPRESENTATION_TYPE representation);

        public override void Apply(CmlContext context, object representation)
        {
            REPRESENTATION_TYPE cast;

            if (representation.Convert<REPRESENTATION_TYPE>(out cast))
                ApplyInternal(context, cast);
        }

        public override Type GetRepresentationType()
        {
            return typeof(REPRESENTATION_TYPE);
        }
    }

    public abstract class RepresentationModifier_General : RepresentationModifier
    {
        public abstract void Apply(CmlContext context, object representation);
    }
}