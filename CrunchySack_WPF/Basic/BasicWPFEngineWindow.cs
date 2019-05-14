using System;
using System.IO;

using System.Windows;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_WPF
{
    public abstract class BasicWPFEngineWindow : WPFEngineWindow
    {
        public BasicWPFEngineWindow() : base(BasicWPFEngine.GetInstance()) { }
    }
}