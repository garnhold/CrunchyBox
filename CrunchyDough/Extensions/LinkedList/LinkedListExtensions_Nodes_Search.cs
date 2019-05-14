using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class LinkedListExtensions_Nodes_Search
    {
        static public LinkedListNode<T> FindFirstNode<T>(this LinkedList<T> item, Predicate<T> predicate)
        {
            return item.GetNodes().FindFirst(n => predicate(n.Value));
        }

        static public LinkedListNode<T> FindLastNode<T>(this LinkedList<T> item, Predicate<T> predicate)
        {
            return item.GetReverseNodes().FindFirst(n => predicate(n.Value));
        }
    }
}