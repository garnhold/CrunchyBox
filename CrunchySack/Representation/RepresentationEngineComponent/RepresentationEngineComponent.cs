using System;

namespace Crunchy.Sack
{
    public abstract class RepresentationEngineComponent
    {
        private RepresentationEngine engine;

        public virtual void Initilize(RepresentationEngine e)
        {
            engine = e;
        }

        public RepresentationEngine GetEngine()
        {
            return engine;
        }
    }
}