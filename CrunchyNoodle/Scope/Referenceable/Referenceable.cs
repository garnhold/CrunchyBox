using System;

namespace CrunchyNoodle
{
    public interface Referenceable
    {
        string GetId();
        ScopeAccessLevel GetScopeAccessLevel();
    }
}