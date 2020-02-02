﻿using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    
    [BasicAvaloniaEngineInitilizer]
    static public class BasicAvaloniaEngineInitilizer_Button
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddSimpleInstancer<Button>();
            engine.AddAvaloniaPropertyAttributeLinksForType<Button>();

            engine.AddAttributeLink<Button, string>("text", Button.ContentProperty);
            engine.AddAttributeFunction<Button>("action", Button.ClickEvent);
        }
    }
}