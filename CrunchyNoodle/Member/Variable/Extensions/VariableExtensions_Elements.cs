using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
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

        static public Variable_Element GetVariableElement(this Variable item, int index)
        {
            return new Variable_Element(item, index);
        }

        static public IEnumerable<Variable_Element> GetVariableElements(this Variable item, int index, int count)
        {
            for (int i = 0; i < count; i++)
                yield return item.GetVariableElement(index + i);
        }
        static public IEnumerable<Variable_Element> GetVariableElements(this Variable item, int count)
        {
            return item.GetVariableElements(0, count);
        }

        static public IEnumerable<Variable_Element> GetAllVariableElements(this Variable item, object target)
        {
            return item.GetVariableElements(item.GetVariableNumberElements(target));
        }
    }
}