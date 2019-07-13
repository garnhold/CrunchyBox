﻿using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class VariableExtensions_Elements
    {
        static public Type GetVariableElementType(this Variable item)
        {
            return item.GetVariableType().GetIEnumerableType();
        }

        static public int GetVariableNumberElements(this Variable item, object target)
        {
            return item.GetContents(target).ToEnumerable().InspectCount();
        }

        static public Variable GetVariableElement(this Variable item, int index)
        {
            return new Variable_Element(item, index);
        }

        static public IEnumerable<Variable> GetVariableElements(this Variable item, int index, int count)
        {
            for (int i = 0; i < count; i++)
                yield return item.GetVariableElement(index + i);
        }
        static public IEnumerable<Variable> GetVariableElements(this Variable item, int count)
        {
            return item.GetVariableElements(0, count);
        }

        static public IEnumerable<Variable> GetAllVariableElements(this Variable item, object target)
        {
            return item.GetVariableElements(item.GetVariableNumberElements(target));
        }
    }
}