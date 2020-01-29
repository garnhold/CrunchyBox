using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public abstract class ApplicationRepresentationEngine<WINDOW_TYPE, PERIODIC_PROCESS_TYPE> : RepresentationEngine where PERIODIC_PROCESS_TYPE : PeriodicProcess
    {
        static private WINDOW_TYPE MAIN_WINDOW;
        static public WINDOW_TYPE GetMainWindow()
        {
            return MAIN_WINDOW;
        }

        protected abstract void StartApplicationInternal(Operation<WINDOW_TYPE> operation);
        protected abstract void AttachLinkSyncroDaemon(WINDOW_TYPE window, LinkSyncroDaemon daemon);

        private void StartApplication(Operation<WINDOW_TYPE> operation)
        {
            StartApplicationInternal(delegate () {
                MAIN_WINDOW = operation();

                return MAIN_WINDOW;
            });
        }

        private WINDOW_TYPE CreateWindowRepresentationInternal(object target, out LinkSyncroDaemon daemon, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            RepresentationResult result = this.AssertCreateRepresentation(target, layout);

            WINDOW_TYPE window = result.GetRepresentation<WINDOW_TYPE>();
            daemon = result.CreateLinkSyncroDaemon<PERIODIC_PROCESS_TYPE>();

            AttachLinkSyncroDaemon(window, daemon);
            return window;
        }

        public void StartApplication(object target, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            StartApplication(() => CreateWindowRepresentation(target, layout));
        }
        public void StartApplication<T>(string layout = CmlLinkSource.DEFAULT_LAYOUT) where T : new()
        {
            StartApplication(new T(), layout);
        }

        public void StartApplication(object target, long milliseconds, Process process, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            StartApplication(() => CreateWindowRepresentation(target, milliseconds, process, layout));
        }
        public void StartApplication<T>(T target, long milliseconds, Process<T> process, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            StartApplication(target, milliseconds, () => process(target), layout);
        }
        public void StartApplication<T>(long milliseconds, Process<T> process, string layout = CmlLinkSource.DEFAULT_LAYOUT) where T : new()
        {
            StartApplication(new T(), milliseconds, process, layout);
        }

        public WINDOW_TYPE CreateWindowRepresentation(object target, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            LinkSyncroDaemon daemon;

            return CreateWindowRepresentationInternal(target, out daemon, layout);
        }

        public WINDOW_TYPE CreateWindowRepresentation(object target, long milliseconds, Process process, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            LinkSyncroDaemon daemon;
            WINDOW_TYPE window = CreateWindowRepresentationInternal(target, out daemon, layout);

            daemon.AddAuxillaryProcess(milliseconds, process);
            return window;
        }
    }
}