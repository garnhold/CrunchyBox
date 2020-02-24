using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_ComboBox
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddSimpleInstancer<ComboBoxText>("ComboBox");
            engine.AddPublicPropertyAttributeLinksForType<ComboBoxText>();

            engine.AddDynamicChildrenInfo<ComboBoxText, string>(
                (b, i) => b.Remove(i),
                (b, s) => b.AppendText(s),
                (b, i, s) => b.InsertText(i, s)
            );
        }
    }
}