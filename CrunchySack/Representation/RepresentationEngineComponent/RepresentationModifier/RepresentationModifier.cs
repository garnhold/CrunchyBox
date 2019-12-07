using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationModifier : RepresentationEngineComponent
    {
        public abstract Type GetRepresentationType();
    }
}