using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    
    public partial class AvaloniaInfos : RepresentationInfos
    {
        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r) where REPRESENTATION_TYPE : Control
        {
            return AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r, s => s.IsFocused == false);
        }

        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, AvaloniaProperty property) where REPRESENTATION_TYPE : Control
        {
            return AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n, (s, t) => s.SetValue(property, t), s => s.GetValue(property).Convert<VALUE_TYPE>());
        }
    }
}