using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigyInfo_Collection_ReOrg_Process : EffigyInfo_Collection_ReOrg
    {
        private Process<object> clear_process;
        private Process<object, object> add_process;

        private Operation<IEnumerable<object>, object> get_operation;

        public EffigyInfo_Collection_ReOrg_Process(Type r, Type c, Process<object> cp, Process<object, object> ap, Operation<IEnumerable<object>, object> go) : base(r, c)
        {
            clear_process = cp;
            add_process = ap;

            get_operation = go;
        }

        public override void ClearChildren(object representation)
        {
            clear_process(representation);
        }

        public override void AddChild(object representation, object child)
        {
            add_process(representation, child);
        }

        public override IEnumerable<object> GetChildren(object representation)
        {
            return get_operation(representation);
        }
    }

    public class EffigyInfo_Collection_ReOrg_Process<REPRESENTATION_TYPE, CHILD_TYPE> : EffigyInfo_Collection_ReOrg_Process
    {
        public EffigyInfo_Collection_ReOrg_Process(Process<REPRESENTATION_TYPE> cp, Process<REPRESENTATION_TYPE, CHILD_TYPE> ap, Operation<IEnumerable<CHILD_TYPE>, REPRESENTATION_TYPE> go)
            : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE),
                  r => cp((REPRESENTATION_TYPE)r),
                  (r, c) => ap((REPRESENTATION_TYPE)r, (CHILD_TYPE)c),
                  r => go((REPRESENTATION_TYPE)r).Convert<CHILD_TYPE, object>()
            ) { }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddChildren<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Process<REPRESENTATION_TYPE> c, Process<REPRESENTATION_TYPE, CHILD_TYPE> a, Operation<IEnumerable<CHILD_TYPE>, REPRESENTATION_TYPE> g)
        {
            item.AddChildren(
                new EffigyInfo_Collection_ReOrg_Process<REPRESENTATION_TYPE, CHILD_TYPE>(c, a, g)
            );
        }

        static public void AddAttributeChildren<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE> c, Process<REPRESENTATION_TYPE, CHILD_TYPE> a, Operation<IEnumerable<CHILD_TYPE>, REPRESENTATION_TYPE> g)
        {
            item.AddAttributeChildren(n,
                new EffigyInfo_Collection_ReOrg_Process<REPRESENTATION_TYPE, CHILD_TYPE>(c, a, g)
            );
        }
    }
}