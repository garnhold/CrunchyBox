using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_Children_Link : RepresentationInfo_Children
    {
        private EffigyInfo_Collection effigy_info;

        public RepresentationInfo_Children_Link(EffigyInfo_Collection e) : base(e.GetRepresentationType())
        {
            effigy_info = e;
        }

        public override void AddRepresentationValue(CmlExecution execution, object representation, object value)
        {
            effigy_info.AddChild(representation, value);
        }

        public override void SetEffigyLink(CmlExecution execution, object representation, VariableInstance variable_instance, EffigyClassInfo @class, string group)
        {
            execution.AddEffigyLink(
                group,
                effigy_info.CreateLink(execution, representation, variable_instance, @class)
            );
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddChildren(this RepresentationEngine item, EffigyInfo_Collection effigy)
        {
            item.AddChildrenInfo(new RepresentationInfo_Children_Link(effigy));
        }
    }
}