using System;

namespace CrunchyDough
{
    static public class EqualityRelationExtensions
    {
        static public bool IsSatisifed(this EqualityRelation item, object o1, object o2)
        {
            switch (item)
            {
                case EqualityRelation.EqualTo: return o1.EqualsEX(o2);
                case EqualityRelation.NotEqualTo: return o1.NotEqualsEX(o2);
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}