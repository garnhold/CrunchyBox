using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfos
    {
        static public RepresentationInfo AttributeValue<REPRESENTATION_TYPE, VALUE_TYPE>(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> p)
        {
            return new RepresentationInfo_Attribute_Value_Process<REPRESENTATION_TYPE, VALUE_TYPE>(n, p);
        }

        static public RepresentationInfo AttributeValue(string n, Variable v)
        {
            return new RepresentationInfo_Attribute_Value_Variable(n, v);
        }
        static public RepresentationInfo AttributeValue(Variable v)
        {
            return new RepresentationInfo_Attribute_Value_Variable(v);
        }

        static public RepresentationInfo AttributeValue<REPRESENTATION_TYPE>(string n, string p)
        {
            return new RepresentationInfo_Attribute_Value_Path<REPRESENTATION_TYPE>(n, p);
        }

        static public RepresentationInfo AttributeChildren<REPRESENTATION_TYPE, CHILD_TYPE>(string n, Process<REPRESENTATION_TYPE> c, Process<REPRESENTATION_TYPE, CHILD_TYPE> a)
        {
            return new RepresentationInfo_Attribute_Children(n,
                new EffigyInfo_Collection_Overwrite_Process<REPRESENTATION_TYPE, CHILD_TYPE>(c, a)
            );
        }

        static public RepresentationInfo AttributeChildren<REPRESENTATION_TYPE, CHILD_TYPE>(string n, Operation<IList<CHILD_TYPE>, REPRESENTATION_TYPE> o)
        {
            return new RepresentationInfo_Attribute_Children(n,
                new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE, CHILD_TYPE>(o)
            );
        }

        static public RepresentationInfo AttributeChildren<REPRESENTATION_TYPE>(string n, Operation<IList, REPRESENTATION_TYPE> o)
        {
            return new RepresentationInfo_Attribute_Children(n,
                new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE>(o)
            );
        }

        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r, Operation<bool, REPRESENTATION_TYPE> i)
        {
            return new RepresentationInfo_Attribute_Link_Process<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r, i);
        }

        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE>(string n, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            return new RepresentationInfo_Attribute_Link_Process<REPRESENTATION_TYPE>(n, v, i);
        }
        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE>(Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            return new RepresentationInfo_Attribute_Link_Process<REPRESENTATION_TYPE>(v, i);
        }

        static public RepresentationInfo AttributeLink(string n, Variable v)
        {
            return new RepresentationInfo_Attribute_Link(n, v);
        }
        static public RepresentationInfo AttributeLink(Variable v)
        {
            return new RepresentationInfo_Attribute_Link(v);
        }

        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE>(string n, string p)
        {
            return new RepresentationInfo_Attribute_Link_Path<REPRESENTATION_TYPE>(n, p);
        }

        static public RepresentationInfo AttributeFunction<REPRESENTATION_TYPE>(string n, Process<REPRESENTATION_TYPE, FunctionSyncro> p)
        {
            return new RepresentationInfo_Attribute_Function_Process<REPRESENTATION_TYPE>(n, p);
        }

        static public RepresentationInfo Children<REPRESENTATION_TYPE, CHILD_TYPE>(Process<REPRESENTATION_TYPE> c, Process<REPRESENTATION_TYPE, CHILD_TYPE> a)
        {
            return new RepresentationInfo_Children(
                new EffigyInfo_Collection_Overwrite_Process<REPRESENTATION_TYPE, CHILD_TYPE>(c, a)
            );
        }

        static public RepresentationInfo Children<REPRESENTATION_TYPE, CHILD_TYPE>(Operation<IList<CHILD_TYPE>, REPRESENTATION_TYPE> o)
        {
            return new RepresentationInfo_Children(
                new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE, CHILD_TYPE>(o)
            );
        }

        static public RepresentationInfo Children<REPRESENTATION_TYPE>(Operation<IList, REPRESENTATION_TYPE> o)
        {
            return new RepresentationInfo_Children(
                new EffigyInfo_Collection_IslandMorph_IList<REPRESENTATION_TYPE>(o)
            );
        }
    }
}