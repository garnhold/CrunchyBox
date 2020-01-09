using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_PartOut
    {
		
        static public int PartOut<T>(this IEnumerable<T> item, out T output1)
        {
					output1 = default(T);
		
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1 = iterator.Current;
											return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<T> item, out T output1, out T output2)
        {
					output1 = default(T);
					output2 = default(T);
		
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1 = iterator.Current;
							if (iterator.MoveNext())
				{
					output2 = iterator.Current;
											return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<T> item, out T output1, out T output2, out T output3)
        {
					output1 = default(T);
					output2 = default(T);
					output3 = default(T);
		
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1 = iterator.Current;
							if (iterator.MoveNext())
				{
					output2 = iterator.Current;
							if (iterator.MoveNext())
				{
					output3 = iterator.Current;
											return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<T> item, out T output1, out T output2, out T output3, out T output4)
        {
					output1 = default(T);
					output2 = default(T);
					output3 = default(T);
					output4 = default(T);
		
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1 = iterator.Current;
							if (iterator.MoveNext())
				{
					output2 = iterator.Current;
							if (iterator.MoveNext())
				{
					output3 = iterator.Current;
							if (iterator.MoveNext())
				{
					output4 = iterator.Current;
											return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<T> item, out T output1, out T output2, out T output3, out T output4, out T output5)
        {
					output1 = default(T);
					output2 = default(T);
					output3 = default(T);
					output4 = default(T);
					output5 = default(T);
		
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1 = iterator.Current;
							if (iterator.MoveNext())
				{
					output2 = iterator.Current;
							if (iterator.MoveNext())
				{
					output3 = iterator.Current;
							if (iterator.MoveNext())
				{
					output4 = iterator.Current;
							if (iterator.MoveNext())
				{
					output5 = iterator.Current;
											return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<T> item, out T output1, out T output2, out T output3, out T output4, out T output5, out T output6)
        {
					output1 = default(T);
					output2 = default(T);
					output3 = default(T);
					output4 = default(T);
					output5 = default(T);
					output6 = default(T);
		
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1 = iterator.Current;
							if (iterator.MoveNext())
				{
					output2 = iterator.Current;
							if (iterator.MoveNext())
				{
					output3 = iterator.Current;
							if (iterator.MoveNext())
				{
					output4 = iterator.Current;
							if (iterator.MoveNext())
				{
					output5 = iterator.Current;
							if (iterator.MoveNext())
				{
					output6 = iterator.Current;
											return 6;
				}
								return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<T> item, out T output1, out T output2, out T output3, out T output4, out T output5, out T output6, out T output7)
        {
					output1 = default(T);
					output2 = default(T);
					output3 = default(T);
					output4 = default(T);
					output5 = default(T);
					output6 = default(T);
					output7 = default(T);
		
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1 = iterator.Current;
							if (iterator.MoveNext())
				{
					output2 = iterator.Current;
							if (iterator.MoveNext())
				{
					output3 = iterator.Current;
							if (iterator.MoveNext())
				{
					output4 = iterator.Current;
							if (iterator.MoveNext())
				{
					output5 = iterator.Current;
							if (iterator.MoveNext())
				{
					output6 = iterator.Current;
							if (iterator.MoveNext())
				{
					output7 = iterator.Current;
											return 7;
				}
								return 6;
				}
								return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<T> item, out T output1, out T output2, out T output3, out T output4, out T output5, out T output6, out T output7, out T output8)
        {
					output1 = default(T);
					output2 = default(T);
					output3 = default(T);
					output4 = default(T);
					output5 = default(T);
					output6 = default(T);
					output7 = default(T);
					output8 = default(T);
		
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1 = iterator.Current;
							if (iterator.MoveNext())
				{
					output2 = iterator.Current;
							if (iterator.MoveNext())
				{
					output3 = iterator.Current;
							if (iterator.MoveNext())
				{
					output4 = iterator.Current;
							if (iterator.MoveNext())
				{
					output5 = iterator.Current;
							if (iterator.MoveNext())
				{
					output6 = iterator.Current;
							if (iterator.MoveNext())
				{
					output7 = iterator.Current;
							if (iterator.MoveNext())
				{
					output8 = iterator.Current;
											return 8;
				}
								return 7;
				}
								return 6;
				}
								return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<T> item, out T output1, out T output2, out T output3, out T output4, out T output5, out T output6, out T output7, out T output8, out T output9)
        {
					output1 = default(T);
					output2 = default(T);
					output3 = default(T);
					output4 = default(T);
					output5 = default(T);
					output6 = default(T);
					output7 = default(T);
					output8 = default(T);
					output9 = default(T);
		
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1 = iterator.Current;
							if (iterator.MoveNext())
				{
					output2 = iterator.Current;
							if (iterator.MoveNext())
				{
					output3 = iterator.Current;
							if (iterator.MoveNext())
				{
					output4 = iterator.Current;
							if (iterator.MoveNext())
				{
					output5 = iterator.Current;
							if (iterator.MoveNext())
				{
					output6 = iterator.Current;
							if (iterator.MoveNext())
				{
					output7 = iterator.Current;
							if (iterator.MoveNext())
				{
					output8 = iterator.Current;
							if (iterator.MoveNext())
				{
					output9 = iterator.Current;
											return 9;
				}
								return 8;
				}
								return 7;
				}
								return 6;
				}
								return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<T> item, out T output1, out T output2, out T output3, out T output4, out T output5, out T output6, out T output7, out T output8, out T output9, out T output10)
        {
					output1 = default(T);
					output2 = default(T);
					output3 = default(T);
					output4 = default(T);
					output5 = default(T);
					output6 = default(T);
					output7 = default(T);
					output8 = default(T);
					output9 = default(T);
					output10 = default(T);
		
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1 = iterator.Current;
							if (iterator.MoveNext())
				{
					output2 = iterator.Current;
							if (iterator.MoveNext())
				{
					output3 = iterator.Current;
							if (iterator.MoveNext())
				{
					output4 = iterator.Current;
							if (iterator.MoveNext())
				{
					output5 = iterator.Current;
							if (iterator.MoveNext())
				{
					output6 = iterator.Current;
							if (iterator.MoveNext())
				{
					output7 = iterator.Current;
							if (iterator.MoveNext())
				{
					output8 = iterator.Current;
							if (iterator.MoveNext())
				{
					output9 = iterator.Current;
							if (iterator.MoveNext())
				{
					output10 = iterator.Current;
											return 10;
				}
								return 9;
				}
								return 8;
				}
								return 7;
				}
								return 6;
				}
								return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
	
		
        static public int PartOut<T>(this IEnumerable<IEnumerable<T>> item, ICollection<T> output1)
        {
							output1.Clear();
			
            using (IEnumerator<IEnumerable<T>> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1.AddRange(iterator.Current);
											return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<IEnumerable<T>> item, ICollection<T> output1, ICollection<T> output2)
        {
							output1.Clear();
							output2.Clear();
			
            using (IEnumerator<IEnumerable<T>> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output2.AddRange(iterator.Current);
											return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<IEnumerable<T>> item, ICollection<T> output1, ICollection<T> output2, ICollection<T> output3)
        {
							output1.Clear();
							output2.Clear();
							output3.Clear();
			
            using (IEnumerator<IEnumerable<T>> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output2.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output3.AddRange(iterator.Current);
											return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<IEnumerable<T>> item, ICollection<T> output1, ICollection<T> output2, ICollection<T> output3, ICollection<T> output4)
        {
							output1.Clear();
							output2.Clear();
							output3.Clear();
							output4.Clear();
			
            using (IEnumerator<IEnumerable<T>> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output2.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output3.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output4.AddRange(iterator.Current);
											return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<IEnumerable<T>> item, ICollection<T> output1, ICollection<T> output2, ICollection<T> output3, ICollection<T> output4, ICollection<T> output5)
        {
							output1.Clear();
							output2.Clear();
							output3.Clear();
							output4.Clear();
							output5.Clear();
			
            using (IEnumerator<IEnumerable<T>> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output2.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output3.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output4.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output5.AddRange(iterator.Current);
											return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<IEnumerable<T>> item, ICollection<T> output1, ICollection<T> output2, ICollection<T> output3, ICollection<T> output4, ICollection<T> output5, ICollection<T> output6)
        {
							output1.Clear();
							output2.Clear();
							output3.Clear();
							output4.Clear();
							output5.Clear();
							output6.Clear();
			
            using (IEnumerator<IEnumerable<T>> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output2.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output3.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output4.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output5.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output6.AddRange(iterator.Current);
											return 6;
				}
								return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<IEnumerable<T>> item, ICollection<T> output1, ICollection<T> output2, ICollection<T> output3, ICollection<T> output4, ICollection<T> output5, ICollection<T> output6, ICollection<T> output7)
        {
							output1.Clear();
							output2.Clear();
							output3.Clear();
							output4.Clear();
							output5.Clear();
							output6.Clear();
							output7.Clear();
			
            using (IEnumerator<IEnumerable<T>> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output2.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output3.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output4.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output5.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output6.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output7.AddRange(iterator.Current);
											return 7;
				}
								return 6;
				}
								return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<IEnumerable<T>> item, ICollection<T> output1, ICollection<T> output2, ICollection<T> output3, ICollection<T> output4, ICollection<T> output5, ICollection<T> output6, ICollection<T> output7, ICollection<T> output8)
        {
							output1.Clear();
							output2.Clear();
							output3.Clear();
							output4.Clear();
							output5.Clear();
							output6.Clear();
							output7.Clear();
							output8.Clear();
			
            using (IEnumerator<IEnumerable<T>> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output2.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output3.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output4.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output5.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output6.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output7.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output8.AddRange(iterator.Current);
											return 8;
				}
								return 7;
				}
								return 6;
				}
								return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<IEnumerable<T>> item, ICollection<T> output1, ICollection<T> output2, ICollection<T> output3, ICollection<T> output4, ICollection<T> output5, ICollection<T> output6, ICollection<T> output7, ICollection<T> output8, ICollection<T> output9)
        {
							output1.Clear();
							output2.Clear();
							output3.Clear();
							output4.Clear();
							output5.Clear();
							output6.Clear();
							output7.Clear();
							output8.Clear();
							output9.Clear();
			
            using (IEnumerator<IEnumerable<T>> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output2.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output3.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output4.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output5.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output6.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output7.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output8.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output9.AddRange(iterator.Current);
											return 9;
				}
								return 8;
				}
								return 7;
				}
								return 6;
				}
								return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		
        static public int PartOut<T>(this IEnumerable<IEnumerable<T>> item, ICollection<T> output1, ICollection<T> output2, ICollection<T> output3, ICollection<T> output4, ICollection<T> output5, ICollection<T> output6, ICollection<T> output7, ICollection<T> output8, ICollection<T> output9, ICollection<T> output10)
        {
							output1.Clear();
							output2.Clear();
							output3.Clear();
							output4.Clear();
							output5.Clear();
							output6.Clear();
							output7.Clear();
							output8.Clear();
							output9.Clear();
							output10.Clear();
			
            using (IEnumerator<IEnumerable<T>> iterator = item.GetEnumerator())
            {
							if (iterator.MoveNext())
				{
					output1.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output2.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output3.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output4.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output5.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output6.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output7.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output8.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output9.AddRange(iterator.Current);
							if (iterator.MoveNext())
				{
					output10.AddRange(iterator.Current);
											return 10;
				}
								return 9;
				}
								return 8;
				}
								return 7;
				}
								return 6;
				}
								return 5;
				}
								return 4;
				}
								return 3;
				}
								return 2;
				}
								return 1;
				}
			            }

            return 0;
        }
		}
}