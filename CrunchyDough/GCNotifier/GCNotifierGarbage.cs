using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract partial class GCNotifier
    {
        private class Garbage
        {
            private GCNotifier notifier;

            public Garbage(GCNotifier n)
            {
                notifier = n;
            }

            ~Garbage()
            {
                if (Environment.HasShutdownStarted == false)
                    notifier.Notify();
            }
        }
    }
}