using System;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class TapTimer : GameStopwatch
    {
        static private readonly SpectrumLookup<TapType> TAP_SPECTRUM = new Spectrum<TapType>(
            KeyValuePair.New(float.NegativeInfinity, TapType.MicroTap),
            KeyValuePair.New(0.125f, TapType.ShortTap),
            KeyValuePair.New(0.95f, TapType.LongTap),
            KeyValuePair.New(float.PositiveInfinity, TapType.Invalid)
        );

        public TapType GetTapType()
        {
            return TAP_SPECTRUM.LookupFirstData(this.GetElapsedTimeInSeconds());
        }
    }
}