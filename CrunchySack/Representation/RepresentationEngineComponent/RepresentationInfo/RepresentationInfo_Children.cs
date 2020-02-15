using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_Children : RepresentationInfo
    {
        private EffigyInfo effigy_info;

        public RepresentationInfo_Children(string n, EffigyInfo e) : base(n, e.GetRepresentationType())
        {
            effigy_info = e;
        }

        public override void SetValue(CmlExecution execution, object representation, object value)
        {
            effigy_info.AddChild(representation, value);
        }

        public override void LinkValue(CmlExecution execution, object representation, VariableInstance variable_instance, HasInfo info)
        {
            execution.AddEffigyLink(
                info.GetInfoValue("group"),

                effigy_info.CreateLink(
                    execution,
                    representation,
                    variable_instance,
                    new EffigyClassInfo_Dynamic(info.GetInfoValue("layout"))
                )
            );
        }

        public override void LinkValueWithEntity(CmlExecution execution, object representation, VariableInstance variable_instance, CmlEntity entity, HasInfo info)
        {
            execution.AddEffigyLink(
                info.GetInfoValue("group"),

                effigy_info.CreateLink(
                    execution,
                    representation,
                    variable_instance,
                    new EffigyClassInfo_Static(entity)
                )
            );
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddChildrenInfo(this RepresentationEngine item, string n, EffigyInfo effigy)
        {
            item.AddInfo(new RepresentationInfo_Children(n, effigy));
        }
    }
}