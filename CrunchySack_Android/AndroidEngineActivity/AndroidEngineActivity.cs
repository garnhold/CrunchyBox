using System;
using System.IO;

using Android;
using Android.OS;
using Android.App;
using Android.Views;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    public abstract class AndroidEngineActivity : Activity
    {
        private AndroidEngine engine;
        private LinkSyncroDaemon link_syncro_daemon;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            RepresentationResult result = engine.CreateRepresentation(this);
            
            link_syncro_daemon = result.CreateLinkSyncroDaemon<PeriodicProcess_Android>();
            SetContentView(result.GetRepresentation<View>());
        }

        protected override void OnResume()
        {
            base.OnResume();

            link_syncro_daemon.Start();
        }

        protected override void OnPause()
        {
            base.OnPause();

            link_syncro_daemon.StopClear();
        }

        public AndroidEngineActivity(AndroidEngine e)
        {
            engine = e;
        }
    }
}