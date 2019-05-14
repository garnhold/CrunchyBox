using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySack
{
    public class LinkSyncroDaemon<PERIODIC_PROCESS_TYPE> : LinkSyncroDaemon where PERIODIC_PROCESS_TYPE : PeriodicProcess
    {
        private LinkManager link_manager;
        private SyncroManager syncro_manager;

        private LinkedPeriodicProcessManager<PERIODIC_PROCESS_TYPE> process_manager;

        public LinkSyncroDaemon(LinkManager l, long li, SyncroManager s, long si, IEnumerable<KeyValuePair<string, long>> g)
        {
            link_manager = l;
            syncro_manager = s;

            process_manager = new LinkedPeriodicProcessManager<PERIODIC_PROCESS_TYPE>();

            process_manager.Add(li, delegate() {
                link_manager.UpdateAll();
            });

            g.Process(p => process_manager.Add(p.Value, delegate() {
                link_manager.Update(p.Key);
            }));

            process_manager.Add(si, delegate() {
                syncro_manager.Update();
            });
        }

        public LinkSyncroDaemon(LinkManager l, long li, SyncroManager s, long si, params KeyValuePair<string, long>[] g) : this(l, li, s, si, (IEnumerable<KeyValuePair<string, long>>)g) { }
        public LinkSyncroDaemon(LinkManager l, long li, SyncroManager s) : this(l, li, s, 10, new KeyValuePair<string, long>("priority", 10)) { }
        public LinkSyncroDaemon(LinkManager l, SyncroManager s) : this(l, 125, s) { }

        public override void Step()
        {
            process_manager.Step();
        }

        public override void Start()
        {
            Step();
            process_manager.Start();
        }

        public override void StopClear()
        {
            Step();
            process_manager.StopClear();
        }

        public override void AddAuxillaryProcess(long milliseconds, Process process)
        {
            process_manager.Add(milliseconds, process);
        }
    }

    public abstract class LinkSyncroDaemon
    {
        public abstract void Step();

        public abstract void Start();
        public abstract void StopClear();

        public abstract void AddAuxillaryProcess(long milliseconds, Process process);
    }
}