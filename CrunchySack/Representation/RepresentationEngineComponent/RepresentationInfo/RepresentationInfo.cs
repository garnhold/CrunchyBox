using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfo : RepresentationEngineComponent
    {
        public abstract Type GetRepresentationType();
    }
}