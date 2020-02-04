using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_Layout
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddChildren<Container, Widget>((c, i) => c.RemoveChildAt(i), (c, w) => c.AddChild(w), (c, i, w) => c.InsertChild(i, w));

            engine.AddSimpleInstancer("HorizontalLayout", () => new Box(Orientation.Horizontal, 0));
            engine.AddSimpleInstancer("VerticalLayout", () => new Box(Orientation.Vertical, 0));
            engine.AddPublicPropertyAttributeLinksForType<Box>();

            engine.AddSimpleInstancer<Grid>();
            engine.AddPublicPropertyAttributeLinksForType<Grid>();

            engine.AddChildPropertyOfParentAttributeLink<Grid, Widget, int>("row", "top-attach");
            engine.AddChildPropertyOfParentAttributeLink<Grid, Widget, int>("column", "left-attach");

            engine.AddChildPropertyOfParentAttributeLink<Grid, Widget, int>("row_span", "height");
            engine.AddChildPropertyOfParentAttributeLink<Grid, Widget, int>("column_span", "width");

            engine.AddSimpleInstancer<HPaned>("HorizontalSplitContainer");
            engine.AddPublicPropertyAttributeLinksForType<HPaned>();

            engine.AddSimpleInstancer<VPaned>("VerticalSplitContainer");
            engine.AddPublicPropertyAttributeLinksForType<VPaned>();

            engine.AddSingleAttributeChild<Paned, Widget>("child1", (p, w) => p.Add1(w));
            engine.AddSingleAttributeChild<Paned, Widget>("child2", (p, w) => p.Add2(w));

            engine.AddSimpleInstancer<FlowBox>();
            engine.AddPublicPropertyAttributeLinksForType<FlowBox>();
        }
    }
}