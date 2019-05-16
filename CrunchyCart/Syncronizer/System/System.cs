using System;
using System.Reflection;
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
        public class System
        {
            private int id;
            private object target;

            private SystemManager manager;

            public System(int i, object t, SystemManager m)
            {
                id = i;
                target = t;

                manager = m;
            }

            public void ReadMethodInvoke(Buffer buffer)
            {
                if (buffer.GetSender().IsServer())
                    buffer.ReadSystemMethod().ReadMethodInvoke(this, buffer);
            }

            public int GetId()
            {
                return id;
            }

            public object GetTarget()
            {
                return target;
            }

            public SystemManager GetManager()
            {
                return manager;
            }

            public Syncronizer GetSyncronizer()
            {
                return GetManager().GetSyncronizer();
            }

            public NetworkActor GetNetworkActor()
            {
                return GetSyncronizer().GetNetworkActor();
            }
        }
    }
}