using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_ComboBox
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInstancers.Simple("ComboBox", () => new ComboBox())
            );
        }
    }
}