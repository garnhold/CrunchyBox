using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class AvaloniaEngine : RepresentationEngine
    {
        private Window CreateWindowRepresentationInternal(object target, out LinkSyncroDaemon daemon, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            RepresentationResult result = this.CreateRepresentation(target, layout);

            Window window = result.GetRepresentation<Window>();
            daemon = result.CreateLinkSyncroDaemon<PeriodicProcess_Avalonia>();

            window.AttachLinkSyncroDaemon(daemon);
            return window;
        }

        public Window CreateWindowRepresentation(object target, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            LinkSyncroDaemon daemon;

            return CreateWindowRepresentationInternal(target, out daemon, layout);
        }

        public Window CreateWindowRepresentation(object target, long milliseconds, Process process, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            LinkSyncroDaemon daemon;
            Window window = CreateWindowRepresentationInternal(target, out daemon, layout);

            daemon.AddAuxillaryProcess(milliseconds, process);
            return window;
        }
    }
}