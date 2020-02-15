using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigyInfo_Collection_Orderless_Process : EffigyInfo_Collection_Orderless
    {
        private Process<object, object> add_process;
        private Process<object, object> remove_process;

        public EffigyInfo_Collection_Orderless_Process(Type r, Type c, Process<object, object> ap, Process<object, object> rp) : base(r, c)
        {
            add_process = ap;
            remove_process = rp;
        }

        public override void AddChild(object representation, object child)
        {
            add_process(representation, child);
        }

        public override void RemoveChild(object representation, object child)
        {
            remove_process(representation, child);
        }
    }

    public class EffigyInfo_Collection_Orderless_Process<REPRESENTATION_TYPE, CHILD_TYPE> : EffigyInfo_Collection_Orderless_Process
    {
        public EffigyInfo_Collection_Orderless_Process(Process<REPRESENTATION_TYPE, CHILD_TYPE> ap, Process<REPRESENTATION_TYPE, CHILD_TYPE> rp)
            : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE),
                  (r, c) => ap((REPRESENTATION_TYPE)r, (CHILD_TYPE)c),
                  (r, c) => rp((REPRESENTATION_TYPE)r, (CHILD_TYPE)c)
            ) { }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddOrderlessChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, CHILD_TYPE> a, Process<REPRESENTATION_TYPE, CHILD_TYPE> r)
        {
            item.AddChildrenInfo(n,
                new EffigyInfo_Collection_Orderless_Process<REPRESENTATION_TYPE, CHILD_TYPE>(a, r)
            );
        }
        static public void AddOrderlessChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE, CHILD_TYPE> a, Process<REPRESENTATION_TYPE, CHILD_TYPE> r)
        {
            item.AddOrderlessChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, a, r);
        }
    }
}