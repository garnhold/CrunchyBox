using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Wait
    {
        static async Task ForDuration(Duration duration)
        {
            await Task.Delay((int)duration.GetWholeMilliseconds());
        }
        static async Task ForMilliseconds(long milliseconds)
        {
            await Wait.ForDuration(Duration.Milliseconds(milliseconds));
        }
        static async Task ForSeconds(float seconds)
        {
            await Wait.ForDuration(Duration.Seconds(seconds));
        }

        static async Task Until(Predicate predicate, Duration check_interval)
        {
            while (predicate() == false)
                await Wait.ForDuration(check_interval);
        }
    }
}