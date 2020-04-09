using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public class InputAtomLock
    {
        private Frame touched_frame;

        public void Touch()
        {
            touched_frame = Frame.GetCurrentFrame();
        }

        public bool IsActive()
        {
            if (touched_frame.IsRecent())
                return true;

            return false;
        }
    }
}