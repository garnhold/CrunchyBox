using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    public abstract partial class WPFEngine : RepresentationEngine
    {
        public WPFEngine()
        {
            if (Application.Current == null)
                new Application();

        }
    }
}