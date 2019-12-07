using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE, CHILD_TYPE> : EffigyInfo_Collection_IslandMorph
    {
        private Operation<IList<CHILD_TYPE>, REPRESENTATION_TYPE> operation;

        public EffigyInfo_Collection_IslandMorph_IList(Operation<IList<CHILD_TYPE>, REPRESENTATION_TYPE> o) : base(typeof(REPRESENTATION_TYPE), typeof(CHILD_TYPE))
        {
            operation = o;
        }

        public override void RemoveChildAt(object representation, int index)
        {
            operation((REPRESENTATION_TYPE)representation).RemoveAt(index);
        }

        public override void AddChild(object representation, object child)
        {
            operation((REPRESENTATION_TYPE)representation).Add((CHILD_TYPE)child);
        }

        public override void InsertChild(object representation, int index, object child)
        {
            operation((REPRESENTATION_TYPE)representation).Insert(index, (CHILD_TYPE)child);
        }
    }

    public class EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE> : EffigyInfo_Collection_IslandMorph
    {
        private Operation<IList, REPRESENTATION_TYPE> operation;

        public EffigyInfo_Collection_IslandMorph_IList(Operation<IList, REPRESENTATION_TYPE> o) : base(typeof(REPRESENTATION_TYPE), typeof(object))
        {
            operation = o;
        }

        public override void RemoveChildAt(object representation, int index)
        {
            operation((REPRESENTATION_TYPE)representation).RemoveAt(index);
        }

        public override void AddChild(object representation, object child)
        {
            operation((REPRESENTATION_TYPE)representation).Add(child);
        }

        public override void InsertChild(object representation, int index, object child)
        {
            operation((REPRESENTATION_TYPE)representation).Insert(index, child);
        }
    }
}