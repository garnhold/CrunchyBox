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

        public RepresentationInfo_SetMember(string n, bool csv, bool clv, bool clve, RepresentationInfoSet s) : base(n, s.GetRepresentationType())
        {
            can_set_value = csv;
            can_link_value = clv;
            can_link_value_with_entity = clve;

            set = s;
        }

        public override void SetValue(CmlContext context, object representation, object value)
        {
            if (can_set_value)
            {
                context.GetSetSpace()
                    .GetSet(set)
                    .SetValue(GetName(), value);
            }
            else
            {
                base.SetValue(context, representation, value);
            }
        }

        public override void LinkValue(CmlContext context, object representation, VariableInstance variable_instance, HasInfo info)
        {
            if (can_link_value)
            {
                context.GetSetSpace()
                    .GetSet(set)
                    .LinkValue(GetName(), variable_instance, info);
            }
            else
            {
                base.LinkValue(context, representation, variable_instance, info);
            }
        }

        public override void LinkValueWithEntity(CmlContext context, object representation, VariableInstance variable_instance, CmlEntity entity, HasInfo info)
        {
            if (can_link_value_with_entity)
            {
                context.GetSetSpace()
                    .GetSet(set)
                    .LinkValueWithEntity(GetName(), variable_instance, entity, info);
            }
            else
            {
                base.LinkValueWithEntity(context, representation, variable_instance, entity, info);
            }
        }
    }
}