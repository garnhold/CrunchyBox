using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_Widget
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddLinkInfo<Widget>("width", "WidthRequest");
            engine.AddLinkInfo<Widget>("height", "HeightRequest");

            engine.AddFunctionHookInfo<Widget>("on_delete", "DeleteEvent");
        }
    }
}