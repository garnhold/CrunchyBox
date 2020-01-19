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
            engine.AddSimpleInstancer<MenuStrip>("Menu");
            engine.AddPublicPropertyAttributeLinksForType<MenuStrip>();
            engine.AddChildren<MenuStrip>(m => m.Items);

            engine.AddSimpleInstancer<ToolStripMenuItem>("MenuItem");
            engine.AddPublicPropertyAttributeLinksForType<ToolStripMenuItem>();
            engine.AddChildren<ToolStripMenuItem>(i => i.DropDownItems);
            engine.AddAttributeFunction<ToolStripMenuItem>("click", (i, s) => i.Click += s.GetEventHandler());
        }
    }
}