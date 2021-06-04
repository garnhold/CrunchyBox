using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ValueExtensions_TraverseTree
    {
        static public IEnumerable<T> TraverseTree<T>(this T item, Operation<IEnumerable<T>, T> operation)
        {
            foreach (T sub_item in operation(item))
            {
                if (sub_item != null)
                {
                    yield return sub_item;

                    foreach (T sub_sub_item in sub_item.TraverseTree(operation))
                        yield return sub_sub_item;
                }
            }
        }
        static public IEnumerable<T> TraverseTreeWithSelf<T>(this T item, Operation<IEnumerable<T>, T> operation)
        {
            return item.TraverseTree(operation).Prepend(item);
        }

        static public IEnumerable<T> TraverseTreeReverse<T>(this T item, Operation<IEnumerable<T>, T> operation)
        {
            foreach (T sub_item in operation(item))
            {
                if (sub_item != null)
                {
                    foreach (T sub_sub_item in sub_item.TraverseTree(operation))
                        yield return sub_sub_item;

                    yield return sub_item;
                }
            }
        }
        static public IEnumerable<T> TraverseTreeReverseWithSelf<T>(this T item, Operation<IEnumerable<T>, T> operation)
        {
            return item.TraverseTreeReverse(operation).Append(item);
        }
    }
}