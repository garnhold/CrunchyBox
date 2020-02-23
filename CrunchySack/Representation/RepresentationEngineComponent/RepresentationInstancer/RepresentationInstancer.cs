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
            CmlEntitySpace entity_space;
            object representation = Instance(context);

            if (entity.HasId())
                context.GetRepresentationSpace().AddRepresentation(entity.GetId(), representation);

            context = context.NewEntitySpace(representation, out entity_space);

            context.GetEngine().AssertApplyGeneralModifiers(context, representation);
            entity.GetTopicalChildren<CmlEntityInfo>().Process(i => i.PushToRepresentation(context, representation));

            entity_space.SolidifyInstance(context);
            return representation;
        }

        public string GetTag()
        {
            return tag;
        }
    }
}