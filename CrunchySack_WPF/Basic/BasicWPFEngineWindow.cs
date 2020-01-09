using System;
using System.IO;

using System.Windows;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Sack;
    
    public abstract class BasicWPFEngineWindow : WPFEngineWindow
    {
        public BasicWPFEngineWindow() : base(BasicWPFEngine.GetInstance()) { }
    }
}