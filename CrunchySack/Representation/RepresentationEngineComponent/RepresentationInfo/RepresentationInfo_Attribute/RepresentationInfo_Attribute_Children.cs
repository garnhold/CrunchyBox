using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Attribute_Children : RepresentationInfo_Attribute
    {
        private EffigyInfo effigy_info;

        public RepresentationInfo_Attribute_Children(string n, EffigyInfo i) : base(n, i.GetRepresentationType())
        {
            effigy_info = i;
        }

        public override EffigyInfo GetRepresentationEffigyInfo()
        {
            return effigy_info;
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddAttributeChildren<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE> c, Process<REPRESENTATION_TYPE, CHILD_TYPE> a)
        {
            item.AddAttributeInfo(
                new RepresentationInfo_Attribute_Children(n,
                    new EffigyInfo_Collection_Flush_Process<REPRESENTATION_TYPE, CHILD_TYPE>(c, a)
                )
            );
        }

        static public void AddAttributeChildren<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, IEnumerable<CHILD_TYPE>> s)
        {
            item.AddAttributeInfo(
                new RepresentationInfo_Attribute_Children(n,
                    new EffigyInfo_Collection_Flush_Overwrite_Process<REPRESENTATION_TYPE, CHILD_TYPE>(s)
                )
            );
        }

        static public void AddAttributeChildren<REPRESENTATION_TYPE, CHILD_TYPE>(this RepresentationEngine item, string n, Operation<IList<CHILD_TYPE>, REPRESENTATION_TYPE> o)
        {
            item.AddAttributeInfo(
                new RepresentationInfo_Attribute_Children(n,
                    new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE, CHILD_TYPE>(o)
                )
            );
        }

        static public void AddAttributeChildren<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, Operation<IList, REPRESENTATION_TYPE> o)
        {
            item.AddAttributeInfo(
                new RepresentationInfo_Attribute_Children(n,
                    new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE>(o)
                )
            );
        }
    }
}