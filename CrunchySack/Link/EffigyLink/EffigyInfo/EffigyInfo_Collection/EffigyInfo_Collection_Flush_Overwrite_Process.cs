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
}