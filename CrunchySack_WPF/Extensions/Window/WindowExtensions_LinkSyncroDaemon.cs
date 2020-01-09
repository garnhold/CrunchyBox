using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;

namespace Crunchy.Sack.WPF
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

            item.IsVisibleChanged += delegate(object sender, DependencyPropertyChangedEventArgs e) {
                item.SyncronizeLinkSyncroDaemon(to_attach);
            };

            item.Closed += delegate(object sender, EventArgs e) {
                to_attach.StopClear();
            };
        }
    }
}