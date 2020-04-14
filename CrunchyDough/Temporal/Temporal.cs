using System;
using System.Reflection;

namespace Crunchy.Dough
{
    public interface Temporal
    {
        bool Start();
        bool Pause();

        bool IsRunning();
    }
}