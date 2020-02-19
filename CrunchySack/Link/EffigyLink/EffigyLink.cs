using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyLink
    {
        private CmlTargetInfo target_info;

        private SyncroManager syncro_manager;
        private Dictionary<object, LinkManager> link_managers;

        private EffigySource effigy_source;
        private EffigyDestination effigy_destination;

        private EffigyClassInfo class_info;

        protected abstract void UpdateInternal();

        public void Update()
        {
            link_managers.Values.Process(m => m.UpdateAll());

            UpdateInternal();
        }

        public void UpdateInner(string group)
        {
            link_managers.Values.Process(m => m.Update(group));
        }

        public EffigyLink(CmlContext context, EffigySource s, EffigyDestination d, EffigyClassInfo c)
        {
            target_info = context.GetTargetInfo();

            syncro_manager = context.GetSyncroManager();
            link_managers = new Dictionary<object, LinkManager>();

            effigy_source = s;
            effigy_destination = d;

            class_info = c;
        }

        public void UnlinkValue(object value)
        {
            link_managers.Remove(value);
        }

        public void CreateRepresentationInto(object value, CmlContainer container)
        {
            CmlContext_Base context = new CmlContext_Base(
                target_info.CreateChild(value),
                link_managers.AddAndGet(value, new LinkManager()),
                syncro_manager
            );

            class_info.AssertGetClass(context).SolidifyInto(context, container);
        }

        public IEnumerable<object> GetValues()
        {
            return effigy_source.GetValues();
        }
    }
}