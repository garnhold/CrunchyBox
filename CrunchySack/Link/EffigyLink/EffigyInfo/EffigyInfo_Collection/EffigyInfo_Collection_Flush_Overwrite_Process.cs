using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    public class EffigyInfo_Collection_Flush_Overwrite_Process : EffigyInfo_Collection_Flush_Overwrite
    {
        private Process<object, IEnumerable<object>> set_process;

        protected override void SetChildrenInternal(object representation, IEnumerable<object> children)
        {
            set_process(representation, children);
        }

        public EffigyInfo_Collection_Flush_Overwrite_Process(Type r, Type c, Process<object, IEnumerable<object>> sp) : base(r, c)
        {
            set_process = sp;
        }
    }

    public class EffigyInfo_Collection_Flush_Overwrite_Process<REPRESENTATION_TYPE, CHILD_TYPE> : EffigyInfo_Collection_Flush_Overwrite_Process
    {
        public EffigyInfo_Collection_Flush_Overwrite_Process(Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> sp)
            : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE),
                (r, c) => sp((REPRESENTATION_TYPE)r, c.Convert<object, CHILD_TYPE>())
            )
        { }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddFlushChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> s)
        {
            item.AddChildrenInfo(n,
                new EffigyInfo_Collection_Flush_Overwrite_Process<REPRESENTATION_TYPE, CHILD_TYPE>(s)
            );
        }
        static public void AddFlushChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> s)
        {
            item.AddFlushChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, s);
        }

        static public RepresentationInfoSet_SelectableChildren AddFlushSelectableChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> s)
        {
            return item.AddSelectableChildrenInfo(n,
                new EffigyInfo_Collection_Flush_Overwrite_Process<REPRESENTATION_TYPE, CHILD_TYPE>(s)
            );
        }
        static public RepresentationInfoSet_SelectableChildren AddFlushSelectableChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> s)
        {
            return item.AddFlushSelectableChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, s);
        }
    }
}