using System;
using System.Reflection;

namespace CrunchyDough
{
    public interface TemporalEvent : Temporal
    {
        void Reset();
        void Prime();

        bool IsTimeOver();
    }
}