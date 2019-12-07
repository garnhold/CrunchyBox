using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    static public class ObjectLiaisonExtensions_Validate
    {
        static public bool ValidateEX(this Syncronizer.ObjectLiaison item, object target)
        {
            if (item != null)
                return item.Validate(target);

            return false;
        }
        static public bool ValidateEX(this Syncronizer.ObjectLiaison item, object target, Type desired_type)
        {
            if (item != null)
                return item.Validate(target, desired_type);

            return false;
        }
    }
}