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

        private bool PushToRepresentationInternal(CmlValue_SystemValue value, object representation, CmlContext context)
        {
            effigy_info.AddChild(representation, value.GetSystemValue());

            return true;
        }

        private bool PushToRepresentationInternal(CmlValue_Link value, object representation, CmlContext context)
        {
            context.AddEffigyLink(
                value.GetGroup(),

                effigy_info.CreateLink(
                    context,
                    representation,
                    value.GetVariableInstance(),
                    value.GetClass()
                )
            );

            return true;
        }

        public RepresentationInfo_Children(string n, EffigyInfo e) : base(n, e.GetRepresentationType())
        {
            effigy_info = e;
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