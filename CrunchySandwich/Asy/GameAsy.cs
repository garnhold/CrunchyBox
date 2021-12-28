using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class GameAsy
    {
        static public async Task ForUpdate() { await Asy.ForUpdate(); }
        static public async Task ForCondition(Predicate predicate) { await Asy.ForCondition(predicate); }
        static public async Task ForTemporal(TemporalEvent temporal) { await Asy.ForTemporal(temporal); }
        static public async Task ForTemporal(TemporalDuration temporal) { await Asy.ForTemporal(temporal); }

        static public async Task<T[]> ForAll<T>(IEnumerable<Task<T>> tasks) { return await Asy.ForAll(tasks); }
        static public async Task<T> ForAny<T>(IEnumerable<Task<T>> tasks) { return await Asy.ForAny(tasks); }

        static public async Task ForDuration(Duration duration, TimeType time_type)
        {
            await GameAsy.ForTemporal(new GameTimer(duration, time_type).StartAndGet());
        }
        static public async Task ForSeconds(float seconds, TimeType time_type)
        {
            await GameAsy.ForDuration(Duration.Seconds(seconds), time_type);
        }
    }
}