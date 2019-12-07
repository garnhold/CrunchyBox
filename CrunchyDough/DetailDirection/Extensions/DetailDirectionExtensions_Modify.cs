using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class DetailDirectionExtensions_Modify
    {
        static public IEnumerable<T> ModifyBasicToSpecificSequence<T>(this IEnumerable<T> item, DetailDirection direction)
        {
            switch (direction)
            {
                case DetailDirection.BasicToSpecific: return item;
                case DetailDirection.SpecificToBasic: return item.Reverse();
            }

            throw new UnaccountedBranchException("direction", direction);
        }

        static public IEnumerable<T> ModifySpecificToBasicSequence<T>(this IEnumerable<T> item, DetailDirection direction)
        {
            switch (direction)
            {
                case DetailDirection.BasicToSpecific: return item.Reverse();
                case DetailDirection.SpecificToBasic: return item;
            }

            throw new UnaccountedBranchException("direction", direction);
        }
    }
}