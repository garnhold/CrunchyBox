using System;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    
    static public partial class SerializedPropertyExtensions_Value
    {
        static private void ClearValue_Array(this SerializedProperty item)
        {
            item.ClearArray();
        }
        static private void SetValue_Array(this SerializedProperty item, object value)
        {
            item.ClearArray();
            value.ToEnumerable<object>().Process(o => item.PushArrayElement().SetValue(o));
        }
        static private object GetValue_Array(this SerializedProperty item)
        {
            return item.GetArrayElements().Convert(p => p.GetValue()).ToArray();
        }

        static private void ClearValue_Generic(this SerializedProperty item)
        {
            item.GetImmediateChildren(false).Process(c => c.ClearValue());
        }
        static private void SetValue_Generic(this SerializedProperty item, object value)
        {
            if (value.IsNotNull())
                item.GetImmediateChildren(false).Process(p => p.SetValue(p.GetRelativeVariable(item).GetContents(value)));
            else
                item.ClearValue();
        }
        static private object GetValue_Generic(this SerializedProperty item)
        {
            object obj = item.GetVariableType().CreateInstance();

            item.GetImmediateChildren(false).Process(p => p.GetRelativeVariable(item).SetContents(obj, p.GetValue()));
            return obj;
        }

        static private void ClearValue_Enum(this SerializedProperty item)
        {
            item.enumValueIndex = 0;
        }
        static private void SetValue_Enum(this SerializedProperty item, object value)
        {
            item.enumValueIndex = value.Convert<Enum>().IfNotNull(e => e.GetEnumIndex(), () => value.ConvertEX<int>());
        }
        static private object GetValue_Enum(this SerializedProperty item)
        {
            return item.GetVariableType().IfNotNull(t => t.GetEnumValueByIndex(item.enumValueIndex), (object)item.enumValueIndex);
        }
    }
}