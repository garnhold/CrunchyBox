using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_ItemsControl
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddChildren<ItemsControl>(i => i.Items);
        }
    }
}