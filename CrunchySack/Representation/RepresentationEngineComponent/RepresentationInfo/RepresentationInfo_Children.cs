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

<<<<<<< Updated upstream
        public override void SetValue(CmlExecution execution, object representation, object value)
=======
        public override void SetValue(CmlContext context, object representation, object child)
>>>>>>> Stashed changes
        {
            effigy_info.AddChild(representation, value);
        }

        public override void LinkValue(CmlContext context, object representation, VariableInstance variable_instance, HasInfo info)
        {
            context.AddEffigyLink(
                info.GetInfoValue("group"),

                effigy_info.CreateLink(
                    context,
                    representation,
                    variable_instance,
                    new EffigyClassInfo_Dynamic(info.GetInfoValue("layout"))
                )
            );
        }

        public override void LinkValueWithEntity(CmlContext context, object representation, VariableInstance variable_instance, CmlEntity entity, HasInfo info)
        {
            context.AddEffigyLink(
                info.GetInfoValue("group"),

                effigy_info.CreateLink(
                    context,
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