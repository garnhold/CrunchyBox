using System;

namespace Crunchy.Dough
{
    public sealed class NeverCatchException : Exception
    {
        private NeverCatchException() { }
    }
}