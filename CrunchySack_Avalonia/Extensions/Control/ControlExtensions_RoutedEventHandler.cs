using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    using Sack_WinCommon;
    
    static public class ControlExtensions_RoutedEventHandler
    {
        static public void Register(this Control item, RoutedEvent routed_event, FunctionSyncro function, RoutingStrategies routes = RoutingStrategies.Bubble)
        {
            item.AddHandler(routed_event, function.GetEventHandler(), routes);
        }
    }
}