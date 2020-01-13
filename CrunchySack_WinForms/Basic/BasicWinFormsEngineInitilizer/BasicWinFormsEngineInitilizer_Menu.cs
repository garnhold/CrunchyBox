using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Sack;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Menu
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddPublicPropertyAttributeLinksForType<MenuStrip>();
            engine.AddPublicPropertyAttributeLinksForType<ToolStripMenuItem>();

            engine.Add(
                WinFormsInstancers.Simple("Menu", () => new MenuStrip()),
                WinFormsInfos.Children<MenuStrip>(m => m.Items),

                WinFormsInstancers.Simple("MenuItem", () => new ToolStripMenuItem()),
                WinFormsInfos.Children<ToolStripMenuItem>(i => i.DropDownItems)
            );
        }
    }
}