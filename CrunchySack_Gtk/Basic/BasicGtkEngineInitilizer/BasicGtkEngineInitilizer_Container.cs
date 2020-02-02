using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_Container
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddChildren<Container, Widget>((c, i) => c.RemoveChildAt(i), (c, w) => c.AddChild(w), (c, i, w) => c.InsertChild(i, w));
        }
    }
}