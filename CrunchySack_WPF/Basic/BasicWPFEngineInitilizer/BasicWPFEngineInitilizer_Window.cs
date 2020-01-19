using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    using Sack_WinCommon;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Window
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddSimpleInstancer<Window>();
            engine.AddAttributeFunction<Window>("on_close", (w, s) => w.Closed += s.GetEventHandler());
        }
    }
}