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
    public partial class Syncronizer
    {
        public class Authority_Server : Authority
        {
            static public readonly Authority_Server INSTANCE = new Authority_Server();

            private Authority_Server() { }

            public override bool IsAuthority(NetworkActor to_check)
            {
                if (to_check.IsServer())
                    return true;

                return false;
            }
        }
    }
}