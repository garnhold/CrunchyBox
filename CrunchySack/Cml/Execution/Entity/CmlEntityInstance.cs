//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00


namespace Crunchy.Sack
{
    using Dough;

    public abstract class CmlEntityInstance
    {
        private CmlEntity entity;

        protected abstract object SolidifyInternal(CmlExecution execution, CmlContainer container);

        public CmlEntityInstance(CmlEntity e)
        {
            entity = e;
        }

        public void SolidifyInto(CmlExecution execution, CmlContainer container)
        {
            CmlCallContext context = execution.GetCallContext();

            object representation = null;
            object mount_point = SolidifyInternal(execution, container.PiggyBack(delegate(CmlExecution inner_execution, CmlValue value) {
                representation = value.ForceSystemValue();

                context.GetRepresentationSpace().PushRepresentation(entity, representation);
            }));

            entity.GetChildren().IfNotNull(c => c.InitializeRepresentation(execution, mount_point));
            entity.GetMountPoint().IfNotNull(m => context.GetReturnSpace().IfNotNull(s => s.LogSystemValueReturn(execution, "MOUNT_POINT", mount_point)));
            entity.GetCompositeChild().IfNotNull(c => c.InitializeRepresentation(execution, mount_point));

            context.GetRepresentationSpace().PopRepresentation(representation);
        }

        public CmlEntity GetEntity()
        {
            return entity;
        }
    }

}
