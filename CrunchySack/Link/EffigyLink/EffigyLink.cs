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

        private EffigyClassInfo class_info;

        protected abstract void UpdateInternal();

        public abstract IEnumerable<object> GetValues();

        public void Update()
        {
            link_managers.Values.Process(m => m.UpdateAll());

            UpdateInternal();
        }

        public void UpdateInner(string group)
        {
            link_managers.Values.Process(m => m.Update(group));
        }

        public EffigyLink(CmlContext context, EffigyClassInfo c)
        {
            target_info = context.GetTargetInfo();

            syncro_manager = context.GetSyncroManager();
            link_managers = new Dictionary<object, LinkManager>();

            class_info = c;
        }

        public void UnlinkValue(object value)
        {
            if (value != null)
                link_managers.Remove(value);
        }

        public object LinkValue(object value)
        {
            if (value != null)
            {
                CmlContext_Base context = new CmlContext_Base(
                    target_info.CreateChild(value),
                    link_managers.AddAndGet(value, new LinkManager()),
                    syncro_manager
                );

                return class_info.AssertGetClass(context).Instance(context);
            }

            return null;
        }
    }
}