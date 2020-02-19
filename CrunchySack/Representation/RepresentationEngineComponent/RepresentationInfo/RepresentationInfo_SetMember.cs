using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_SetMember : RepresentationInfo
    {
        private RepresentationInfoSet set;

        public RepresentationInfo_SetMember(string n, RepresentationInfoSet s) : base(n, s.GetRepresentationType())
        {
            set = s;
        }

        public override void SetValue(CmlContext context, object representation, object value)
        {
<<<<<<< Updated upstream
            execution.GetCallContext().GetSetSpace()
                .GetSet(set)
                .SetValue(GetName(), value);
=======
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
>>>>>>> Stashed changes
        }

        public override void LinkValue(CmlContext context, object representation, VariableInstance variable_instance, HasInfo info)
        {
<<<<<<< Updated upstream
            execution.GetCallContext().GetSetSpace()
                .GetSet(set)
                .LinkValue(GetName(), variable_instance, info);
=======
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
>>>>>>> Stashed changes
        }

        public override void LinkValueWithEntity(CmlContext context, object representation, VariableInstance variable_instance, CmlEntity entity, HasInfo info)
        {
<<<<<<< Updated upstream
            execution.GetCallContext().GetSetSpace()
                .GetSet(set)
                .LinkValueWithEntity(GetName(), variable_instance, entity, info);
=======
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
>>>>>>> Stashed changes
        }
    }
}