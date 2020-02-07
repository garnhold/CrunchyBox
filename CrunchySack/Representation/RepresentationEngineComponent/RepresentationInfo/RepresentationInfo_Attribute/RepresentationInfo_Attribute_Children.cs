using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Attribute_Children : RepresentationInfo_Attribute
    {
        private EffigyInfo effigy_info;

        public RepresentationInfo_Attribute_Children(string n, EffigyInfo i) : base(n, i.GetRepresentationType())
        {
            effigy_info = i;
        }

        public override void AddRepresentationValue(CmlExecution execution, object representation, object value)
        {
            effigy_info.AddChild(representation, value);
        }

        public override EffigyLink CreateEffigyLink(CmlExecution execution, object representation, VariableInstance variable_instance, EffigyClassInfo @class)
        {
            return effigy_info.CreateLink(execution, representation, variable_instance, @class);
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddAttributeChildren(this RepresentationEngine item, string n, EffigyInfo effigy)
        {
            item.AddAttributeInfo(new RepresentationInfo_Attribute_Children(n, effigy));
        }
    }
}