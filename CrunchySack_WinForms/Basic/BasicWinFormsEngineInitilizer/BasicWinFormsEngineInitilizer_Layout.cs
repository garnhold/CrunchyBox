using System;
using System.IO;

using System.Drawing;
using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Sack;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Layout
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddPublicPropertyAttributeLinksForType<Panel>();
            engine.Add(
                WinFormsInstancers.Simple("DockPanel", () => new Panel()),

                WinFormsModifiers.General<Panel>(p => {
                    p.AutoSize = true;
                    p.Dock = DockStyle.Fill;
                })
            );

            engine.AddPublicPropertyAttributeLinksForType<ContainerControl>();
            engine.Add(
                WinFormsModifiers.General<ContainerControl>(c => c.Dock = DockStyle.Fill)
            );

            engine.Add(
                WinFormsInstancers.Simple("HorizontalLayout", () => new FlowLayoutPanel() {
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = false
                }),

                WinFormsInstancers.Simple("VerticalLayout", () => new FlowLayoutPanel() {
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false
                })
            );

            engine.Add(
                WinFormsInstancers.Simple("Table", () => new TableLayoutPanel()),

                WinFormsInfos.AttributeLink<TableLayoutPanel, string>("columns", (t, s) => t.SetColumnsDefinitionString(s), t => t.GetColumnsDefinitionString()),
                WinFormsInfos.AttributeLink<TableLayoutPanel, string>("rows", (t, s) => t.SetRowsDefinitionString(s), t => t.GetRowsDefinitionString()),

                WinFormsInfos.AttributeLink<Control, int>("column", (c, i) => c.SetColumn(i), c => c.GetColumn()),
                WinFormsInfos.AttributeLink<Control, int>("row", (c, i) => c.SetRow(i), c => c.GetRow())
            );

            engine.AddPublicPropertyAttributeLinksForType<SplitContainer>();
            engine.Add(
                WinFormsInstancers.Simple("SplitContainer", () => new SplitContainer()),

                WinFormsInfos.AttributeChildren<SplitContainer>("panel1", c => c.Panel1.Controls),
                WinFormsInfos.AttributeChildren<SplitContainer>("panel2", c => c.Panel2.Controls)
            );

            engine.AddPublicPropertyAttributeLinksForType<TabControl>();
            engine.AddPublicPropertyAttributeLinksForType<TabPage>();
            engine.Add(
                WinFormsInstancers.Simple("TabControl", () => new TabControl()),
                WinFormsInfos.Children<TabControl>(c => c.TabPages),

                WinFormsInstancers.Simple("TabPage", () => new TabPage()),
                WinFormsInfos.Children<TabPage>(p => p.Controls)
            );
        }
    }
}