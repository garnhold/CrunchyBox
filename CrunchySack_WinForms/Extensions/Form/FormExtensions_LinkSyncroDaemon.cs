using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Noodle;
    using Sack;

    static public class FormExtensions_LinkSyncroDaemon
    {
        static public void SyncronizeLinkSyncroDaemon(this Form item, LinkSyncroDaemon to_attach)
        {
            if (item.Visible)
                to_attach.Start();
            else
                to_attach.StopClear();
        }

        static public void AttachLinkSyncroDaemon(this Form item, LinkSyncroDaemon to_attach)
        {
            item.SyncronizeLinkSyncroDaemon(to_attach);
                
            item.VisibleChanged += delegate (object sender, EventArgs e) {
                item.SyncronizeLinkSyncroDaemon(to_attach);
            };

            item.Closed += delegate (object sender, EventArgs e) {
                to_attach.StopClear();
            };
        }
    }
}