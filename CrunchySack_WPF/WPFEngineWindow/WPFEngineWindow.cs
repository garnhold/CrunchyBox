using System;
using System.IO;

using System.Windows;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Sack;
    
    public abstract class WPFEngineWindow : Window
    {
        public WPFEngineWindow(WPFEngine engine)
        {
            RepresentationResult result = engine.CreateRepresentation(this);

            Content = result.GetRepresentation();
            this.AttachLinkSyncroDaemon(result.CreateLinkSyncroDaemon<PeriodicProcess_WPF>());
        }
    }
}