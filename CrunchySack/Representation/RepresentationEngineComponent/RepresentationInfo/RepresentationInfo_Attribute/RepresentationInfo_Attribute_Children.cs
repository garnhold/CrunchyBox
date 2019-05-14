using System;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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
}