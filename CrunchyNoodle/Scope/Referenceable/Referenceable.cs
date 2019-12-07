using System;

namespace Crunchy.Noodle
{
    public interface Referenceable
    {
        string GetId();
        ScopeAccessLevel GetScopeAccessLevel();
    }
}