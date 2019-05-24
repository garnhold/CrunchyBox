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
    public struct NetworkActor
    {
        private long id;

        private bool is_local;
        private bool is_server;

        static public bool operator ==(NetworkActor a1, NetworkActor a2) { return a1.EqualsEX(a2); }
        static public bool operator !=(NetworkActor a1, NetworkActor a2) { return a1.NotEqualsEX(a2); }

        public NetworkActor(long i, bool l, bool s)
        {
            id = i;

            is_local = l;
            is_server = s;
        }

        public long GetId()
        {
            return id;
        }

        public bool IsLocal()
        {
            return is_local;
        }

        public bool IsServer()
        {
            return is_server;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + id.GetHashCodeEX();
                hash = hash * 23 + is_local.GetHashCodeEX();
                hash = hash * 23 + is_server.GetHashCodeEX();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            NetworkActor cast;

            if (obj.Convert<NetworkActor>(out cast))
            {
                if (cast.id == id)
                {
                    if (cast.is_local == is_local)
                    {
                        if (cast.is_server == is_server)
                            return true;
                    }
                }
            }

            return false;
        }
    }
}