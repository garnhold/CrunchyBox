using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class WindowExtensions_LinkSyncroDaemon
    {
        static public void SyncronizeLinkSyncroDaemon(this Window item, LinkSyncroDaemon to_attach)
        {
            if (item.IsVisible)
                to_attach.Start();
            else
                to_attach.StopClear();
        }

        static public void AttachLinkSyncroDaemon(this Window item, LinkSyncroDaemon to_attach)
        {
            item.SyncronizeLinkSyncroDaemon(to_attach);

            item.AddPropertyChangeProcess(Gdk.EventType.VisibilityNotify, delegate () {
                item.SyncronizeLinkSyncroDaemon(to_attach);
            });

            item.AddPropertyChangeProcess(Gdk.EventType.Destroy, delegate () {
                to_attach.StopClear();
            });
        }
    }
}