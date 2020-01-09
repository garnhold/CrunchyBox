using System;

namespace Crunchy.Sack
{
    using Dough;
    
    public abstract class RepresentationInstancer : RepresentationEngineComponent
    {
        private string tag;

        public abstract object Instance(CmlExecution execution);

        public RepresentationInstancer(string t)
        {
            tag = t;
        }

        public string GetTag()
        {
            return tag;
        }
    }
}