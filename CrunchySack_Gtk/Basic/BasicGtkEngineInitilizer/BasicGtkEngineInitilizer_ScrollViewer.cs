using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_ScrollViewer
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddSimpleInstancer<ScrolledWindow>("ScrollViewer");
            engine.AddPublicPropertyAttributeLinksForType<ScrolledWindow>();
        }
    }
}