using System;

namespace CrunchyDough
{
    public class Block
    {
        private bool is_executing;

        public void Execute(Process process)
        {
            if (is_executing == false)
                true.PushPopInto(ref is_executing, process);
        }
    }
}