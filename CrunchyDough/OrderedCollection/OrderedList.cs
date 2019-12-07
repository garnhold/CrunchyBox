using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	public partial class StaticOrderList<T> : IList<T>
    {
        private IComparer<T> comparer;
        private List<T> list;

        public int Count { get { return list.Count; } }
        public bool IsReadOnly { get { return false; } }

		public T this[int index]
		{
			get
			{
				Sort();

				return list[index];
			}
			
			set
			{
				throw new InvalidOperationException("OrderedLists do not support directly setting items.");
			}
		}

        public StaticOrderList(IComparer<T> c, IEnumerable<T> i)
        {
            comparer = c;
            list = i.ToList();
        }

        public StaticOrderList(IEnumerable<T> i) : this(Comparer<T>.Default, i) { }

        public StaticOrderList(IComparer<T> c, params T[] i) : this(c, (IEnumerable<T>)i) { }
        public StaticOrderList(params T[] i) : this(Comparer<T>.Default, i) { }

        public StaticOrderList(Comparison<T> c, IEnumerable<T> i) : this(new ComparisonComparer<T>(c), i) { }
        public StaticOrderList(Comparison<T> c, params T[] i) : this(c, (IEnumerable<T>)i) { }

		public void Insert(int index, T item)
		{
			throw new InvalidOperationException("OrderedLists do not support inserting items.");
		}

		public void RemoveAt(int index)
		{
			Sort();

			list.RemoveAt(index);
		}

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

		public int IndexOf(T item)
		{
			Sort();

			return list.IndexOf(item);
		}

        public void CopyTo(T[] array, int index)
        {
            Sort();

            list.CopyTo(array, index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            Sort();

            return list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
	public partial class DynamicOrderList<T> : IList<T>
    {
        private IComparer<T> comparer;
        private List<T> list;

        public int Count { get { return list.Count; } }
        public bool IsReadOnly { get { return false; } }

		public T this[int index]
		{
			get
			{
				Sort();

				return list[index];
			}
			
			set
			{
				throw new InvalidOperationException("OrderedLists do not support directly setting items.");
			}
		}

        public DynamicOrderList(IComparer<T> c, IEnumerable<T> i)
        {
            comparer = c;
            list = i.ToList();
        }

        public DynamicOrderList(IEnumerable<T> i) : this(Comparer<T>.Default, i) { }

        public DynamicOrderList(IComparer<T> c, params T[] i) : this(c, (IEnumerable<T>)i) { }
        public DynamicOrderList(params T[] i) : this(Comparer<T>.Default, i) { }

        public DynamicOrderList(Comparison<T> c, IEnumerable<T> i) : this(new ComparisonComparer<T>(c), i) { }
        public DynamicOrderList(Comparison<T> c, params T[] i) : this(c, (IEnumerable<T>)i) { }

		public void Insert(int index, T item)
		{
			throw new InvalidOperationException("OrderedLists do not support inserting items.");
		}

		public void RemoveAt(int index)
		{
			Sort();

			list.RemoveAt(index);
		}

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

		public int IndexOf(T item)
		{
			Sort();

			return list.IndexOf(item);
		}

        public void CopyTo(T[] array, int index)
        {
            Sort();

            list.CopyTo(array, index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            Sort();

            return list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}