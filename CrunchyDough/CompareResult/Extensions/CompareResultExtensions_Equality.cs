using System;

namespace Crunchy.Dough
{
    static public class CompareResultExtensions_Equality
    {
        static public bool IsEqualTo(this CompareResult item)
        {
            switch (item)
            {
                case CompareResult.LessThan: return false;
                case CompareResult.GreaterThan: return false;
                case CompareResult.EqualTo: return true;
            }

            throw new UnaccountedBranchException("item", item);
        }
        static public bool IsNotEqualTo(this CompareResult item)
        {
            switch (item)
            {
                case CompareResult.LessThan: return true;
                case CompareResult.GreaterThan: return true;
                case CompareResult.EqualTo: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public bool IsLessThan(this CompareResult item)
        {
            switch (item)
            {
                case CompareResult.LessThan: return true;
                case CompareResult.GreaterThan: return false;
                case CompareResult.EqualTo: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }
        static public bool IsLessThanOrEqualTo(this CompareResult item)
        {
            switch (item)
            {
                case CompareResult.LessThan: return true;
                case CompareResult.GreaterThan: return false;
                case CompareResult.EqualTo: return true;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public bool IsGreaterThan(this CompareResult item)
        {
            switch (item)
            {
                case CompareResult.LessThan: return false;
                case CompareResult.GreaterThan: return true;
                case CompareResult.EqualTo: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }
        static public bool IsGreaterThanOrEqualTo(this CompareResult item)
        {
            switch (item)
            {
                case CompareResult.LessThan: return false;
                case CompareResult.GreaterThan: return true;
                case CompareResult.EqualTo: return true;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}