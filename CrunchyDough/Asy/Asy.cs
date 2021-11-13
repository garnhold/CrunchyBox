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
    }
}
