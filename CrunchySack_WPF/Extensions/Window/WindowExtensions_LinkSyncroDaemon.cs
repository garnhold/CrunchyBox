using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class WindowExtensions_LinkSyncroDaemon
    {
        static public void AttachLinkSyncroDaemon(this Window item, LinkSyncroDaemon to_attach)
        {
            if (item.IsVisible)
                to_attach.Start();
            else
                to_attach.StopClear();

            item.IsVisibleChanged += delegate(object sender, DependencyPropertyChangedEventArgs e) {
                if ((bool)e.NewValue)
                    to_attach.Start();
                else
                    to_attach.StopClear();
            };

            item.Closed += delegate(object sender, EventArgs e) {
                to_attach.StopClear();
            };
        }
    }
}