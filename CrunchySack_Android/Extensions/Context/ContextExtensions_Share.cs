using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Content.Res;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    static public class ContextExtensions_Share
    {
        static public void ShareText(this Context item, string text)
        {
            Intent intent = new Intent();

            intent.SetAction(Intent.ActionSend);
            intent.PutExtra(Intent.ExtraText, text);
            intent.SetType("text/plain");

            item.StartActivity(intent);
        }
    }
}