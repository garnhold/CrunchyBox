using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInstancer : RepresentationEngineComponent, CmlEntityInstancer
    {
        private string tag;

        public abstract object Instance(CmlContext context);

        public RepresentationInstancer(string t)
        {
            tag = t;
        }

        public object Instance(CmlContext context, CmlEntity entity)
        {
            CmlRepresentationSpace representation_space;
            object representation = Instance(context);

            if (entity.HasId())
                context.GetUnitSpace().AddRepresentation(entity.GetId(), representation);

            context = context.NewRepresentationSpace(representation, out representation_space);

            context.AddDeferredProcess(delegate() {
                context.GetEngine().AssertApplyGeneralModifiers(context, representation);
                entity.GetTopicalChildren<CmlEntityInfo>().Process(i => i.PushToRepresentation(context, representation));

                representation_space.SolidifyInstance(context);
            });

            return representation;
        }

        public string GetTag()
        {
            return tag;
        }
    }
}