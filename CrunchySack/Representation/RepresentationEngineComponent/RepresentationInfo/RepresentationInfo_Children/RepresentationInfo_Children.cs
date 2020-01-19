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
        static public void AddChildren<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE> c, Process<REPRESENTATION_TYPE, CHILD_TYPE> a)
        {
            item.AddChildrenInfo(
                new RepresentationInfo_Children(
                    new EffigyInfo_Collection_Flush_Process<REPRESENTATION_TYPE, CHILD_TYPE>(c, a)
                )
            );
        }

        static public void AddChildren<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> s)
        {
            item.AddChildrenInfo(
                new RepresentationInfo_Children(
                    new EffigyInfo_Collection_Flush_Overwrite_Process<REPRESENTATION_TYPE, CHILD_TYPE>(s)
                )
            );
        }

        static public void AddChildren<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Operation<IList<CHILD_TYPE>, REPRESENTATION_TYPE> o)
        {
            item.AddChildrenInfo(
                new RepresentationInfo_Children(
                    new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE, CHILD_TYPE>(o)
                )
            );
        }

        static public void AddChildren<REPRESENTATION_TYPE>(this RepresentationEngine item, Operation<IList, REPRESENTATION_TYPE> o)
        {
            item.AddChildrenInfo(
                new RepresentationInfo_Children(
                    new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE>(o)
                )
            );
        }
    }
}