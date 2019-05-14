using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class TimePieceExtensions
    {
        static public T StartAndGet<T>(this T item) where T : TimePiece
        {
            item.Start();

            return item;
        }
    }
}