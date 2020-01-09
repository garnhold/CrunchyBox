using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ArrayPoolExtensions_UseEnumerate
    {
        public delegate int ArrayInitializer<T>(ref T[] array);
        public delegate void ArrayFinalizer<T>(ref T[] array, int length);

        static private IEnumerable<T> UseEnumerate<T>(this ArrayPool<T> item, ArrayInitializer<T> initializer, ArrayFinalizer<T> finalizer)
        {
            using (Pooled<T[]> pooled = item.Withdraw())
            {
                T[] array = pooled.Get();
                int length = initializer(ref array);

                try
                {
                    for (int i = 0; i < length; i++)
                        yield return array[i];
                }
                finally
                {
                    finalizer(ref array, length);
                    pooled.Set(array);
                }
            }
        }

        static public IEnumerable<T> UseEnumerate<T>(this ArrayPool<T> item, Operation<int, T[]> operation)
        {
            return item.UseEnumerate(delegate(ref T[] array) {
                return operation(array);
            }, delegate(ref T[] array, int length) { });
        }

        static public IEnumerable<T> UseEnumerateExpand<T>(this ArrayPool<T> item, Operation<int, T[], int> operation)
        {
            return item.UseEnumerate(delegate(ref T[] array) {
                int length = 0;

                while ((length = operation(array, length)) >= array.Length)
                    array = array.CopyGrow();

                return length;
            }, delegate(ref T[] array, int length) { });
        }
        static public IEnumerable<T> UseEnumerateExpand<T>(this ArrayPool<T> item, Operation<int, T[]> operation)
        {
            return item.UseEnumerateExpand((a, i) => operation(a));
        }

        static public IEnumerable<T> UseEnumerateExpandForFuture<T>(this ArrayPool<T> item, Operation<int, T[]> operation)
        {
            return item.UseEnumerate(delegate(ref T[] array) {
                return operation(array);
            }, delegate(ref T[] array, int length) {
                if (length >= array.Length)
                    array = new T[length * 2];
            });
        }
    }
}