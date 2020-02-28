using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_StaticChildren : RepresentationInfo
    {
        private StaticEffigyInfo static_effigy_info;

        private bool PushToRepresentationInternal(CmlValue_SystemValue value, object representation, CmlContext context)
        {
            static_effigy_info.AddChild(representation, value.GetSystemValue());

            return true;
        }

        private bool PushToRepresentationInternal(CmlValue_SystemValues value, object representation, CmlContext context)
        {
            static_effigy_info.AddChildren(representation, value.GetSystemValues());

            return true;
        }

        public RepresentationInfo_StaticChildren(string n, StaticEffigyInfo e) : base(n, e.GetRepresentationType())
        {
            static_effigy_info = e;
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddStaticChildrenInfo(this RepresentationEngine item, string n, StaticEffigyInfo effigy)
        {
            item.AddInfo(new RepresentationInfo_StaticChildren(n, effigy));
        }
    }
}