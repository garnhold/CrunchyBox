using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfoSetChildrenSelector
    {
        private string name;

        public abstract void SolidifyInstance(CmlExecution execution, object representation, EffigyLink effigy_link, CmlSetMember member);

        public RepresentationInfoSetChildrenSelector(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
    }
}