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
        public WPFEngine()
        {
            if (Application.Current == null)
                new Application();

        }
    }
}