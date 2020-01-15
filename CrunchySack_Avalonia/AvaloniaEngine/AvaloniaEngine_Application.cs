using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class AvaloniaEngine : RepresentationEngine
    {
        public void StartApplication(object target, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {            
            Application.Current.Run(CreateWindowRepresentation(target, layout));
        }

        public void StartApplication(object target, long milliseconds, Process process, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            Application.Current.Run(CreateWindowRepresentation(target, milliseconds, process, layout));
        }
    }
}