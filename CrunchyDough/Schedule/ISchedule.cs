using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public interface ISchedule
    {
        void Complete(long timestamp);
        void Lookahead(long timestamp, long target_milliseconds);
        
        void ScheduleProcess(long timestamp, Process process);
    }
}