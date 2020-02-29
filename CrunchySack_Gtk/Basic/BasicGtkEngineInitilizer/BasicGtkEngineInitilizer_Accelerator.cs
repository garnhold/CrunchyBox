using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    using Noodle;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_Accelerator
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddSimpleConstructor<AcceleratorItem, string, string, string, string>(
                (s, k, m, f) => new AcceleratorItem(s, k.ConvertEX<Gdk.Key>(), m.ConvertEX<Gdk.ModifierType>(), f.ConvertEX<AccelFlags>())
            );

            engine.AddSimpleConstructor<AcceleratorItem, string, string, string>(
                (s, k, m) => new AcceleratorItem(s, k.ConvertEX<Gdk.Key>(), m.ConvertEX<Gdk.ModifierType>())
            );

            engine.AddSimpleConstructor<AcceleratorItem, string, string>(
                (s, p) => new AcceleratorItem(s, p)
            );

            engine.AddSingleStaticChildInfo<Widget, AcceleratorItem>("accelerator", (w, a) => w.AddBasicAccelerator(a));
        }
    }
}