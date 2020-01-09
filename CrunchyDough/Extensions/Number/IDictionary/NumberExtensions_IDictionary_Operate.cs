using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_IDictionary_Operate
    {
	
		static public int GetAddedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, KEY_TYPE key, int value)
		{
			return item.GetValue(key, 0) + value;
		}

		static public void AddNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, KEY_TYPE key, int value)
		{
			item[key] = item.GetAddedNumericValues(key, value);
		}

		static public void AddNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
		{
			foreach(KeyValuePair<KEY_TYPE, int> pair in other)
				item.AddNumericValues(pair.Key, pair.Value);
		}
		static public Dictionary<KEY_TYPE, int> GetAddedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
		{
			Dictionary<KEY_TYPE, int> result = new Dictionary<KEY_TYPE, int>(item);

			result.AddNumericValues(other);
			return result;
		}
	
		static public int GetSubtractedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, KEY_TYPE key, int value)
		{
			return item.GetValue(key, 0) - value;
		}

		static public void SubtractNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, KEY_TYPE key, int value)
		{
			item[key] = item.GetSubtractedNumericValues(key, value);
		}

		static public void SubtractNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
		{
			foreach(KeyValuePair<KEY_TYPE, int> pair in other)
				item.SubtractNumericValues(pair.Key, pair.Value);
		}
		static public Dictionary<KEY_TYPE, int> GetSubtractedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
		{
			Dictionary<KEY_TYPE, int> result = new Dictionary<KEY_TYPE, int>(item);

			result.SubtractNumericValues(other);
			return result;
		}
		
		static public Dictionary<KEY_TYPE, int> GetMultipliedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
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
	
	static public int GetSumOfSquaredNumericValueDifferences<KEY_TYPE>(this IDictionary<KEY_TYPE, int> item, IDictionary<KEY_TYPE, int> other)
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
	
		static public long GetAddedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, KEY_TYPE key, long value)
		{
			return item.GetValue(key, 0) + value;
		}

		static public void AddNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, KEY_TYPE key, long value)
		{
			item[key] = item.GetAddedNumericValues(key, value);
		}

		static public void AddNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
		{
			foreach(KeyValuePair<KEY_TYPE, long> pair in other)
				item.AddNumericValues(pair.Key, pair.Value);
		}
		static public Dictionary<KEY_TYPE, long> GetAddedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
		{
			Dictionary<KEY_TYPE, long> result = new Dictionary<KEY_TYPE, long>(item);

			result.AddNumericValues(other);
			return result;
		}
	
		static public long GetSubtractedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, KEY_TYPE key, long value)
		{
			return item.GetValue(key, 0) - value;
		}

		static public void SubtractNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, KEY_TYPE key, long value)
		{
			item[key] = item.GetSubtractedNumericValues(key, value);
		}

		static public void SubtractNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
		{
			foreach(KeyValuePair<KEY_TYPE, long> pair in other)
				item.SubtractNumericValues(pair.Key, pair.Value);
		}
		static public Dictionary<KEY_TYPE, long> GetSubtractedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
		{
			Dictionary<KEY_TYPE, long> result = new Dictionary<KEY_TYPE, long>(item);

			result.SubtractNumericValues(other);
			return result;
		}
		
		static public Dictionary<KEY_TYPE, long> GetMultipliedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
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
	
	static public long GetSumOfSquaredNumericValueDifferences<KEY_TYPE>(this IDictionary<KEY_TYPE, long> item, IDictionary<KEY_TYPE, long> other)
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
	
		static public float GetAddedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, KEY_TYPE key, float value)
		{
			return item.GetValue(key, 0.0f) + value;
		}

		static public void AddNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, KEY_TYPE key, float value)
		{
			item[key] = item.GetAddedNumericValues(key, value);
		}

		static public void AddNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
		{
			foreach(KeyValuePair<KEY_TYPE, float> pair in other)
				item.AddNumericValues(pair.Key, pair.Value);
		}
		static public Dictionary<KEY_TYPE, float> GetAddedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
		{
			Dictionary<KEY_TYPE, float> result = new Dictionary<KEY_TYPE, float>(item);

			result.AddNumericValues(other);
			return result;
		}
	
		static public float GetSubtractedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, KEY_TYPE key, float value)
		{
			return item.GetValue(key, 0.0f) - value;
		}

		static public void SubtractNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, KEY_TYPE key, float value)
		{
			item[key] = item.GetSubtractedNumericValues(key, value);
		}

		static public void SubtractNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
		{
			foreach(KeyValuePair<KEY_TYPE, float> pair in other)
				item.SubtractNumericValues(pair.Key, pair.Value);
		}
		static public Dictionary<KEY_TYPE, float> GetSubtractedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
		{
			Dictionary<KEY_TYPE, float> result = new Dictionary<KEY_TYPE, float>(item);

			result.SubtractNumericValues(other);
			return result;
		}
		
		static public Dictionary<KEY_TYPE, float> GetMultipliedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
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
	
	static public float GetSumOfSquaredNumericValueDifferences<KEY_TYPE>(this IDictionary<KEY_TYPE, float> item, IDictionary<KEY_TYPE, float> other)
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
	
		static public double GetAddedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, KEY_TYPE key, double value)
		{
			return item.GetValue(key, 0.0) + value;
		}

		static public void AddNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, KEY_TYPE key, double value)
		{
			item[key] = item.GetAddedNumericValues(key, value);
		}

		static public void AddNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
		{
			foreach(KeyValuePair<KEY_TYPE, double> pair in other)
				item.AddNumericValues(pair.Key, pair.Value);
		}
		static public Dictionary<KEY_TYPE, double> GetAddedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
		{
			Dictionary<KEY_TYPE, double> result = new Dictionary<KEY_TYPE, double>(item);

			result.AddNumericValues(other);
			return result;
		}
	
		static public double GetSubtractedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, KEY_TYPE key, double value)
		{
			return item.GetValue(key, 0.0) - value;
		}

		static public void SubtractNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, KEY_TYPE key, double value)
		{
			item[key] = item.GetSubtractedNumericValues(key, value);
		}

		static public void SubtractNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
		{
			foreach(KeyValuePair<KEY_TYPE, double> pair in other)
				item.SubtractNumericValues(pair.Key, pair.Value);
		}
		static public Dictionary<KEY_TYPE, double> GetSubtractedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
		{
			Dictionary<KEY_TYPE, double> result = new Dictionary<KEY_TYPE, double>(item);

			result.SubtractNumericValues(other);
			return result;
		}
		
		static public Dictionary<KEY_TYPE, double> GetMultipliedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
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
	
	static public double GetSumOfSquaredNumericValueDifferences<KEY_TYPE>(this IDictionary<KEY_TYPE, double> item, IDictionary<KEY_TYPE, double> other)
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
	
		static public decimal GetAddedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, KEY_TYPE key, decimal value)
		{
			return item.GetValue(key, 0.0m) + value;
		}

		static public void AddNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, KEY_TYPE key, decimal value)
		{
			item[key] = item.GetAddedNumericValues(key, value);
		}

		static public void AddNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
		{
			foreach(KeyValuePair<KEY_TYPE, decimal> pair in other)
				item.AddNumericValues(pair.Key, pair.Value);
		}
		static public Dictionary<KEY_TYPE, decimal> GetAddedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
		{
			Dictionary<KEY_TYPE, decimal> result = new Dictionary<KEY_TYPE, decimal>(item);

			result.AddNumericValues(other);
			return result;
		}
	
		static public decimal GetSubtractedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, KEY_TYPE key, decimal value)
		{
			return item.GetValue(key, 0.0m) - value;
		}

		static public void SubtractNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, KEY_TYPE key, decimal value)
		{
			item[key] = item.GetSubtractedNumericValues(key, value);
		}

		static public void SubtractNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
		{
			foreach(KeyValuePair<KEY_TYPE, decimal> pair in other)
				item.SubtractNumericValues(pair.Key, pair.Value);
		}
		static public Dictionary<KEY_TYPE, decimal> GetSubtractedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
		{
			Dictionary<KEY_TYPE, decimal> result = new Dictionary<KEY_TYPE, decimal>(item);

			result.SubtractNumericValues(other);
			return result;
		}
		
		static public Dictionary<KEY_TYPE, decimal> GetMultipliedNumericValues<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
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
	
	static public decimal GetSumOfSquaredNumericValueDifferences<KEY_TYPE>(this IDictionary<KEY_TYPE, decimal> item, IDictionary<KEY_TYPE, decimal> other)
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
