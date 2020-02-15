using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddAttributeLink<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddAttributeLink(n, new Variable_Blockable<REPRESENTATION_TYPE>(v, i));
        }

        static public void AddAttributeLink<REPRESENTATION_TYPE>(this RepresentationEngine item, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddAttributeLink<REPRESENTATION_TYPE>(v.GetVariableName(), v, i);
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddAttributeLink<REPRESENTATION_TYPE>(
                new Variable_Operation<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r),
                i
            );
        }
    }
}