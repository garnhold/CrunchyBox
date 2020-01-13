using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Sack;
    using WinCommon;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Button
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddPublicPropertyAttributeLinksForType<Button>();

            engine.Add(
                WinFormsInstancers.Simple("Button", () => new Button()),

                WinFormsInfos.AttributeFunction<Button>("click", (b, s) => b.Click += s.GetEventHandler())
            );
        }
    }
}