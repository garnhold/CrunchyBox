using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Enablable
    {
        private bool is_enabled;

        public Enablable(bool e)
        {
            SetEnabled(e);
        }

        public void Enable()
        {
            SetEnabled(true);
        }

        public void Disable()
        {
            SetEnabled(false);
        }

        public void SetEnabled(bool e)
        {
            is_enabled = e;
        }

        public bool IsEnabled()
        {
            return is_enabled;
        }
    }
}