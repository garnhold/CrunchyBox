using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfo_Set : RepresentationInfo
    {
        private List<RepresentationInfo_Children_Set> children_infos;
        private List<RepresentationInfo_Attribute_Set> attribute_infos;

        public abstract void SolidifyInstance(CmlExecution execution, object representation, CmlSet set);

        protected void RegisterChildrenInfo()
        {
            RepresentationInfo_Children_Set info = new RepresentationInfo_Children_Set(this);

            GetEngine().IfNotNull(e => e.AddChildrenInfo(info));
            children_infos.Add(info);
        }

        protected void RegisterAttributeInfo(string name)
        {
            RepresentationInfo_Attribute_Set info = new RepresentationInfo_Attribute_Set(name, this);

            GetEngine().IfNotNull(e => e.AddAttributeInfo(info));
            attribute_infos.Add(info);
        }

        public RepresentationInfo_Set(Type r) : base(r)
        {
            children_infos = new List<RepresentationInfo_Children_Set>();
            attribute_infos = new List<RepresentationInfo_Attribute_Set>();
        }

        public override void Initilize(RepresentationEngine e)
        {
            base.Initilize(e);

            children_infos.Process(i => e.AddChildrenInfo(i));
            attribute_infos.Process(i => e.AddAttributeInfo(i));
        }
    }
}