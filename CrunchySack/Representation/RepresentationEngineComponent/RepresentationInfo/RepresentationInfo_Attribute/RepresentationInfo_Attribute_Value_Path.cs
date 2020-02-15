using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddAttributeValue<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, string p)
        {
            item.AddAttributeLink(n, typeof(REPRESENTATION_TYPE).GetVariableByPath(p));
        }
    }
}