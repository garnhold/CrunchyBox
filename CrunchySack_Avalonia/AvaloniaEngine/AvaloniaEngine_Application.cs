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
        static private Window MAIN_WINDOW;
        static public Window GetMainWindow()
        {
            return MAIN_WINDOW;
        }

        public void StartApplication(object target, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            MAIN_WINDOW = CreateWindowRepresentation(target, layout);

            Application.Current.Run(MAIN_WINDOW);
        }

        public void StartApplication(object target, long milliseconds, Process process, string layout = CmlLinkSource.DEFAULT_LAYOUT)
        {
            MAIN_WINDOW = CreateWindowRepresentation(target, milliseconds, process, layout);

            Application.Current.Run(MAIN_WINDOW);
        }
    }
}