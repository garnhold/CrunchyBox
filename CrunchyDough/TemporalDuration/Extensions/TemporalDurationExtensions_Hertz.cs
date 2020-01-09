using System;

namespace Crunchy.Dough
{
    static public class TemporalDurationExtensions_Hertz
    {
        static public void SetRateInHertz(this TemporalDuration item, float hz)
        {
            item.SetDuration(Duration.Hertz(hz));
        }

        static public float GetRateInHertz(this TemporalDuration item)
        {
            return item.GetDuration().GetHertz();
        }
    }
}