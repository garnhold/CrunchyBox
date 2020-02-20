using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    
    public class RepresentationResult
    {
        private object representation;

        private LinkManager link_manager;
        private SyncroManager syncro_manager;

        public RepresentationResult(object r, CmlContext c)
        {
            representation = r;

            link_manager = c.GetLinkManager();
            syncro_manager = c.GetSyncroManager();
        }

        public object GetRepresentation()
        {
            return representation;
        }

        public LinkManager GetLinkManager()
        {
            return link_manager;
        }

        public SyncroManager GetSyncroManager()
        {
            return syncro_manager;
        }
    }
}