using System;

using CrunchyDough;

namespace CrunchySack
{
    public abstract class RepresentationModifier_General<REPRESENTATION_TYPE> : RepresentationModifier_General
    {
        protected abstract void ApplyInternal(CmlExecution execution, REPRESENTATION_TYPE representation);

        public override void Apply(CmlExecution execution, object representation)
        {
            REPRESENTATION_TYPE cast;

            if (representation.Convert<REPRESENTATION_TYPE>(out cast))
                ApplyInternal(execution, cast);
        }

        public override Type GetRepresentationType()
        {
            return typeof(REPRESENTATION_TYPE);
        }
    }

    public abstract class RepresentationModifier_General : RepresentationModifier
    {
        public abstract void Apply(CmlExecution execution, object representation);
    }
}