using System;
using System.Threading.Tasks;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class GameWait
    {
        static public async Task ForDuration(Duration duration, TimeType time_type)
        {
            GameTimer timer = new GameTimer(duration.GetSeconds(), time_type)
                .StartAndGet();
                
            await Wait.ForCondition(() => timer.IsTimeOver());
        }
        static public async Task ForMilliseconds(long milliseconds, TimeType time_type)
        {
            await GameWait.ForDuration(Duration.Milliseconds(milliseconds), time_type);
        }
        static public async Task ForSeconds(float seconds, TimeType time_type)
        {
            await GameWait.ForDuration(Duration.Seconds(seconds), time_type);
        }
    }
}