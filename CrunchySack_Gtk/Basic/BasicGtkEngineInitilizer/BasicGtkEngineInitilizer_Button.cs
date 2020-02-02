﻿using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_Button
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddSimpleInstancer<Button>();
            engine.AddPublicPropertyAttributeLinksForType<Button>();

            engine.AddAttributeFunction<Button>("action", (b, s) => b.Clicked += s.GetEventHandler());
        }
    }
}