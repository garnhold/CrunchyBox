using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySack
{
    static public class RepresentationResultExtensions_LinkSyncroDaemon
    {
        static public LinkSyncroDaemon CreateLinkSyncroDaemon<PERIODIC_PROCESS_TYPE>(this RepresentationResult item, long li, long si, IEnumerable<KeyValuePair<string, long>> g) where PERIODIC_PROCESS_TYPE : PeriodicProcess
        {
            return new LinkSyncroDaemon<PERIODIC_PROCESS_TYPE>(item.GetLinkManager(), li, item.GetSyncroManager(), si, g);
        }
        static public LinkSyncroDaemon CreateLinkSyncroDaemon<PERIODIC_PROCESS_TYPE>(this RepresentationResult item, long li, long si, params KeyValuePair<string, long>[] g) where PERIODIC_PROCESS_TYPE : PeriodicProcess
        {
            return item.CreateLinkSyncroDaemon<PERIODIC_PROCESS_TYPE>(li, si, (IEnumerable<KeyValuePair<string, long>>)g);
        }

        static public LinkSyncroDaemon CreateLinkSyncroDaemon<PERIODIC_PROCESS_TYPE>(this RepresentationResult item, long li) where PERIODIC_PROCESS_TYPE : PeriodicProcess
        {
            return new LinkSyncroDaemon<PERIODIC_PROCESS_TYPE>(item.GetLinkManager(), li, item.GetSyncroManager());
        }

        static public LinkSyncroDaemon CreateLinkSyncroDaemon<PERIODIC_PROCESS_TYPE>(this RepresentationResult item) where PERIODIC_PROCESS_TYPE : PeriodicProcess
        {
            return new LinkSyncroDaemon<PERIODIC_PROCESS_TYPE>(item.GetLinkManager(), item.GetSyncroManager());
        }
    }
}