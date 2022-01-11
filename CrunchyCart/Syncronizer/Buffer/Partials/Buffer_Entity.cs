using System;
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
        public partial class Buffer
        {
            public Entity ReadEntityReference()
            {
                return syncronizer.entity_manager.ReadEntityReference(this);
            }
            public Entity WriteEntityReference(Entity entity)
            {
                syncronizer.entity_manager.WriteEntityReference(this, entity);

                return entity;
            }

            public object ReadReference()
            {
                return ReadEntityReference().IfNotNull(o => o.GetTarget());
            }
            public void WriteReference(object obj)
            {
                WriteEntityReference(syncronizer.entity_manager.ReferenceObject(obj));
            }

            public EntityMethod ReadEntityMethod()
            {
                return syncronizer.constant_manager.GetEntityMethodSubManager().ReadConstantReference(this);
            }
            public void WriteEntityMethod(EntityMethod method)
            {
                syncronizer.constant_manager.GetEntityMethodSubManager().WriteConstantReference(method, this);
            }
        }
    }
}