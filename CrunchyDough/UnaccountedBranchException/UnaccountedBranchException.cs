using System;

namespace CrunchyDough
{
    public class UnaccountedBranchException : Exception
    {
        public UnaccountedBranchException(string name, object value) : base("Encountered an unaccounted branch: " + name + " = " + value)
        {
        }
    }
}