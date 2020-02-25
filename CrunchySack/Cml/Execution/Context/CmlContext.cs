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
        public abstract CmlClass GetClass();
        public abstract CmlUnitSpace GetUnitSpace();
        public abstract CmlFragmentSpace GetFragmentSpace();
        public abstract CmlRepresentationSpace GetRepresentationSpace();

        public abstract CmlTargetInfo GetTargetInfo();
        public abstract LinkManager GetLinkManager();
        public abstract SyncroManager GetSyncroManager();
        public abstract DeferredProcessList GetDeferredProcessList();
	}
	
}
