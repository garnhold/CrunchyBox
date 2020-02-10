using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfo_Set : RepresentationInfo
    {
        private bool does_include_children;
        private List<string> attribute_names;

        private Type representation_type;

        public RepresentationInfo_Set(bool dic, IEnumerable<string> an, Type r)
        {
            does_include_children = dic;
            attribute_names = an.ToList();

            representation_type = r;
        }

        public bool DoesIncludeChildren()
        {
            return does_include_children;
        }

        public IEnumerable<string> GetAttributeNames()
        {
            return attribute_names;
        }

        public override Type GetRepresentationType()
        {
            return representation_type;
        }
    }
}