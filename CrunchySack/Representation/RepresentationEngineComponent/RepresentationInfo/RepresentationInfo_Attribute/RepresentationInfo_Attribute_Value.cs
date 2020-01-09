using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class RepresentationInfo_Attribute_Value : RepresentationInfo_Attribute
    {
        public RepresentationInfo_Attribute_Value(string n, Type r) : base(n, r) { }
    }
}