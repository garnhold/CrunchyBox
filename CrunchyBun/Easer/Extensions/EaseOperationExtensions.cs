using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class EaseOperationExtensions
    {
        static public float Evaluate(this EaseOperation item, float time, float start_time, float end_time, float start_value, float end_value)
        {
            return item(time.ConvertFromRangeToPercent(start_time, end_time))
                .ConvertFromPercentToRange(start_value, end_value);
        }
    }
}