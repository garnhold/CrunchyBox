using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfoSet : RepresentationEngineComponent
    {
        private Type representation_type;

        private List<RepresentationInfo_SetMember> members;

        public abstract void SolidifyInstance(CmlContext context, object representation, CmlSet set);

        public RepresentationInfoSet(Type r)
        {
            representation_type = r;

            members = new List<RepresentationInfo_SetMember>();
        }

        public override void Initilize(RepresentationEngine e)
        {
            base.Initilize(e);

            members.Process(m => e.AddInfo(m));
        }

        public RepresentationInfo_SetMember RegisterSetMember(string name, bool can_set_value, bool can_set_values, bool can_set_link, bool can_set_link_with_entity)
        {
            RepresentationInfo_SetMember info = new RepresentationInfo_SetMember(name, can_set_value, can_set_values, can_set_link, can_set_link_with_entity, this);

            GetEngine().IfNotNull(e => e.AddInfo(info));
            members.Add(info);
            return info;
        }

        public Type GetRepresentationType()
        {
            return representation_type;
        }
    }
}