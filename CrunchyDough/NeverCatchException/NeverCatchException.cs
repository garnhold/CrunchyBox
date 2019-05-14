using System;

namespace CrunchyDough
{
    public sealed class NeverCatchException : Exception
    {
        private NeverCatchException() { }
    }
}