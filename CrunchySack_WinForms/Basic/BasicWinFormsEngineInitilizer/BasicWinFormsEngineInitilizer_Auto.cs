using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Sack;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Auto
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddInspectedComponentsForTypes(
                typeof(Form),

                typeof(Control),
                typeof(Button),
                typeof(CheckBox),
                typeof(CheckedListBox),
                typeof(ColorDialog),
                typeof(ComboBox),
                typeof(ContextMenu),
                typeof(ContextMenuStrip),
                typeof(DataGrid),
                typeof(DataGridView),
                typeof(DateTimePicker),
                typeof(DomainUpDown),
                typeof(FlowLayoutPanel),
                typeof(GroupBox),
                typeof(Label),
                typeof(LinkLabel),
                typeof(ListBox),
                typeof(ListView),
                typeof(MainMenu),
                typeof(MaskedTextBox),
                typeof(MenuStrip),
                typeof(MonthCalendar),
                typeof(NumericUpDown),
                typeof(Panel),
                typeof(PictureBox),
                typeof(ProgressBar),
                typeof(RadioButton),
                typeof(RichTextBox),
                typeof(StatusBar),
                typeof(StatusStrip),
                typeof(TabControl),
                typeof(TableLayoutPanel),
                typeof(TextBox),
                typeof(ToolBar),
                typeof(ToolStrip),
                typeof(ToolTip),
                typeof(TrackBar)
            );
        }
    }
}