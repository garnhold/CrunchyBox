using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_SetMember : RepresentationInfo
    {
        private bool can_set_value;
        private bool can_set_values;
        private bool can_link_value;
        private bool can_link_value_with_entity;

        private RepresentationInfoSet set;

        private bool SetSetValue(CmlValue value, CmlContext context)
        {
            context.GetEntitySpace()
                .GetSet(set)
                .SetValue(GetName(), value);

            return true;
        }

        private bool PushToRepresentationInternal(CmlValue_SystemValue value, object representation, CmlContext context)
        {
            if (can_set_value)
                return SetSetValue(value, context);

            return false;
        }

        private bool PushToRepresentationInternal(CmlValue_SystemValues value, object representation, CmlContext context)
        {
            if (can_set_values)
                return SetSetValue(value, context);

            return false;
        }

        private bool PushToRepresentationInternal(CmlValue_Link value, object representation, CmlContext context)
        {
            if (can_link_value)
                return SetSetValue(value, context);

            return false;
        }

        private bool PushToRepresentationInternal(CmlValue_Link_WithEntity value, object representation, CmlContext context)
        {
            if (can_link_value_with_entity)
                return SetSetValue(value, context);

            return false;
        }

        public RepresentationInfo_SetMember(string n, bool csv, bool csvs, bool clv, bool clve, RepresentationInfoSet s) : base(n, s.GetRepresentationType())
        {
            can_set_value = csv;
            can_set_values = csvs;
            can_link_value = clv;
            can_link_value_with_entity = clve;

            set = s;
        }
    }
}