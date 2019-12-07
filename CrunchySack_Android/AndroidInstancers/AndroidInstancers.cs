using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    public partial class AndroidInstancers : RepresentationInstancers
    {
        static public RepresentationInstancer Simple(string t, Operation<object, Activity> o)
        {
            return Simple<Activity>(t, o);
        }
    }
}