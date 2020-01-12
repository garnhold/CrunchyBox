using System;
using System.IO;

using System.Drawing;
using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Sack;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Layout
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.Add(
                WinFormsInstancers.Simple("Panel", () => new Panel()),

                WinFormsModifiers.General<Panel>(p => {
                    p.AutoSize = true;
                    p.Dock = DockStyle.Fill;
                }),

                WinFormsInstancers.Simple("HorizontalLayout", () => new FlowLayoutPanel() {
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = false
                }),

                WinFormsInstancers.Simple("VerticalLayout", () => new FlowLayoutPanel() {
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false
                }),

                WinFormsInstancers.Simple("Table", () => new TableLayoutPanel()),

                WinFormsInfos.AttributeLink<TableLayoutPanel, string>("columns", (t, s) => t.SetColumnsDefinitionString(s), t => t.GetColumnsDefinitionString()),
                WinFormsInfos.AttributeLink<TableLayoutPanel, string>("rows", (t, s) => t.SetRowsDefinitionString(s), t => t.GetRowsDefinitionString()),

                WinFormsInfos.AttributeLink<Control, int>("column", (c, i) => c.SetColumn(i), c => c.GetColumn()),
                WinFormsInfos.AttributeLink<Control, int>("row", (c, i) => c.SetRow(i), c => c.GetRow())
            );
        }
    }
}