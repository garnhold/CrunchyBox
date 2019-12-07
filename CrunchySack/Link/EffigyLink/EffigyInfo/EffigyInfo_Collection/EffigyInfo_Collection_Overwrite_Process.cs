using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigyInfo_Collection_Overwrite_Process : EffigyInfo_Collection_Overwrite
    {
        private Process<object> clear_process;
        private Process<object, object> add_process;

        public EffigyInfo_Collection_Overwrite_Process(Type r, Type c, Process<object> cp, Process<object, object> ap) : base(r, c)
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

    public class EffigyInfo_Collection_Overwrite_Process<REPRESENTATION_TYPE, CHILD_TYPE> : EffigyInfo_Collection_Overwrite_Process
    {
        public EffigyInfo_Collection_Overwrite_Process(Process<REPRESENTATION_TYPE> cp, Process<REPRESENTATION_TYPE, CHILD_TYPE> ap)
            : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE),
                r => cp((REPRESENTATION_TYPE)r),
                (r, c) => ap((REPRESENTATION_TYPE)r, (CHILD_TYPE)c)
            )
        { }
    }
}