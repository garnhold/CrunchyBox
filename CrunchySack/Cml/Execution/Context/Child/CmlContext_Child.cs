
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class CmlContext_Child : CmlContext
	{
        private CmlContext parent_context;

        private CmlClass @class;
        private CmlUnitSpace unit_space;
        private CmlFragmentSpace fragment_space;
        private CmlRepresentationSpace representation_space;

        private CmlTargetInfo target_info;
        private LinkManager link_manager;
        private SyncroManager syncro_manager;

        public CmlContext_Child(CmlContext p)
        {
            parent_context = p;

            @class = parent_context.GetClass();
            unit_space = parent_context.GetUnitSpace();
            fragment_space = parent_context.GetFragmentSpace();
            representation_space = parent_context.GetRepresentationSpace();

            target_info = parent_context.GetTargetInfo();
            link_manager = parent_context.GetLinkManager();
            syncro_manager = parent_context.GetSyncroManager();
        }

        public override CmlClass GetClass()
        {
            return @class;
        }

        public override CmlUnitSpace GetUnitSpace()
        {
            return unit_space;
        }

        public override CmlFragmentSpace GetFragmentSpace()
        {
            return fragment_space;
        }

        public override CmlRepresentationSpace GetRepresentationSpace()
        {
            return representation_space;
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
