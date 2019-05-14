using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	static public class NumberExtensions_IDictionary_Operate
    {
	
		static public void AddValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
		{
			foreach(KeyValuePair<KEY_TYPE, int> pair in other)
				item[pair.Key] = item.GetValue(pair.Key, 0) + pair.Value;
		}
		static public Dictionary<KEY_TYPE, int> GetAddedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
		{
			Dictionary<KEY_TYPE, int> result = new Dictionary<KEY_TYPE, int>(item);

			result.AddValues(other);
			return result;
		}
	
		static public void SubtractValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
		{
			foreach(KeyValuePair<KEY_TYPE, int> pair in other)
				item[pair.Key] = item.GetValue(pair.Key, 0) - pair.Value;
		}
		static public Dictionary<KEY_TYPE, int> GetSubtractedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
		{
			Dictionary<KEY_TYPE, int> result = new Dictionary<KEY_TYPE, int>(item);

			result.SubtractValues(other);
			return result;
		}
		
		static public Dictionary<KEY_TYPE, int> GetMultipliedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
		{
			Dictionary<KEY_TYPE, int> result = new Dictionary<KEY_TYPE, int>();

			foreach(KeyValuePair<KEY_TYPE, int> pair in other)
			{
				int item_value;

				if(item.TryGetValue(pair.Key, out item_value))
					result[pair.Key] = item_value * pair.Value;
			}

			return result;
		}
	
	static public int GetSumOfSquaredValueDifferences<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
	{
		int sum_of_squared_differences = 0;

		foreach(KeyValuePair<KEY_TYPE, int> pair in item)
		{
			int other_value;

			if(other.TryGetValue(pair.Key, out other_value))
				sum_of_squared_differences += (pair.Value - other_value).GetSquared();
			else
				sum_of_squared_differences += pair.Value.GetSquared();
		}

		foreach(KeyValuePair<KEY_TYPE, int> pair in other)
		{
			if(item.ContainsKey(pair.Key) == false)
				sum_of_squared_differences += pair.Value.GetSquared();
		}

		return sum_of_squared_differences;
	}
	
		static public void AddValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
		{
			foreach(KeyValuePair<KEY_TYPE, long> pair in other)
				item[pair.Key] = item.GetValue(pair.Key, 0) + pair.Value;
		}
		static public Dictionary<KEY_TYPE, long> GetAddedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
		{
			Dictionary<KEY_TYPE, long> result = new Dictionary<KEY_TYPE, long>(item);

			result.AddValues(other);
			return result;
		}
	
		static public void SubtractValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
		{
			foreach(KeyValuePair<KEY_TYPE, long> pair in other)
				item[pair.Key] = item.GetValue(pair.Key, 0) - pair.Value;
		}
		static public Dictionary<KEY_TYPE, long> GetSubtractedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
		{
			Dictionary<KEY_TYPE, long> result = new Dictionary<KEY_TYPE, long>(item);

			result.SubtractValues(other);
			return result;
		}
		
		static public Dictionary<KEY_TYPE, long> GetMultipliedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
		{
			Dictionary<KEY_TYPE, long> result = new Dictionary<KEY_TYPE, long>();

			foreach(KeyValuePair<KEY_TYPE, long> pair in other)
			{
				long item_value;

				if(item.TryGetValue(pair.Key, out item_value))
					result[pair.Key] = item_value * pair.Value;
			}

			return result;
		}
	
	static public long GetSumOfSquaredValueDifferences<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
	{
		long sum_of_squared_differences = 0;

		foreach(KeyValuePair<KEY_TYPE, long> pair in item)
		{
			long other_value;

			if(other.TryGetValue(pair.Key, out other_value))
				sum_of_squared_differences += (pair.Value - other_value).GetSquared();
			else
				sum_of_squared_differences += pair.Value.GetSquared();
		}

		foreach(KeyValuePair<KEY_TYPE, long> pair in other)
		{
			if(item.ContainsKey(pair.Key) == false)
				sum_of_squared_differences += pair.Value.GetSquared();
		}

		return sum_of_squared_differences;
	}
	
		static public void AddValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
		{
			foreach(KeyValuePair<KEY_TYPE, float> pair in other)
				item[pair.Key] = item.GetValue(pair.Key, 0.0f) + pair.Value;
		}
		static public Dictionary<KEY_TYPE, float> GetAddedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
		{
			Dictionary<KEY_TYPE, float> result = new Dictionary<KEY_TYPE, float>(item);

			result.AddValues(other);
			return result;
		}
	
		static public void SubtractValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
		{
			foreach(KeyValuePair<KEY_TYPE, float> pair in other)
				item[pair.Key] = item.GetValue(pair.Key, 0.0f) - pair.Value;
		}
		static public Dictionary<KEY_TYPE, float> GetSubtractedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
		{
			Dictionary<KEY_TYPE, float> result = new Dictionary<KEY_TYPE, float>(item);

			result.SubtractValues(other);
			return result;
		}
		
		static public Dictionary<KEY_TYPE, float> GetMultipliedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
		{
			Dictionary<KEY_TYPE, float> result = new Dictionary<KEY_TYPE, float>();

			foreach(KeyValuePair<KEY_TYPE, float> pair in other)
			{
				float item_value;

				if(item.TryGetValue(pair.Key, out item_value))
					result[pair.Key] = item_value * pair.Value;
			}

			return result;
		}
	
	static public float GetSumOfSquaredValueDifferences<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
	{
		float sum_of_squared_differences = 0.0f;

		foreach(KeyValuePair<KEY_TYPE, float> pair in item)
		{
			float other_value;

			if(other.TryGetValue(pair.Key, out other_value))
				sum_of_squared_differences += (pair.Value - other_value).GetSquared();
			else
				sum_of_squared_differences += pair.Value.GetSquared();
		}

		foreach(KeyValuePair<KEY_TYPE, float> pair in other)
		{
			if(item.ContainsKey(pair.Key) == false)
				sum_of_squared_differences += pair.Value.GetSquared();
		}

		return sum_of_squared_differences;
	}
	
		static public void AddValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
		{
			foreach(KeyValuePair<KEY_TYPE, double> pair in other)
				item[pair.Key] = item.GetValue(pair.Key, 0.0) + pair.Value;
		}
		static public Dictionary<KEY_TYPE, double> GetAddedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
		{
			Dictionary<KEY_TYPE, double> result = new Dictionary<KEY_TYPE, double>(item);

			result.AddValues(other);
			return result;
		}
	
		static public void SubtractValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
		{
			foreach(KeyValuePair<KEY_TYPE, double> pair in other)
				item[pair.Key] = item.GetValue(pair.Key, 0.0) - pair.Value;
		}
		static public Dictionary<KEY_TYPE, double> GetSubtractedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
		{
			Dictionary<KEY_TYPE, double> result = new Dictionary<KEY_TYPE, double>(item);

			result.SubtractValues(other);
			return result;
		}
		
		static public Dictionary<KEY_TYPE, double> GetMultipliedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
		{
			Dictionary<KEY_TYPE, double> result = new Dictionary<KEY_TYPE, double>();

			foreach(KeyValuePair<KEY_TYPE, double> pair in other)
			{
				double item_value;

				if(item.TryGetValue(pair.Key, out item_value))
					result[pair.Key] = item_value * pair.Value;
			}

			return result;
		}
	
	static public double GetSumOfSquaredValueDifferences<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
	{
		double sum_of_squared_differences = 0.0;

		foreach(KeyValuePair<KEY_TYPE, double> pair in item)
		{
			double other_value;

			if(other.TryGetValue(pair.Key, out other_value))
				sum_of_squared_differences += (pair.Value - other_value).GetSquared();
			else
				sum_of_squared_differences += pair.Value.GetSquared();
		}

		foreach(KeyValuePair<KEY_TYPE, double> pair in other)
		{
			if(item.ContainsKey(pair.Key) == false)
				sum_of_squared_differences += pair.Value.GetSquared();
		}

		return sum_of_squared_differences;
	}
	
		static public void AddValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
		{
			foreach(KeyValuePair<KEY_TYPE, decimal> pair in other)
				item[pair.Key] = item.GetValue(pair.Key, 0.0m) + pair.Value;
		}
		static public Dictionary<KEY_TYPE, decimal> GetAddedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
		{
			Dictionary<KEY_TYPE, decimal> result = new Dictionary<KEY_TYPE, decimal>(item);

			result.AddValues(other);
			return result;
		}
	
		static public void SubtractValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
		{
			foreach(KeyValuePair<KEY_TYPE, decimal> pair in other)
				item[pair.Key] = item.GetValue(pair.Key, 0.0m) - pair.Value;
		}
		static public Dictionary<KEY_TYPE, decimal> GetSubtractedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
		{
			Dictionary<KEY_TYPE, decimal> result = new Dictionary<KEY_TYPE, decimal>(item);

			result.SubtractValues(other);
			return result;
		}
		
		static public Dictionary<KEY_TYPE, decimal> GetMultipliedValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
		{
			Dictionary<KEY_TYPE, decimal> result = new Dictionary<KEY_TYPE, decimal>();

			foreach(KeyValuePair<KEY_TYPE, decimal> pair in other)
			{
				decimal item_value;

				if(item.TryGetValue(pair.Key, out item_value))
					result[pair.Key] = item_value * pair.Value;
			}

			return result;
		}
	
	static public decimal GetSumOfSquaredValueDifferences<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
	{
		decimal sum_of_squared_differences = 0.0m;

		foreach(KeyValuePair<KEY_TYPE, decimal> pair in item)
		{
			decimal other_value;

			if(other.TryGetValue(pair.Key, out other_value))
				sum_of_squared_differences += (pair.Value - other_value).GetSquared();
			else
				sum_of_squared_differences += pair.Value.GetSquared();
		}

		foreach(KeyValuePair<KEY_TYPE, decimal> pair in other)
		{
			if(item.ContainsKey(pair.Key) == false)
				sum_of_squared_differences += pair.Value.GetSquared();
		}

		return sum_of_squared_differences;
	}
	}
}
