
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
        private CmlSetSpace set_space;
        private CmlParameterSpace parameter_space;
        private CmlRepresentationSpace representation_space;

        private CmlTargetInfo target_info;
        private LinkManager link_manager;
        private SyncroManager syncro_manager;

        public CmlContext_Child(CmlContext p)
        {
            parent_context = p;

            @class = parent_context.GetClass();
            set_space = parent_context.GetSetSpace();
            parameter_space = parent_context.GetParameterSpace();
            representation_space = parent_context.GetRepresentationSpace();

            target_info = parent_context.GetTargetInfo();
            link_manager = parent_context.GetLinkManager();
            syncro_manager = parent_context.GetSyncroManager();
        }

        public override CmlClass GetClass()
        {
            return @class;
        }

        public override CmlSetSpace GetSetSpace()
        {
            return set_space;
        }

        public override CmlParameterSpace GetParameterSpace()
        {
            return parameter_space;
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
