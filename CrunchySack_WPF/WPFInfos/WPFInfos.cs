using System;
using System.IO;

using System.Windows;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Sack;
    
    public partial class WPFInfos : RepresentationInfos
    {
        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r) where REPRESENTATION_TYPE : UIElement
        {
            return AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r, s => s.IsFocused == false);
        }

        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, DependencyProperty property) where REPRESENTATION_TYPE : UIElement
        {
            return AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n, (s, t) => s.SetValue(property, t), s => s.GetValue(property).Convert<VALUE_TYPE>());
        }
    }
}