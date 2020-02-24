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

        public override void SetChildren(object representation, IEnumerable<object> children)
        {
            operation((REPRESENTATION_TYPE)representation).Set(children.Convert<object, CHILD_TYPE>());
        }

        public override void RemoveChildAt(object representation, int index)
        {
            operation((REPRESENTATION_TYPE)representation).RemoveAt(index);
        }

        public override void InsertChild(object representation, int index, object child)
        {
            operation((REPRESENTATION_TYPE)representation).Insert(index, (CHILD_TYPE)child);
        }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddDynamicChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Operation<IList<CHILD_TYPE>, REPRESENTATION_TYPE> o)
        {
            item.AddDynamicChildrenInfo(n,
                new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE, CHILD_TYPE>(o)
            );
        }
        static public void AddDynamicChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, Operation<IList<CHILD_TYPE>, REPRESENTATION_TYPE> o)
        {
            item.AddDynamicChildrenInfo<REPRESENTATION_TYPE, CHILD_TYPE>(RepresentationInfo.UnamedChildren, o);
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

        public override void InsertChild(object representation, int index, object child)
        {
            operation((REPRESENTATION_TYPE)representation).Insert(index, child);
        }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddDynamicChildrenInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, Operation<IList, REPRESENTATION_TYPE> o)
        {
            item.AddDynamicChildrenInfo(n, 
                new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE>(o)
            );
        }
        static public void AddDynamicChildrenInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, Operation<IList, REPRESENTATION_TYPE> o)
        {
            item.AddDynamicChildrenInfo<REPRESENTATION_TYPE>(RepresentationInfo.UnamedChildren, o);
        }

        static public RepresentationInfoSet_SelectableChildren AddSelectableDynamicChildrenInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, Operation<IList, REPRESENTATION_TYPE> o)
        {
            return item.AddSelectableDynamicChildrenInfo(n,
                new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE>(o)
            );
        }
        static public RepresentationInfoSet_SelectableChildren AddSelectableDynamicChildrenInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, Operation<IList, REPRESENTATION_TYPE> o)
        {
            return item.AddSelectableDynamicChildrenInfo(RepresentationInfo.UnamedChildren, o);
        }
    }
}