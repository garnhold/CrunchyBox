using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    public partial class AndroidInstancers : RepresentationInstancers
    {
        static public RepresentationInstancer Simple(string t, Operation<object, Activity> o)
        {
            return Simple<Activity>(t, o);
        }
    }
}