using System;

namespace CrunchyDough
{
    public class StringOptionException : Exception
    {
        public StringOptionException(string m) : base(m) { }
    }
}