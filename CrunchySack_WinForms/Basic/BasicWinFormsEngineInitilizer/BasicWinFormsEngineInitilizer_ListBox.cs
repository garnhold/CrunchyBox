using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Sack;
    using Sack_WinCommon;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_ListBox
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddPublicPropertyAttributeLinksForType<ListBox>();
            engine.Add(
                WinFormsInstancers.Simple("ListBox", () => new ListBox()),
                WinFormsInfos.Children<ListBox>(b => b.Items)
            );
        }
    }
}