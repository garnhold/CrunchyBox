using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class StringOption
    {
        protected abstract bool TryUseOptionStringInternal(LookupSet<string, string> settings, Operation<bool, string> operation);

        public bool TryUseOptionString(LookupSet<string, string> settings, Operation<bool, string> operation, bool strict = false)
        {
            if (TryUseOptionStringInternal(settings, operation))
                return true;

            if (strict)
                throw new StringOptionException("Unable to use option: " + this);

            return false;
        }
    }
}