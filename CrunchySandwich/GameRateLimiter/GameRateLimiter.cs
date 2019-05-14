using System;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class GameRateLimiter : RateLimiter
    {
        public GameRateLimiter(float hz) : base((long)Duration.Hertz(hz).GetMilliseconds(), TimeSource_GameTime.INSTANCE) { }
        public GameRateLimiter() : this(1.0f) { }
    }
}