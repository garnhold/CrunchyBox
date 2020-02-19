using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_SetMember : RepresentationInfo
    {
        private bool can_set_value;
        private bool can_link_value;
        private bool can_link_value_with_entity;

        private RepresentationInfoSet set;

        private bool PushToRepresentationInternal(CmlValue_SystemValue value, object representation, CmlContext context)
        {
            if (can_set_value)
            {
                context.GetSetSpace()
                    .GetSet(set)
                    .SetValue(GetName(), value.GetSystemValue());

                return true;
            }

            return false;
        }

        private bool PushToRepresentationInternal(CmlValue_Link value, object representation, CmlContext context)
        {
            if (can_link_value)
            {
                context.GetSetSpace()
                    .GetSet(set)
                    .LinkValue(GetName(), value.GetVariableInstance(), value);

                return true;
            }

            return false;
        }

        private bool PushToRepresentationInternal(CmlValue_LinkWithEntity value, object representation, CmlContext context)
        {
            if (can_link_value_with_entity)
            {
                context.GetSetSpace()
                    .GetSet(set)
                    .LinkValueWithEntity(GetName(), value.GetLink().GetVariableInstance(), value.GetEntity(), value.GetLink());

                return true;
            }

            return false;
        }

        public RepresentationInfo_SetMember(string n, bool csv, bool clv, bool clve, RepresentationInfoSet s) : base(n, s.GetRepresentationType())
        {
            can_set_value = csv;
            can_link_value = clv;
            can_link_value_with_entity = clve;

            set = s;
        }
    }
}