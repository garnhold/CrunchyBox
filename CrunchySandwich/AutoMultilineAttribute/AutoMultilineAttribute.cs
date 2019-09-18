using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AttributeUsage(AttributeTargets.Field)]
    public class AutoMultilineAttribute : Attribute
    {
        private int minimum_number_lines;

        public AutoMultilineAttribute(int m)
        {
            minimum_number_lines = m;
        }

        public AutoMultilineAttribute() : this(1) { }

        public int GetMinimumNumberLines()
        {
            return minimum_number_lines;
        }
    }
}