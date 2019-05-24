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
        public class EntityManager
        {
            private int next_entity_id;

            private Dictionary<int, Entity> entitys_by_id;
            private Dictionary<object, Entity> entitys_by_target;

            private Syncronizer syncronizer;

            public event MultiProcess<Entity> OnGainAuthority;
            public event MultiProcess<Entity> OnLoseAuthority;

            public EntityManager(Syncronizer s)
            {
                next_entity_id = 1;

                entitys_by_id = new Dictionary<int, Entity>();
                entitys_by_target = new Dictionary<object, Entity>();

                syncronizer = s;
            }

            public void Update()
            {
                entitys_by_id.Values.Process(e => e.Update());
            }

            public Entity RegisterEntityTarget(int id, object target, System constructor_system, SystemMethod_Constructor constructor, object[] constructor_arguments)
            {
                Entity entity = new Entity(id, target, constructor_system, constructor, constructor_arguments, this);

                entitys_by_id.Add(entity.GetId(), entity);
                entitys_by_target.Add(entity.GetTarget(), entity);

                return entity;
            }
            public Entity RegisterEntityTarget(object target, System constructor_system, SystemMethod_Constructor constructor, object[] constructor_arguments)
            {
                return RegisterEntityTarget(next_entity_id++, target, constructor_system, constructor, constructor_arguments);
            }

            public void UnregisterEntity(Entity entity)
            {
                entitys_by_id.Remove(entity.GetId());
                entitys_by_target.Remove(entity.GetTarget());
            }

            public void NotifyGainedAuthority(Entity entity)
            {
                OnGainAuthority.InvokeAll(entity);
            }
            public void NotifyLosedAuthority(Entity entity)
            {
                OnLoseAuthority.InvokeAll(entity);
            }

            public void ReadMethodInvoke(Buffer buffer)
            {
                buffer.ReadEntityReference().ReadMethodInvoke(buffer);
            }

            public void ReadAuthority(Buffer buffer)
            {
                buffer.ReadEntityReference().ReadAuthority(buffer);
            }

            public void ReadDestroy(Buffer buffer)
            {
                buffer.ReadEntityReference().ReadDestroy(buffer);
            }

            public void ReadUpdate(Buffer buffer)
            {
                buffer.ReadEntityReference().ReadUpdate(buffer);
            }

            public void InitializeRecipient(NetworkRecipient recipient)
            {
                if (GetNetworkActor().IsServer())
                    entitys_by_id.Values.Process(e => e.SendConstructReplay(recipient));
            }

            public Entity ReadEntityReference(Buffer buffer)
            {
                int id = buffer.ReadInt32();

                if (id == 0)
                    return null;

                Entity entity;
                if (entitys_by_id.TryGetValue(id, out entity))
                    return entity;

                throw new BufferDefermentException_MissingEntity(id, this);
            }
            public void WriteEntityReference(Buffer buffer, Entity entity)
            {
                buffer.WriteInt32(entity.IfNotNull(e => e.GetId(), 0));
            }

            public Entity ReferenceObject(object obj)
            {
                return entitys_by_target.GetValue(obj);
            }

            public bool TryDereferenceEntity(int id, out Entity entity)
            {
                return entitys_by_id.TryGetValue(id, out entity);
            }
            public bool CanDereferenceEntity(int id)
            {
                if (entitys_by_id.ContainsKey(id))
                    return true;

                return false;
            }

            public IEnumerable<Entity> GetEntitys()
            {
                return entitys_by_id.Values;
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