using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class LinkedListExtensions_Insert
    {
        static public void Insert<T>(this LinkedList<T> item, T value, Predicate<T> predicate, Process<LinkedListNode<T>> process)
        {
            LinkedListNode<T> node = item.FindFirstNode(predicate);

            if (node != null)
                process(node);
            else
                item.AddLast(value);
        }
        static public void InsertBefore<T>(this LinkedList<T> item, T value, Predicate<T> predicate)
        {
            item.Insert(value, predicate, n => item.AddBefore(n, value));
        }
        static public void InsertAfter<T>(this LinkedList<T> item, T value, Predicate<T> predicate)
        {
            item.Insert(value, predicate, n => item.AddAfter(n, value));
        }

        static public void InsertLast<T>(this LinkedList<T> item, T value, Predicate<T> predicate, Process<LinkedListNode<T>> process)
        {
            LinkedListNode<T> node = item.FindLastNode(predicate);

            if (node != null)
                process(node);
            else
                item.AddFirst(value);
        }
        static public void InsertBeforeLast<T>(this LinkedList<T> item, T value, Predicate<T> predicate)
        {
            item.InsertLast(value, predicate, n => item.AddBefore(n, value));
        }
        static public void InsertAfterLast<T>(this LinkedList<T> item, T value, Predicate<T> predicate)
        {
            item.InsertLast(value, predicate, n => item.AddAfter(n, value));
        }
    }
}