using System;

namespace Crunchy.Dough
{
    public class SanityCheckException : Exception
    {
        public SanityCheckException(string m) : base("Sanity Check Failure: " + m)
        {
        }
    }
}