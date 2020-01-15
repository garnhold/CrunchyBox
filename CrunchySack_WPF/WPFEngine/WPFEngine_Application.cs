using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class WPFEngine : RepresentationEngine
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