using System;
using System.IO;

using Android;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;

namespace Crunchy.Sack_Android
{
    using Dough;
    
    static public class AndroidExtensions
    {
        static private readonly OperationCache<Handler> AUX_HANDLER = new OperationCache<Handler>("AUX_HANDLER", delegate() {
            return new Handler(Looper.MainLooper);
        });

        static public void RunOnUiThread(CrunchyDough.Process process)
        {
            AUX_HANDLER.Fetch().Post(delegate() {
                process();
            });
        }

        static public void RunOnUiThreadDelayed(CrunchyDough.Process process, long delay)
        {
            AUX_HANDLER.Fetch().PostDelayed(delegate() {
                process();
            }, delay);
        }
    }
}