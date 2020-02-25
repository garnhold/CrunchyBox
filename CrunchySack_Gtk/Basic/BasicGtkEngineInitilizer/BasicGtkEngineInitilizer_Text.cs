using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_Text
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddSimpleInstancer<Label>("Text");
            engine.AddPublicPropertyAttributeLinksForType<Label>();

            engine.AddSimpleInstancer<AccelLabel>();
            engine.AddPublicPropertyAttributeLinksForType<AccelLabel>();
        }
    }
}