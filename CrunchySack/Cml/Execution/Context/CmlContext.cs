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
        public abstract CmlEntitySpace GetEntitySpace();
        public abstract CmlParameterSpace GetParameterSpace();
        public abstract CmlRepresentationSpace GetRepresentationSpace();

        public abstract CmlTargetInfo GetTargetInfo();
        public abstract LinkManager GetLinkManager();
        public abstract SyncroManager GetSyncroManager();
	}
	
}
