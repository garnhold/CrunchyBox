using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class RepresentationInfo_Value : RepresentationInfo
    {
        public RepresentationInfo_Value(string n, Type r) : base(n, r) { }
    }
}