using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Windows;
using System.Windows.Controls;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_WPF
{
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