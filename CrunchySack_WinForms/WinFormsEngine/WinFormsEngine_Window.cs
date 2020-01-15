using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class WinFormsEngine : RepresentationEngine
    {
        private Form CreateWindowRepresentationInternal(object target, out LinkSyncroDaemon daemon, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            RepresentationResult result = this.CreateRepresentation(target, layout);

            Form window = result.GetRepresentation<Form>();
            daemon = result.CreateLinkSyncroDaemon<PeriodicProcess_WinForms>();

            window.AttachLinkSyncroDaemon(daemon);
            return window;
        }

        public Form CreateWindowRepresentation(object target, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            LinkSyncroDaemon daemon;

            return CreateWindowRepresentationInternal(target, out daemon, layout);
        }

        public Form CreateWindowRepresentation(object target, long milliseconds, Process process, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            LinkSyncroDaemon daemon;
            Form window = CreateWindowRepresentationInternal(target, out daemon, layout);

            daemon.AddAuxillaryProcess(milliseconds, process);
            return window;
        }
    }
}