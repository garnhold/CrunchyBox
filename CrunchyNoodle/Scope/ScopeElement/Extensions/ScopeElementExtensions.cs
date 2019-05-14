using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ScopeElementExtensions
    {
        static public Scope GetLocalScope(this ScopeElement item)
        {
            return item.GetSelfOrParent<Scope>();
        }

        static public Scope GetParentScope(this ScopeElement item)
        {
            return item.GetLocalScope().GetParentScope();
        }

        static public IEnumerable<IEnumerable<Referenceable>> GetReferenceables(this ScopeElement item, string id, ScopeAccess access, IList<Scope> path)
        {
            return item.GetLocalScope().GetReferenceables(id, access, path);
        }
        static public IEnumerable<IEnumerable<T>> GetReferenceables<T>(this ScopeElement item, string id, ScopeAccess access, IList<Scope> path)
        {
            return item.GetLocalScope().GetReferenceables<T>(id, access, path);
        }
    }
}