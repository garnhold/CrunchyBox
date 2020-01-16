using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Crunchy.Sack_Avalonia
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

            item.GetPropertyChangedObservable(Window.IsVisibleProperty).Subscribe(
                delegate (AvaloniaPropertyChangedEventArgs e) {
                    item.SyncronizeLinkSyncroDaemon(to_attach);
                }
            );

            item.Closed += delegate(object sender, EventArgs e) {
                to_attach.StopClear();
            };
        }
    }
}