using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Asy
    {
        static public async Task ForUpdate()
        {
            await AsyerManager.GetInstance().GetActiveAsyncer().ForUpdate();
        }

        static public async Task ForCondition(Predicate predicate)
        {
            await AsyerManager.GetInstance().GetActiveAsyncer().ForCondition(predicate);
        }

        static public async Task ForTemporal(TemporalEvent temporal)
        {
            await AsyerManager.GetInstance().GetActiveAsyncer().ForTemporal(temporal);
        }
        static public async Task ForTemporal(TemporalDuration temporal)
        {
            await AsyerManager.GetInstance().GetActiveAsyncer().ForTemporal(temporal);
        }

        static public async Task<T[]> ForAll<T>(IEnumerable<Task<T>> tasks)
        {
            return await AsyerManager.GetInstance().GetActiveAsyncer().ForAll(tasks);
        }
        static public async Task ForAll(IEnumerable<Task> tasks)
        {
            await AsyerManager.GetInstance().GetActiveAsyncer().ForAll(tasks);
        }

        static public async Task<T> ForAny<T>(IEnumerable<Task<T>> tasks)
        {
            return await AsyerManager.GetInstance().GetActiveAsyncer().ForAny(tasks);
        }
        static public async Task ForAny(IEnumerable<Task> tasks)
        {
            await AsyerManager.GetInstance().GetActiveAsyncer().ForAny(tasks);
        }
    }
}
