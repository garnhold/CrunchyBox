using System;
using System.Reflection;

namespace Crunchy.Dough
{
    public interface TemporalEvent : Temporal
    {
        void Reset();
        void Prime();

        bool IsTimeOver();
    }
}