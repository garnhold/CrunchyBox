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
        private Process<object> clear_process;
        private Process<object, object> add_process;

        public EffigyInfo_Collection_Flush_Process(Type r, Type c, Process<object> cp, Process<object, object> ap) : base(r, c)
        {
            clear_process = cp;
            add_process = ap;
        }

        public override void ClearChildren(object representation)
        {
            clear_process(representation);
        }

        public override void AddChild(object representation, object child)
        {
            add_process(representation, child);
        }
    }

    public class EffigyInfo_Collection_Flush_Process<REPRESENTATION_TYPE, CHILD_TYPE> : EffigyInfo_Collection_Flush_Process
    {
        public EffigyInfo_Collection_Flush_Process(Process<REPRESENTATION_TYPE> cp, Process<REPRESENTATION_TYPE, CHILD_TYPE> ap)
            : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE),
                r => cp((REPRESENTATION_TYPE)r),
                (r, c) => ap((REPRESENTATION_TYPE)r, (CHILD_TYPE)c)
            )
        { }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddFlushChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE> c, Process<REPRESENTATION_TYPE, CHILD_TYPE> a)
        {
            item.AddChildrenInfo(n,
                new EffigyInfo_Collection_Flush_Process<REPRESENTATION_TYPE, CHILD_TYPE>(c, a)
            );
        }
        static public void AddFlushChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE> c, Process<REPRESENTATION_TYPE, CHILD_TYPE> a)
        {
            item.AddFlushChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, c, a);
        }

        static public RepresentationInfoSet_SelectableChildren AddFlushSelectableChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE> c, Process<REPRESENTATION_TYPE, CHILD_TYPE> a)
        {
            return item.AddSelectableChildrenInfo(n,
                new EffigyInfo_Collection_Flush_Process<REPRESENTATION_TYPE, CHILD_TYPE>(c, a)
            );
        }
        static public RepresentationInfoSet_SelectableChildren AddFlushSelectableChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE> c, Process<REPRESENTATION_TYPE, CHILD_TYPE> a)
        {
            return item.AddFlushSelectableChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, c, a);
        }
    }
}