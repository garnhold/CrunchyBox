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
    static public class BasicAvaloniaEngineInitilizer_ItemsControl
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddDynamicChildrenInfo<ItemsControl, object>((c, os) => c.Items = os);
        }
    }
}