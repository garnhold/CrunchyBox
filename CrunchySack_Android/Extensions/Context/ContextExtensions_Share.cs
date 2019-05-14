using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Content.Res;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
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