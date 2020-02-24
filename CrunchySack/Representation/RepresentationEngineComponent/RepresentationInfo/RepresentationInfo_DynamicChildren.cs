using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_DynamicChildren : RepresentationInfo
    {
        private EffigyInfo effigy_info;

        private bool PushToRepresentationInternal(CmlValue_SystemValue value, object representation, CmlContext context)
        {
            effigy_info.SetChildren(representation, value.GetSystemValue().WrapAsEnumerable());

            return true;
        }

        private bool PushToRepresentationInternal(CmlValue_SystemValues value, object representation, CmlContext context)
        {
            effigy_info.SetChildren(representation, value.GetSystemValues());

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

        public RepresentationInfo_DynamicChildren(string n, EffigyInfo e) : base(n, e.GetRepresentationType())
        {
            effigy_info = e;
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddDynamicChildrenInfo(this RepresentationEngine item, string n, EffigyInfo effigy)
        {
            item.AddInfo(new RepresentationInfo_DynamicChildren(n, effigy));
        }
    }
}