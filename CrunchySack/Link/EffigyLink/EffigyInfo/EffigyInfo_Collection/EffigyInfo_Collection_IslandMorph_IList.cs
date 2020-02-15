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
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Operation<IList<CHILD_TYPE>, REPRESENTATION_TYPE> o)
        {
            item.AddChildrenInfo(n,
                new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE, CHILD_TYPE>(o)
            );
        }
        static public void AddChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Operation<IList<CHILD_TYPE>, REPRESENTATION_TYPE> o)
        {
            item.AddChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, o);
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
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddChildrenInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, Operation<IList, REPRESENTATION_TYPE> o)
        {
            item.AddChildrenInfo(n, 
                new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE>(o)
            );
        }
        static public void AddChildrenInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, Operation<IList, REPRESENTATION_TYPE> o)
        {
            item.AddChildrenInfo<REPRESENTATION_TYPE>(RepresentationInfo.UnamedChildren, o);
        }

        static public RepresentationInfoSet_SelectableChildren AddSelectableChildrenInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, Operation<IList, REPRESENTATION_TYPE> o)
        {
            return item.AddSelectableChildrenInfo(n,
                new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE>(o)
            );
        }
        static public RepresentationInfoSet_SelectableChildren AddSelectableChildrenInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, Operation<IList, REPRESENTATION_TYPE> o)
        {
            return item.AddSelectableChildrenInfo(RepresentationInfo.UnamedChildren, o);
        }
    }
}