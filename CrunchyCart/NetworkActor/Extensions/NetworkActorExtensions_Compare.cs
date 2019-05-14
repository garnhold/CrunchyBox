using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    static public class NetworkActorExtensions_Compare
    {
        static public bool IsClient(this NetworkActor item)
        {
            if (item.IsServer() == false)
                return true;

            return false;
        }

        static public bool IsRemote(this NetworkActor item)
        {
            if (item.IsLocal() == false)
                return true;

            return false;
        }
    }
}