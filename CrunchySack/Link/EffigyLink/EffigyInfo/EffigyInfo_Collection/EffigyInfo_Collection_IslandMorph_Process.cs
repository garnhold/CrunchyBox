using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class EffigyInfo_Collection_IslandMorph_Process : EffigyInfo_Collection_IslandMorph
    {
        private Process<object, int> remove_process;

        private Process<object, object> add_process;
        private Process<object, int, object> insert_process;

        public EffigyInfo_Collection_IslandMorph_Process(Type r, Type c, Process<object, int> rp, Process<object, object> ap, Process<object, int, object> ip) : base(r, c)
        {
            remove_process = rp;

            add_process = ap;
            insert_process = ip;
        }

        public override void RemoveChildAt(object representation, int index)
        {
            remove_process(representation, index);
        }

        public override void AddChild(object representation, object child)
        {
            add_process(representation, child);
        }

        public override void InsertChild(object representation, int index, object child)
        {
            insert_process(representation, index, child);
        }
    }

    public class EffigyInfo_Collection_IslandMorph_Process<REPRESENTATION_TYPE, CHILD_TYPE> : EffigyInfo_Collection_IslandMorph_Process
    {
        public EffigyInfo_Collection_IslandMorph_Process(Process<REPRESENTATION_TYPE, int> rp, Process<REPRESENTATION_TYPE, CHILD_TYPE> ap, Process<REPRESENTATION_TYPE, int, CHILD_TYPE> ip)
            : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE),
                (r, i) => rp((REPRESENTATION_TYPE)r, i),
                (r, c) => ap((REPRESENTATION_TYPE)r, (CHILD_TYPE)c),
                (r, i, c) => ip((REPRESENTATION_TYPE)r, i, (CHILD_TYPE)c)
            )
        { }
    }
}