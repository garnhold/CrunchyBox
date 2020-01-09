using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    static public class EditTargetExtensions_ForceProperty
    {
        static public EditProperty_Single ForcePropertySingle(this EditTarget item, string path)
        {
            return item.ForceProperty(path)
                .Convert<EditProperty_Single>()
                .AssertNotNull(() => new MissingFieldException("The property for type " + item.GetTargetType() + " at path " + path + " cannot be treated as a single."));
        }

        static public EditProperty_Single_Value ForcePropertyValue(this EditTarget item, string path)
        {
            return item.ForceProperty(path)
                .Convert<EditProperty_Single_Value>()
                .AssertNotNull(() => new MissingFieldException("The property for type " + item.GetTargetType() + " at path " + path + " cannot be treated as a value."));
        }

        static public EditProperty_Single_Object ForcePropertyObject(this EditTarget item, string path)
        {
            return item.ForceProperty(path)
                .Convert<EditProperty_Single_Object>()
                .AssertNotNull(() => new MissingFieldException("The property for type " + item.GetTargetType() + " at path " + path + " cannot be treated as an object."));
        }
    }
}