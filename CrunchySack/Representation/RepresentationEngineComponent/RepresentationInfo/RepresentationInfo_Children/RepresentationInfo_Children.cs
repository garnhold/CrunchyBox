using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_Children : RepresentationInfo
    {
        private EffigyInfo_Collection effigy_info;

        public RepresentationInfo_Children(EffigyInfo_Collection e)
        {
            effigy_info = e;
        }

        public void AddRepresentationValue(CmlExecution execution, object representation, object value)
        {
            effigy_info.AddChild(representation, value);
        }

        public EffigyLink CreateEffigyLink(CmlExecution execution, object representation, VariableInstance variable_instance, EffigyClassInfo @class)
        {
            return effigy_info.CreateLink(execution, representation, variable_instance, @class);
        }

        public override Type GetRepresentationType()
        {
            return effigy_info.GetRepresentationType();
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddChildren(this RepresentationEngine item, EffigyInfo_Collection effigy)
        {
            item.AddChildrenInfo(new RepresentationInfo_Children(effigy));
        }
    }
}