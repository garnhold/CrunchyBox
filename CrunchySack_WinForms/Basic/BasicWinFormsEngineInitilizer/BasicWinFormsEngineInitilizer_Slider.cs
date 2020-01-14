using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Sack;
    using WinCommon;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Slider
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddPublicPropertyAttributeLinksForType<TrackBar>();
            engine.Add(
                WinFormsInstancers.Simple("Slider", () => new TrackBar())
            );
        }
    }
}