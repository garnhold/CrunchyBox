using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    static public class ObjectLiaisonExtensions_Validate
    {
        static public bool ValidateEX(this Syncronizer.ObjectLiaison item, Type type)
        {
            if (item != null)
                return item.Validate(type);

            return false;
        }

        static public bool ValidateEX(this Syncronizer.ObjectLiaison item)
        {
            if (item != null)
                return item.Validate();

            return false;
        }
    }
}