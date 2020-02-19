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
            CmlSetSpace set_space;
            object representation = Instance(context);

            context = context.NewSetSpace(out set_space);

            context.GetEngine().AssertApplyGeneralModifiers(context, representation);
            entity.GetTopicalChildren<CmlEntityInfo>().Process(i => i.PushToRepresentation(context, representation));

            set_space.SolidifyInstance(context, representation);
            return representation;
        }

        public string GetTag()
        {
            return tag;
        }
    }
}