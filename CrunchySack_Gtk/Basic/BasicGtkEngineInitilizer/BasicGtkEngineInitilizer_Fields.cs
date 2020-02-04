using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_Fields
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddSimpleInstancer<Entry>("TextField");
            engine.AddPublicPropertyAttributeLinksForType<Entry>();

            engine.AddVariationInstancer<Entry>("SmallField", "TextField", e => {
                e.Focused += (o, args) => e.SelectAllText();
            });

            engine.AddVariationInstancer<Entry>("StringField", "SmallField", b => {
                b.InputPurpose = InputPurpose.FreeForm;
            });
            engine.AddVariationInstancer<Entry>("IntField", "SmallField", b => {
                b.InputPurpose = InputPurpose.Number;
            });
            engine.AddVariationInstancer<Entry>("FloatField", "SmallField", b => {
                b.InputPurpose = InputPurpose.Number;
            });

            engine.AddAttributeLink<Entry, string>("value", (e, v) => e.Text = v, e => e.Text);

            engine.AddSimpleInstancer<TextView>("TextBox");
            engine.AddPublicPropertyAttributeLinksForType<TextView>();
        }
    }
}