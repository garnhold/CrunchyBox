using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Wait
    {
        static Task ForDuration(Duration duration)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            TaskCompletionSource<bool> task_completion_source = new TaskCompletionSource<bool>();

            timer.Elapsed += (sender, e) => task_completion_source.TrySetResult(true);
            timer.Interval = duration.GetMilliseconds();
            timer.AutoReset = false;
            timer.Start();

            return task_completion_source.Task;
        }
        static Task ForMilliseconds(long milliseconds)
        {
            return Wait.ForDuration(Duration.Milliseconds(milliseconds));
        }
        static Task ForSeconds(float seconds)
        {
            return Wait.ForDuration(Duration.Seconds(seconds));
        }

        static async Task Until(Predicate predicate, Duration check_interval)
        {
            while (predicate() == false)
                await Wait.ForDuration(check_interval);
        }
    }
}