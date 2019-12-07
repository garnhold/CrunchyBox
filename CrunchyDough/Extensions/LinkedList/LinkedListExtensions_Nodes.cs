using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class LinkedListExtensions_Nodes
    {
        static public IEnumerable<LinkedListNode<T>> GetNodes<T>(this LinkedList<T> item)
        {
            return item.First.TraverseWithSelf(n => n.Next);
        }

        static public IEnumerable<LinkedListNode<T>> GetReverseNodes<T>(this LinkedList<T> item)
        {
            return item.Last.TraverseWithSelf(n => n.Previous);
        }
    }
}