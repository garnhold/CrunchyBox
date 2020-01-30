using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Attribute_Link_Process<REPRESENTATION_TYPE> : RepresentationInfo_Attribute_Link
    {
        public RepresentationInfo_Attribute_Link_Process(string n, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
            : base(n,
                new Variable_Blockable<REPRESENTATION_TYPE>(v, i)
            )
        {
        }

        public RepresentationInfo_Attribute_Link_Process(Variable v, Operation<bool, REPRESENTATION_TYPE> i) : this(v.GetVariableName(), v, i) { }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddAttributeLink<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddAttributeInfo(
                new RepresentationInfo_Attribute_Link_Process<REPRESENTATION_TYPE>(n, v, i)
            );
        }

        static public void AddAttributeLink<REPRESENTATION_TYPE>(this RepresentationEngine item, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddAttributeInfo(
                new RepresentationInfo_Attribute_Link_Process<REPRESENTATION_TYPE>(v, i)
            );
        }
    }

    public class RepresentationInfo_Attribute_Link_Process<REPRESENTATION_TYPE, VALUE_TYPE> : RepresentationInfo_Attribute_Link
    {
        public RepresentationInfo_Attribute_Link_Process(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r, Operation<bool, REPRESENTATION_TYPE> i)
            : base(n,
                new Variable_Blockable<REPRESENTATION_TYPE>(
                    new Variable_Operation<REPRESENTATION_TYPE, VALUE_TYPE>("RepresentationOperation", a, r), i
                )
            )
        {
        }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddAttributeInfo(
                new RepresentationInfo_Attribute_Link_Process<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r, i)
            );
        }
    }
}