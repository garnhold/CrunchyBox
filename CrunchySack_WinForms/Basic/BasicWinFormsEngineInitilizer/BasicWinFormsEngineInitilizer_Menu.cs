using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Sack;
    using Sack_WinCommon;
    
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
                WinFormsInfos.Children<ToolStripMenuItem>(i => i.DropDownItems),

                WinFormsInfos.AttributeFunction<ToolStripMenuItem>("click", (i, s) => i.Click += s.GetEventHandler())
            );
        }
    }
}