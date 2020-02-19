using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfoSetChildrenSelector
    {
        private string name;

<<<<<<< Updated upstream
        public abstract void SolidifyInstance(CmlExecution execution, object representation, EffigyLink effigy_link, CmlSetMember member);
=======
        private bool can_set_value;
        private bool can_set_values;
        private bool can_link_value;
        private bool can_link_value_with_entity;

        private RepresentationInfo_SetMember set_member;

        private RepresentationInfoSet_SelectableChildren selectable_children;

        public abstract void SolidifyInstance(CmlContext context, object representation, EffigyLink effigy_link, CmlSetMember member);
>>>>>>> Stashed changes

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