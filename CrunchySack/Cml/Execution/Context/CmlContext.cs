
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

    public abstract class CmlContext
	{
        public abstract void AddVariableLink(string group, VariableLink variable_link);
        public abstract void AddEffigyLink(string group, EffigyLink effigy_link);
        public abstract void AddFunctionSyncro(FunctionSyncro function_syncro);

        public abstract CmlClass GetClass();
        public abstract CmlSetSpace GetSetSpace();
        public abstract CmlReturnSpace GetReturnSpace();
        public abstract CmlParameterSpace GetParameterSpace();
        public abstract CmlRepresentationSpace GetRepresentationSpace();

        public abstract CmlTargetInfo GetTargetInfo();
        public abstract LinkManager GetLinkManager();
        public abstract SyncroManager GetSyncroManager();
	}
	
}
