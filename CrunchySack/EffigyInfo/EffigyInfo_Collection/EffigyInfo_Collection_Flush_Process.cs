using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigyInfo_Collection_Flush_Process : EffigyInfo_Collection_Flush
    {
        private Process<object, IEnumerable<object>> set_process;

        public EffigyInfo_Collection_Flush_Process(Type r, Type c, Process<object, IEnumerable<object>> sp) : base(r, c)
        {
            set_process = sp;
        }

        public override void SetChildren(object representation, IEnumerable<object> children)
        {
            set_process(representation, children);
        }
    }

    public class EffigyInfo_Collection_Flush_Process<REPRESENTATION_TYPE, CHILD_TYPE> : EffigyInfo_Collection_Flush_Process
    {
        public EffigyInfo_Collection_Flush_Process(Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> sp)
            : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE),
                (r, c) => sp((REPRESENTATION_TYPE)r, c.Convert<object, CHILD_TYPE>())
            )
        { }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> sp)
        {
            item.AddChildrenInfo(n,
                new EffigyInfo_Collection_Flush_Process<REPRESENTATION_TYPE, CHILD_TYPE>(sp)
            );
        }
        static public void AddChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> sp)
        {
            item.AddChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, sp);
        }

        static public RepresentationInfoSet_SelectableChildren AddSelectableChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> sp)
        {
            return item.AddSelectableChildrenInfo(n,
                new EffigyInfo_Collection_Flush_Process<REPRESENTATION_TYPE, CHILD_TYPE>(sp)
            );
        }
        static public RepresentationInfoSet_SelectableChildren AddSelectableChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> sp)
        {
            return item.AddSelectableChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, sp);
        }
    }
}