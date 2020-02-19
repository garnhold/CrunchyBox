
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

        public CmlContext_Child(CmlContext p)
        {
            parent_context = p;
        }

        public override void AddVariableLink(string group, VariableLink variable_link)
        {
            parent_context.AddVariableLink(group, variable_link);
        }

        public override void AddEffigyLink(string group, EffigyLink effigy_link)
        {
            parent_context.AddEffigyLink(group, effigy_link);
        }

        public override void AddFunctionSyncro(FunctionSyncro function_syncro)
        {
            parent_context.AddFunctionSyncro(function_syncro);
        }

        public override CmlClass GetClass()
        {
            return parent_context.GetClass();
        }

        public override CmlSetSpace GetSetSpace()
        {
            return parent_context.GetSetSpace();
        }

        public override CmlReturnSpace GetReturnSpace()
        {
            return parent_context.GetReturnSpace();
        }

        public override CmlParameterSpace GetParameterSpace()
        {
            return parent_context.GetParameterSpace();
        }

        public override CmlRepresentationSpace GetRepresentationSpace()
        {
            return parent_context.GetRepresentationSpace();
        }

        public override CmlTargetInfo GetTargetInfo()
        {
            return parent_context.GetTargetInfo();
        }

        public override LinkManager GetLinkManager()
        {
            return parent_context.GetLinkManager();
        }

        public override SyncroManager GetSyncroManager()
        {
            return parent_context.GetSyncroManager();
        }
	}
	
}
