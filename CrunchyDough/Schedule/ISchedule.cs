using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public interface ISchedule
    {
        void Complete(long timestamp);
        void Lookahead(long timestamp, long target_milliseconds);
        
        void ScheduleProcess(long timestamp, Process process);
    }
}