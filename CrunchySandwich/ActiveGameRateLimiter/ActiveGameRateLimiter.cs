using System;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ActiveGameRateLimiter : RateLimiter
    {
        public ActiveGameRateLimiter(Duration i) : base(i.GetWholeMilliseconds(), TimeSource_ActiveGameTime.INSTANCE) { }
        public ActiveGameRateLimiter(float hz) : this(Duration.Hertz(hz)) { }
        public ActiveGameRateLimiter() : this(1.0f) { }
    }
}