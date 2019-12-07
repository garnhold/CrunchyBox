using System;

namespace Crunchy.Baker
{
    using Dough;
    
    public class TimedTaskComparer_Simple_Process : TimedTaskComparer_Simple
    {
        public TimedTaskComparer_Simple_Process(int f, int p, Process a, Process b) 
            : base(f, p, new TimedTask_Process(a), new TimedTask_Process(b))
        {
        }
    }
}