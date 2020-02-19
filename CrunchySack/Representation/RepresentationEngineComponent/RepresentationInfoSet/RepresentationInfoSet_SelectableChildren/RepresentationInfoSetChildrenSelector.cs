using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfoSetChildrenSelector
    {
        private string name;

        private bool can_set_value;
        private bool can_set_values;
        private bool can_link_value;
        private bool can_link_value_with_entity;

        private RepresentationInfo_SetMember set_member;

        private RepresentationInfoSet_SelectableChildren selectable_children;

        private void SolidifyInstanceInternal(CmlValue value, object representation, EffigyLink effigy_link, CmlContext context)
        {
            throw new CmlRuntimeError_InfoSupportException(value.GetTypeEX(), set_member);
        }

        public RepresentationInfoSetChildrenSelector(string n)
        {
            name = n;
        }

        public void Initialize(RepresentationInfoSet_SelectableChildren s)
        {
            selectable_children = s;

            set_member = selectable_children.RegisterSetMember(
                name,
                can_set_value,
                can_set_values,
                can_link_value,
                can_link_value_with_entity
            );
        }

        public void SolidifyInstance(CmlContext context, object representation, EffigyLink effigy_link, CmlValue value)
        {
            this.CallSpecializationMethod<CmlValue, object, EffigyLink, CmlContext>(
                "SolidifyInstanceInternal",
                value,
                representation,
                effigy_link,
                context
            );
        }

        public string GetName()
        {
            return name;
        }
    }
}