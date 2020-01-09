using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    public partial class AndroidModifiers : RepresentationModifiers
    {
        static public RepresentationModifier GeneralLayout<REPRESENTATION_TYPE, PARAMETER_TYPE>(Process<REPRESENTATION_TYPE, PARAMETER_TYPE> process) where REPRESENTATION_TYPE : View
        {
            return General<REPRESENTATION_TYPE>(v => v.LayoutParameters.ProcessAs<PARAMETER_TYPE>(i => process(v, i)));
        }
    }
}