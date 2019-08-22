using System;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class GameRateLimiter : RateLimiter
    {
        public GameRateLimiter(float hz) : base(Duration.Hertz(hz).GetWholeMilliseconds(), GameTime.INSTANCE) { }
        public GameRateLimiter() : this(1.0f) { }
    }
}