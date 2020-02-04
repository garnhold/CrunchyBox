using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_Bar
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddSimpleInstancer<LevelBar>();
            engine.AddPublicPropertyAttributeLinksForType<LevelBar>();

            engine.AddSimpleInstancer<ProgressBar>();
            engine.AddPublicPropertyAttributeLinksForType<ProgressBar>();

            engine.AddSimpleInstancer<HScrollbar>("HorizontalScrollbar");
            engine.AddPublicPropertyAttributeLinksForType<HScrollbar>();

            engine.AddSimpleInstancer<VScrollbar>("VectricalScrollbar");
            engine.AddPublicPropertyAttributeLinksForType<VScrollbar>();
        }
    }
}