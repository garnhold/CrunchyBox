﻿using System;

namespace CrunchyDough
{
    static public class ValueExtensions_Assert
    {
        static public T AssertNotNull<T>(this T item, Operation<Exception> o)
        {
            if (item.IsNull())
                throw o();

            return item;
        }
    }
}