using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    public partial class GtkInfos : RepresentationInfos
    {
        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r) where REPRESENTATION_TYPE : Widget
        {
            return AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r, s => s.IsFocus == false);
        }
    }
}