using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfo : RepresentationEngineComponent
    {
        private Type representation_type;

        public RepresentationInfo(Type r)
        {
            representation_type = r;
        }

        public Type GetRepresentationType()
        {
            return representation_type;
        }
    }
}