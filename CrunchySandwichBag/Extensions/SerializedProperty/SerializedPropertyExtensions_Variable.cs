using System;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_Variable
    {
        static public string GetVariablePath(this SerializedProperty item)
        {
            return item.propertyPath.RegexReplace("\\.Array\\.data\\[([0-9]*)\\]", delegate(Match match) {
                return "[" + match.Groups[1].Value + "]";
            });
        }

        static public Variable GetVariable(this SerializedProperty item)
        {
            return item.serializedObject.GetTargetType().GetVariableByPath(item.GetVariablePath());
        }

        static public Type GetVariableType(this SerializedProperty item)
        {
            return item.GetVariable().IfNotNull(v => v.GetVariableType());
        }
    }
}