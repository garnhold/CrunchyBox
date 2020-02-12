using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfo_Set : RepresentationInfo
    {
        public abstract void SolidifyInstance(CmlExecution execution, object representation, CmlSet set);

        public abstract IEnumerable<RepresentationInfo_Children> GetChildrenInfos();
        public abstract IEnumerable<RepresentationInfo_Attribute> GetAttributeInfos();

        public RepresentationInfo_Set(Type r) : base(r)
        {
        }
    }
}