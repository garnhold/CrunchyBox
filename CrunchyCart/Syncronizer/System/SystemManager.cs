using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public partial class Syncronizer
    {
        public class SystemManager
        {
            private Dictionary<int, System> systems_by_id;
            private Dictionary<object, System> systems_by_target;

            private Syncronizer syncronizer;

            public SystemManager(Syncronizer s, IEnumerable<object> ts)
            {
                systems_by_id = ts.ConvertWithIndex((i, t) => new System(i + 1, t, this))
                    .ToDictionaryValues(z => z.GetId());

                systems_by_target = systems_by_id.Values
                    .ToDictionaryValues(z => z.GetTarget());

                syncronizer = s;
            }

            public void ReadMethodInvoke(Buffer buffer)
            {
                buffer.ReadSystemReference().ReadMethodInvoke(buffer);
            }

            public System ReadSystemReference(Buffer buffer)
            {
                int id = buffer.ReadInt32();

                if (id == 0)
                    return null;

                return systems_by_id.GetValue(id);
            }
            public void WriteSystemReference(Buffer buffer, System system)
            {
                buffer.WriteInt32(system.IfNotNull(s => s.GetId(), 0));
            }

            public System ReferenceObject(object obj)
            {
                return systems_by_target.GetValue(obj);
            }

            public Syncronizer GetSyncronizer()
            {
                return syncronizer;
            }

            public NetworkActor GetNetworkActor()
            {
                return GetSyncronizer().GetNetworkActor();
            }
        }
    }
}