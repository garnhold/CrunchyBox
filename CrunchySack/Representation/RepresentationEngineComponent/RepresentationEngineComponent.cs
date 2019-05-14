using System;

namespace CrunchySack
{
    public abstract class RepresentationEngineComponent
    {
        private RepresentationEngine engine;

        public void Initilize(RepresentationEngine e)
        {
            engine = e;
        }

        public RepresentationEngine GetEngine()
        {
            return engine;
        }
    }
}