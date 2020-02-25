using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class CmlContext_Base : CmlContext
    {
        private CmlTargetInfo target_info;
        
        private LinkManager link_manager;
        private SyncroManager syncro_manager;

        private DeferredProcessList deferred_process_list;

        public CmlContext_Base(CmlTargetInfo t, LinkManager l, SyncroManager s)
        {
            target_info = t;
            
            link_manager = l;
            syncro_manager = s;

            deferred_process_list = new DeferredProcessList();
        }

        public CmlContext_Base(CmlTargetInfo t) : this(t, new LinkManager(), new SyncroManager()) { }

        public override void Complete()
        {
            deferred_process_list.ProcessDeferred();
        }

        public override CmlClass GetClass()
        {
            return null;
        }

        public override CmlUnitSpace GetUnitSpace()
        {
            return null;
        }

        public override CmlFragmentSpace GetFragmentSpace()
        {
            return null;
        }

        public override CmlRepresentationSpace GetRepresentationSpace()
        {
            return null;
        }

        public override CmlTargetInfo GetTargetInfo()
        {
            return target_info;
        }

        public override LinkManager GetLinkManager()
        {
            return link_manager;
        }

        public override SyncroManager GetSyncroManager()
        {
            return syncro_manager;
        }

        public override DeferredProcessList GetDeferredProcessList()
        {
            return deferred_process_list;
        }
    }
}