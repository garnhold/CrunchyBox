﻿using System;
using System.Reflection;
using System.Globalization;

namespace CrunchyDough
{
    static public class DateTimeExtensions_Age
    {
        static public TimeSpan GetAgeFromDate(this DateTime item)
        {
            return DateTime.UtcNow - item.GetUTC();
        }
    }
}