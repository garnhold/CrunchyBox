using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    static public class NetworkActorExtensions_Cede
    {
        static public NetworkActor CedeAuthority(this NetworkActor item, NetworkActor successor, out LocalAuthorityState state)
        {
            if (item.IsLocal())
            {
                if (successor.IsLocal())
                    state = LocalAuthorityState.RetainedAuthority;
                else
                    state = LocalAuthorityState.LosedAuthority;
            }
            else
            {
                if (successor.IsLocal())
                    state = LocalAuthorityState.GainedAuthority;
                else
                    state = LocalAuthorityState.MaintainedNoAuthority;
            }

            return successor;
        }
    }
}