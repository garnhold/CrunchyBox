using System;

namespace CrunchyDough
{
    public class SanityCheckException : Exception
    {
        public SanityCheckException(string m) : base("Sanity Check Failure: " + m)
        {
        }
    }
}