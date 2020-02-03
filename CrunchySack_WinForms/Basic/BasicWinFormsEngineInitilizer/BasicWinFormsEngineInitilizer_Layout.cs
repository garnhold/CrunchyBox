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
            engine.AddGeneralModifier<Panel>(p => {
                p.AutoSize = true;
                p.Dock = DockStyle.Fill;
            });
            engine.AddGeneralModifier<ContainerControl>(c => c.Dock = DockStyle.Fill);

            engine.AddSimpleInstancer<Panel>("DockPanel");
            engine.AddPublicPropertyAttributeLinksForType<Panel>();

            engine.AddSimpleInstancer("HorizontalLayout", () => new FlowLayoutPanel() {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false
            });
            engine.AddSimpleInstancer("VerticalLayout", () => new FlowLayoutPanel() {
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            });
            engine.AddPublicPropertyAttributeLinksForType<FlowLayoutPanel>();

            engine.AddSimpleInstancer<TableLayoutPanel>("Table");
            engine.AddAttributeLink<TableLayoutPanel, string>("columns", (t, s) => t.SetColumnsDefinitionString(s), t => t.GetColumnsDefinitionString());
            engine.AddAttributeLink<TableLayoutPanel, string>("rows", (t, s) => t.SetRowsDefinitionString(s), t => t.GetRowsDefinitionString());

            engine.AddAttributeLink<Control, int>("column", (c, i) => c.SetColumn(i), c => c.GetColumn());
            engine.AddAttributeLink<Control, int>("row", (c, i) => c.SetRow(i), c => c.GetRow());

            engine.AddSimpleInstancer<SplitContainer>();
            engine.AddPublicPropertyAttributeLinksForType<SplitContainer>();
            engine.AddAttributeChildren<SplitContainer>("panel1", c => c.Panel1.Controls);
            engine.AddAttributeChildren<SplitContainer>("panel2", c => c.Panel2.Controls);
        }
    }
}