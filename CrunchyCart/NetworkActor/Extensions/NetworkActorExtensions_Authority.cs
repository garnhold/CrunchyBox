using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    static public class NetworkActorExtensions_Authority
    {
        static public bool IsAuthority(this NetworkActor item, Syncronizer.Authority authority)
        {
            if (authority.IsAuthority(item))
                return true;

            return false;
        }
    }
}