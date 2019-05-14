using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class ScopeAccessExtensions
    {
        static public ScopeAccess GetFromInside(this ScopeAccess item)
        {
            switch (item)
            {
                case ScopeAccess.Inside:
                    return ScopeAccess.Inside;

                case ScopeAccess.Lateral:
                    return ScopeAccess.Lateral;

                case ScopeAccess.Outside:
                    return ScopeAccess.Outside;
            }

            return ScopeAccess.Outside;
        }

        static public ScopeAccess GetFromOutside(this ScopeAccess item)
        {
            switch (item)
            {
                case ScopeAccess.Inside:
                    return ScopeAccess.Outside;

                case ScopeAccess.Lateral:
                    return ScopeAccess.Outside;

                case ScopeAccess.Outside:
                    return ScopeAccess.Outside;
            }

            return ScopeAccess.Outside;
        }

        static public ScopeAccess GetFromSide(this ScopeAccess item)
        {
            switch (item)
            {
                case ScopeAccess.Inside:
                    return ScopeAccess.Lateral;

                case ScopeAccess.Lateral:
                    return ScopeAccess.Lateral;

                case ScopeAccess.Outside:
                    return ScopeAccess.Outside;
            }

            return ScopeAccess.Outside;
        }

        static public bool CanAccess(this ScopeAccess item, ScopeAccessLevel modifier)
        {
            switch (item)
            {
                case ScopeAccess.Inside:
                    return Enumerable.New(ScopeAccessLevel.Private, ScopeAccessLevel.Protected, ScopeAccessLevel.Public).Has(modifier);

                case ScopeAccess.Lateral:
                    return Enumerable.New(ScopeAccessLevel.Protected, ScopeAccessLevel.Public).Has(modifier);

                case ScopeAccess.Outside:
                    return Enumerable.New(ScopeAccessLevel.Public).Has(modifier);
            }

            return false;
        }

        static public bool CanAccess(this ScopeAccess item, Referenceable referenceable)
        {
            if (referenceable != null)
                return item.CanAccess(referenceable.GetScopeAccessLevel());

            return false;
        }
    }
}