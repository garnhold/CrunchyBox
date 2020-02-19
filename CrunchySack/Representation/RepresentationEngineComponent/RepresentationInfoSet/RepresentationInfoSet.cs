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

        protected void RegisterSetMember(string name)
        {
            RepresentationInfo_SetMember info = new RepresentationInfo_SetMember(name, this);

            GetEngine().IfNotNull(e => e.AddInfo(info));
            members.Add(info);
        }

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

        public Type GetRepresentationType()
        {
            return representation_type;
        }
    }
}