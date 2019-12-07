using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	
    static public class Ints
	{
		static public IEnumerable<int> Ray(int start, int step, int divisions)
		{
			for(int i = 0; i < divisions; i++)
				yield return start + i * step;
		}

		static public IEnumerable<int> Line(int start, int end, int divisions, bool include_end)
		{
			int step;

			if(include_end)
				step = (end - start) / (divisions - 1);
			else
				step = (end - start) / divisions;

			return Ray(start, step, divisions);
		}

		static public IEnumerable<int> Range(int start, int end, int step, bool include_end)
		{
			int divisions = (int)((end - start) / step).GetAbs();

			if(include_end)
				divisions++;

			if(start < end)
				return Ray(start, step.GetPositive(), divisions);

			return Ray(start, step.GetNegative(), divisions);
		}
		static public IEnumerable<int> Range(int start, int end, bool include_end)
		{
			return Range(start, end, 1, include_end);
		}
	}
	static public class IntsExtensions_Process
	{
		static public void ProcessWithIntsRay<T>(this ICollection<T> item, int start, int step, Process<int, T> process)
		{
			Ints.Ray(start, step, item.Count).ProcessTandemStrict(item, process);
		}

		static public void ProcessWithIntsLine<T>(this ICollection<T> item, int start, int end, bool include_end, Process<int, T> process)
		{
			Ints.Line(start, end, item.Count, include_end).ProcessTandemStrict(item, process);
		}
	}

	
    static public class Longs
	{
		static public IEnumerable<long> Ray(long start, long step, int divisions)
		{
			for(int i = 0; i < divisions; i++)
				yield return start + i * step;
		}

		static public IEnumerable<long> Line(long start, long end, int divisions, bool include_end)
		{
			long step;

			if(include_end)
				step = (end - start) / (divisions - 1);
			else
				step = (end - start) / divisions;

			return Ray(start, step, divisions);
		}

		static public IEnumerable<long> Range(long start, long end, long step, bool include_end)
		{
			int divisions = (int)((end - start) / step).GetAbs();

			if(include_end)
				divisions++;

			if(start < end)
				return Ray(start, step.GetPositive(), divisions);

			return Ray(start, step.GetNegative(), divisions);
		}
		static public IEnumerable<long> Range(long start, long end, bool include_end)
		{
			return Range(start, end, 1, include_end);
		}
	}
	static public class LongsExtensions_Process
	{
		static public void ProcessWithLongsRay<T>(this ICollection<T> item, long start, long step, Process<long, T> process)
		{
			Longs.Ray(start, step, item.Count).ProcessTandemStrict(item, process);
		}

		static public void ProcessWithLongsLine<T>(this ICollection<T> item, long start, long end, bool include_end, Process<long, T> process)
		{
			Longs.Line(start, end, item.Count, include_end).ProcessTandemStrict(item, process);
		}
	}

	
    static public class Floats
	{
		static public IEnumerable<float> Ray(float start, float step, int divisions)
		{
			for(int i = 0; i < divisions; i++)
				yield return start + i * step;
		}

		static public IEnumerable<float> Line(float start, float end, int divisions, bool include_end)
		{
			float step;

			if(include_end)
				step = (end - start) / (divisions - 1);
			else
				step = (end - start) / divisions;

			return Ray(start, step, divisions);
		}

		static public IEnumerable<float> Range(float start, float end, float step, bool include_end)
		{
			int divisions = (int)((end - start) / step).GetAbs();

			if(include_end)
				divisions++;

			if(start < end)
				return Ray(start, step.GetPositive(), divisions);

			return Ray(start, step.GetNegative(), divisions);
		}
		static public IEnumerable<float> Range(float start, float end, bool include_end)
		{
			return Range(start, end, 1, include_end);
		}
	}
	static public class FloatsExtensions_Process
	{
		static public void ProcessWithFloatsRay<T>(this ICollection<T> item, float start, float step, Process<float, T> process)
		{
			Floats.Ray(start, step, item.Count).ProcessTandemStrict(item, process);
		}

		static public void ProcessWithFloatsLine<T>(this ICollection<T> item, float start, float end, bool include_end, Process<float, T> process)
		{
			Floats.Line(start, end, item.Count, include_end).ProcessTandemStrict(item, process);
		}
	}

	
    static public class Doubles
	{
		static public IEnumerable<double> Ray(double start, double step, int divisions)
		{
			for(int i = 0; i < divisions; i++)
				yield return start + i * step;
		}

		static public IEnumerable<double> Line(double start, double end, int divisions, bool include_end)
		{
			double step;

			if(include_end)
				step = (end - start) / (divisions - 1);
			else
				step = (end - start) / divisions;

			return Ray(start, step, divisions);
		}

		static public IEnumerable<double> Range(double start, double end, double step, bool include_end)
		{
			int divisions = (int)((end - start) / step).GetAbs();

			if(include_end)
				divisions++;

			if(start < end)
				return Ray(start, step.GetPositive(), divisions);

			return Ray(start, step.GetNegative(), divisions);
		}
		static public IEnumerable<double> Range(double start, double end, bool include_end)
		{
			return Range(start, end, 1, include_end);
		}
	}
	static public class DoublesExtensions_Process
	{
		static public void ProcessWithDoublesRay<T>(this ICollection<T> item, double start, double step, Process<double, T> process)
		{
			Doubles.Ray(start, step, item.Count).ProcessTandemStrict(item, process);
		}

		static public void ProcessWithDoublesLine<T>(this ICollection<T> item, double start, double end, bool include_end, Process<double, T> process)
		{
			Doubles.Line(start, end, item.Count, include_end).ProcessTandemStrict(item, process);
		}
	}

	
    static public class Decimals
	{
		static public IEnumerable<decimal> Ray(decimal start, decimal step, int divisions)
		{
			for(int i = 0; i < divisions; i++)
				yield return start + i * step;
		}

		static public IEnumerable<decimal> Line(decimal start, decimal end, int divisions, bool include_end)
		{
			decimal step;

			if(include_end)
				step = (end - start) / (divisions - 1);
			else
				step = (end - start) / divisions;

			return Ray(start, step, divisions);
		}

		static public IEnumerable<decimal> Range(decimal start, decimal end, decimal step, bool include_end)
		{
			int divisions = (int)((end - start) / step).GetAbs();

			if(include_end)
				divisions++;

			if(start < end)
				return Ray(start, step.GetPositive(), divisions);

			return Ray(start, step.GetNegative(), divisions);
		}
		static public IEnumerable<decimal> Range(decimal start, decimal end, bool include_end)
		{
			return Range(start, end, 1, include_end);
		}
	}
	static public class DecimalsExtensions_Process
	{
		static public void ProcessWithDecimalsRay<T>(this ICollection<T> item, decimal start, decimal step, Process<decimal, T> process)
		{
			Decimals.Ray(start, step, item.Count).ProcessTandemStrict(item, process);
		}

		static public void ProcessWithDecimalsLine<T>(this ICollection<T> item, decimal start, decimal end, bool include_end, Process<decimal, T> process)
		{
			Decimals.Line(start, end, item.Count, include_end).ProcessTandemStrict(item, process);
		}
	}

}

