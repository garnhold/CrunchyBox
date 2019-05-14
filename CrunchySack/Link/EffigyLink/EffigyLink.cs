using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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

        public EffigyLink(CmlExecution e, EffigySource s, EffigyDestination d, EffigyClassInfo c)
        {
            target_info = e.GetTargetInfo();

            syncro_manager = e.GetSyncroManager();
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
            CmlExecution execution = new CmlExecution(
                target_info.CreateChild(value),
                link_managers.AddAndGet(value, new LinkManager()),
                syncro_manager
            );

            class_info.AssertGetClass(execution).SolidifyInto(execution, container);
        }
        public void CreateRepresentationInto(object value, Process<object> process)
        {
            CreateRepresentationInto(value, new CmlContainer_EndPoint_SystemValueProcess(process));
        }
    }
}