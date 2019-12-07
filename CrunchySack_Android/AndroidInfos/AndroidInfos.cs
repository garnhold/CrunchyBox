using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    public partial class AndroidInfos : RepresentationInfos
    {
        static public RepresentationInfo AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r) where REPRESENTATION_TYPE : View
        {
            return AttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r, s => s.IsFocused == false);
        }

        static public RepresentationInfo AttributeValueLayout<REPRESENTATION_TYPE, VALUE_TYPE>(string n, Process<View, REPRESENTATION_TYPE, VALUE_TYPE> process)
        {
            return AttributeValue<View, VALUE_TYPE>(n, (v, c) => v.LayoutParameters.ProcessAs<REPRESENTATION_TYPE>(i => process(v, i, c)));
        }
    }
}