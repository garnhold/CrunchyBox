using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_Slider
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddSimpleInstancer("HorizontalSlider", () => new HScale(0.0, 1.0, 0.01));
            engine.AddPublicPropertyAttributeLinksForType<HScale>();

            engine.AddSimpleInstancer("VerticalSlider", () => new VScale(0.0, 1.0, 0.01));
            engine.AddPublicPropertyAttributeLinksForType<VScale>();

            engine.AddLinkInfo<Scale>("minimum", "Adjustment.Lower");
            engine.AddLinkInfo<Scale>("maximum", "Adjustment.Upper");
        }
    }
}