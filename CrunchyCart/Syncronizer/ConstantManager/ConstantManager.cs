using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class Syncronizer
    {
        public class ConstantManager
        {
            private List<ConstantSubManager> constant_managers;

            private ConstantSubManager_String string_sub_manager;
            private ConstantSubManager_Type type_sub_manager;
            private ConstantSubManager_EntityMethod entity_method_sub_manager;
            private ConstantSubManager_SystemMethod system_method_sub_manager;

            private Syncronizer syncronizer;

            private T AddSubManager<T>(T sub_manager) where T : ConstantSubManager
            {
                constant_managers.Add(sub_manager);

                sub_manager.SetIndex((byte)constant_managers.GetFinalIndex());
                return sub_manager;
            }
            public ConstantManager(Syncronizer s)
            {
                constant_managers = new List<ConstantSubManager>();

                string_sub_manager = AddSubManager(new ConstantSubManager_String(this));
                type_sub_manager = AddSubManager(new ConstantSubManager_Type(this));
                entity_method_sub_manager = AddSubManager(new ConstantSubManager_EntityMethod(this));
                system_method_sub_manager = AddSubManager(new ConstantSubManager_SystemMethod(this));

                syncronizer = s;
            }

            public void SendFullUpdate(NetworkRecipient recipient)
            {
                constant_managers.Process(m => m.SendFullUpdate(recipient));
            }
            public void ReadFullUpdate(Buffer buffer)
            {
                constant_managers[buffer.ReadByte()].ReadFullUpdate(buffer);
            }

            public void ReadRequest(Buffer buffer)
            {
                constant_managers[buffer.ReadByte()].ReadRequest(buffer);
            }

            public void ReadUpdate(Buffer buffer)
            {
                constant_managers[buffer.ReadByte()].ReadUpdate(buffer);
            }

            public ConstantSubManager_String GetStringSubManager()
            {
                return string_sub_manager;
            }

            public ConstantSubManager_Type GetTypeSubManager()
            {
                return type_sub_manager;
            }

            public ConstantSubManager_EntityMethod GetEntityMethodSubManager()
            {
                return entity_method_sub_manager;
            }

            public ConstantSubManager_SystemMethod GetSystemMethodSubManager()
            {
                return system_method_sub_manager;
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