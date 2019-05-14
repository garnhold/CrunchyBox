using System;

using CrunchyDough;

namespace CrunchySack
{
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