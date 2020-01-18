using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class GtkEngine : ApplicationRepresentationEngine<Window, PeriodicProcess_Gtk>
    {
        protected override void AttachLinkSyncroDaemon(Window window, LinkSyncroDaemon daemon)
        {
            window.AttachLinkSyncroDaemon(daemon);
        }

        protected override void StartApplicationInternal(Operation<Window> operation)
        {
            Application.Init();
            operation();
            Application.Run();
        }
    }
}