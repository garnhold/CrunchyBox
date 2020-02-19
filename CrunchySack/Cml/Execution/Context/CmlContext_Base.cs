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

        public CmlContext_Base(CmlTargetInfo t, LinkManager l, SyncroManager s)
        {
            target_info = t;
            
            link_manager = l;
            syncro_manager = s;
        }

        public CmlContext_Base(CmlTargetInfo t) : this(t, new LinkManager(), new SyncroManager()) { }

        public override void AddVariableLink(string group, VariableLink variable_link)
        {
            link_manager.AddVariableLink(group, variable_link);
        }

        public override void AddEffigyLink(string group, EffigyLink effigy_link)
        {
            link_manager.AddEffigyLink(group, effigy_link);
        }

        public override void AddFunctionSyncro(FunctionSyncro function_syncro)
        {
            function_syncro.SetManager(syncro_manager);
        }

        public override CmlClass GetClass()
        {
            return null;
        }

        public override CmlSetSpace GetSetSpace()
        {
            return null;
        }

        public override CmlReturnSpace GetReturnSpace()
        {
            return null;
        }

        public override CmlParameterSpace GetParameterSpace()
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
    }
}