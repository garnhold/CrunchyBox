
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class CmlEntityInstance
    {
        private CmlEntity entity;

        private object representation;
        private object mount_point;

        protected abstract void SolidifyInternal(CmlExecution execution, CmlContainer container);

        public CmlEntityInstance(CmlEntity e)
        {
            entity = e;
        }

        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            CmlCallContext context = execution.GetCallContext();

            execution.PushPopReturnSpaceNew(delegate(CmlReturnSpace return_space) {
                return_space.RequestSystemValueReturn("MOUNT_POINT", v => mount_point = v);

                SolidifyInternal(execution, container.PiggyBack(delegate(CmlExecution inner_execution, CmlValue value) {
                    representation = value.ForceSystemValue();
                    mount_point = representation;

                    context.GetRepresentationSpace().PushRepresentation(entity, representation);
                }));
            });

            entity.GetChildren().IfNotNull(c => c.InitializeRepresentation(execution, mount_point));
            entity.GetMountPoint().IfNotNull(m => context.GetReturnSpace().IfNotNull(s => s.LogSystemValueReturn(execution, "MOUNT_POINT", representation)));

            context.GetRepresentationSpace().PopRepresentation(representation);
        }

        public CmlEntity GetEntity()
        {
            return entity;
        }

        public object GetRepresentation()
        {
            return representation;
        }

        public object GetMountPoint()
        {
            return mount_point;
        }
    }

}
