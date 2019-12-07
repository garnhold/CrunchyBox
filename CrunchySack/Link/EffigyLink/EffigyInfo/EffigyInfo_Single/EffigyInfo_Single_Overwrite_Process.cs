using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigyInfo_Single_Overwrite_Process : EffigyInfo_Single_Overwrite
    {
        private Process<object, object> set_process;

        public EffigyInfo_Single_Overwrite_Process(Type r, Type c, Process<object, object> s) : base(r, c)
        {
            set_process = s;
        }

        public override void SetChild(object representation, object child)
        {
            set_process(representation, child);
        }
    }

    public class EffigyInfo_Single_Overwrite_Process<REPRESENTATION_TYPE, CHILD_TYPE> : EffigyInfo_Single_Overwrite_Process
    {
        public EffigyInfo_Single_Overwrite_Process(Process<REPRESENTATION_TYPE, CHILD_TYPE> sp)
            : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE),
                (r, c) => sp((REPRESENTATION_TYPE)r, (CHILD_TYPE)c)
            )
        { }
    }
}