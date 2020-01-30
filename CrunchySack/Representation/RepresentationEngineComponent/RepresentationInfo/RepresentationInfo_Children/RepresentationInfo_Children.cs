using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_Children : RepresentationInfo
    {
        private EffigyInfo_Collection effigy_info;

        public RepresentationInfo_Children(EffigyInfo_Collection e)
        {
            effigy_info = e;
        }

        public override Type GetRepresentationType()
        {
            return effigy_info.GetRepresentationType();
        }

        public EffigyInfo_Collection GetEffigyInfo()
        {
            return effigy_info;
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddChildren(this RepresentationEngine item, EffigyInfo_Collection effigy)
        {
            item.AddChildrenInfo(new RepresentationInfo_Children(effigy));
        }
    }
}