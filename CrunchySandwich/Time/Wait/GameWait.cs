using System;
using System.Threading.Tasks;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class GameWait
    {
        static public async Task ForUpdate()
        {
            await Wait.ForUpdate();
        }

        static public async Task ForCondition(TryProcess process, bool allow_instant)
        {
            await Wait.ForCondition(process, allow_instant);
        }
        static public async Task<T> ForCondition<T>(TryOperation<T> operation, bool allow_instant)
        {
            return await Wait.ForCondition<T>(operation, allow_instant);
        }

        static public async Task ForDuration(Duration duration, TimeType time_type)
        {
            if (duration > Duration.Nothing)
            {
                GameTimer timer = new GameTimer(duration.GetSeconds(), time_type);

                timer.Start();
                await GameWait.ForCondition(() => timer.IsTimeOver(), false);
            }
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