using System;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class RepresentationInfo_Attribute_Value_Path<REPRESENTATION_TYPE> : RepresentationInfo_Attribute_Value_Variable
    {
        public RepresentationInfo_Attribute_Value_Path(string n, string path) : base(n, typeof(REPRESENTATION_TYPE).GetVariableByPath(path)) { }
    }
}