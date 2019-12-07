using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract partial class GCNotifier
    {
        protected abstract void OnNotification();

        private void Notify()
        {
            try { OnNotification(); }
            finally { Register(); }
        }

        private void Register()
        {
            new Garbage(this);
        }

        public GCNotifier()
        {
            Register();
        }
    }
}