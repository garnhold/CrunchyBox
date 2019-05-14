using System;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class RepresentationInfo_Attribute_Value : RepresentationInfo_Attribute
    {
        public RepresentationInfo_Attribute_Value(string n, Type r) : base(n, r) { }
    }
}