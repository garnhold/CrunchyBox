using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_IEnumerable_Operate
    {
		static public IEnumerable<int> GetSquaredValues(this IEnumerable<int> item)
		{
			return item.Convert(n => n.GetSquared());
		}
        
        static public IEnumerable<int> GetSquaredResiduals(this IEnumerable<int> item, IEnumerable<int> other)
        {
            return item.GetSubtractedValues(other).GetSquaredValues();
        }
        static public int GetTotalSquaredResiduals(this IEnumerable<int> item, IEnumerable<int> other)
        {
            return item.GetSquaredResiduals(other).Sum();
        }

		
			static public IEnumerable<int> GetAddedValues(this IEnumerable<int> item, IEnumerable<int> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 + n2);
			}
		
			static public IEnumerable<int> GetSubtractedValues(this IEnumerable<int> item, IEnumerable<int> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 - n2);
			}
		
			static public IEnumerable<int> GetMultipliedValues(this IEnumerable<int> item, IEnumerable<int> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 * n2);
			}
		
			static public IEnumerable<int> GetDividedValues(this IEnumerable<int> item, IEnumerable<int> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 / n2);
			}
				static public IEnumerable<long> GetSquaredValues(this IEnumerable<long> item)
		{
			return item.Convert(n => n.GetSquared());
		}
        
        static public IEnumerable<long> GetSquaredResiduals(this IEnumerable<long> item, IEnumerable<long> other)
        {
            return item.GetSubtractedValues(other).GetSquaredValues();
        }
        static public long GetTotalSquaredResiduals(this IEnumerable<long> item, IEnumerable<long> other)
        {
            return item.GetSquaredResiduals(other).Sum();
        }

		
			static public IEnumerable<long> GetAddedValues(this IEnumerable<long> item, IEnumerable<long> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 + n2);
			}
		
			static public IEnumerable<long> GetSubtractedValues(this IEnumerable<long> item, IEnumerable<long> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 - n2);
			}
		
			static public IEnumerable<long> GetMultipliedValues(this IEnumerable<long> item, IEnumerable<long> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 * n2);
			}
		
			static public IEnumerable<long> GetDividedValues(this IEnumerable<long> item, IEnumerable<long> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 / n2);
			}
				static public IEnumerable<float> GetSquaredValues(this IEnumerable<float> item)
		{
			return item.Convert(n => n.GetSquared());
		}
        
        static public IEnumerable<float> GetSquaredResiduals(this IEnumerable<float> item, IEnumerable<float> other)
        {
            return item.GetSubtractedValues(other).GetSquaredValues();
        }
        static public float GetTotalSquaredResiduals(this IEnumerable<float> item, IEnumerable<float> other)
        {
            return item.GetSquaredResiduals(other).Sum();
        }

		
			static public IEnumerable<float> GetAddedValues(this IEnumerable<float> item, IEnumerable<float> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 + n2);
			}
		
			static public IEnumerable<float> GetSubtractedValues(this IEnumerable<float> item, IEnumerable<float> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 - n2);
			}
		
			static public IEnumerable<float> GetMultipliedValues(this IEnumerable<float> item, IEnumerable<float> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 * n2);
			}
		
			static public IEnumerable<float> GetDividedValues(this IEnumerable<float> item, IEnumerable<float> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 / n2);
			}
				static public IEnumerable<double> GetSquaredValues(this IEnumerable<double> item)
		{
			return item.Convert(n => n.GetSquared());
		}
        
        static public IEnumerable<double> GetSquaredResiduals(this IEnumerable<double> item, IEnumerable<double> other)
        {
            return item.GetSubtractedValues(other).GetSquaredValues();
        }
        static public double GetTotalSquaredResiduals(this IEnumerable<double> item, IEnumerable<double> other)
        {
            return item.GetSquaredResiduals(other).Sum();
        }

		
			static public IEnumerable<double> GetAddedValues(this IEnumerable<double> item, IEnumerable<double> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 + n2);
			}
		
			static public IEnumerable<double> GetSubtractedValues(this IEnumerable<double> item, IEnumerable<double> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 - n2);
			}
		
			static public IEnumerable<double> GetMultipliedValues(this IEnumerable<double> item, IEnumerable<double> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 * n2);
			}
		
			static public IEnumerable<double> GetDividedValues(this IEnumerable<double> item, IEnumerable<double> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 / n2);
			}
				static public IEnumerable<decimal> GetSquaredValues(this IEnumerable<decimal> item)
		{
			return item.Convert(n => n.GetSquared());
		}
        
        static public IEnumerable<decimal> GetSquaredResiduals(this IEnumerable<decimal> item, IEnumerable<decimal> other)
        {
            return item.GetSubtractedValues(other).GetSquaredValues();
        }
        static public decimal GetTotalSquaredResiduals(this IEnumerable<decimal> item, IEnumerable<decimal> other)
        {
            return item.GetSquaredResiduals(other).Sum();
        }

		
			static public IEnumerable<decimal> GetAddedValues(this IEnumerable<decimal> item, IEnumerable<decimal> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 + n2);
			}
		
			static public IEnumerable<decimal> GetSubtractedValues(this IEnumerable<decimal> item, IEnumerable<decimal> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 - n2);
			}
		
			static public IEnumerable<decimal> GetMultipliedValues(this IEnumerable<decimal> item, IEnumerable<decimal> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 * n2);
			}
		
			static public IEnumerable<decimal> GetDividedValues(this IEnumerable<decimal> item, IEnumerable<decimal> other)
			{
				return item.PairStrict(other, (n1, n2) => n1 / n2);
			}
			}
}
