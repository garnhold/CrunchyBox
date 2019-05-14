using System;
using System.IO;

using System.Windows;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_WPF
{
    public abstract class WPFEngineWindow : Window
    {
        private LinkSyncroDaemon link_syncro_daemon;

        public WPFEngineWindow(WPFEngine engine)
        {
            RepresentationResult result = engine.CreateRepresentation(this);

            link_syncro_daemon = result.CreateLinkSyncroDaemon<PeriodicProcess_WPF>();
            Content = result.GetRepresentation();

            this.AttachLinkSyncroDaemon(link_syncro_daemon);
        }
    }
}