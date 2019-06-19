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
        static public bool TryGetRelativeVariablePath(this SerializedProperty item, SerializedProperty parent, out string path)
        {
            return item.GetVariablePath().TryTrimPrefix(parent.GetVariablePath(), out path);
        }
        static public string GetRelativeVariablePath(this SerializedProperty item, SerializedProperty parent)
        {
            string path;

            item.TryGetRelativeVariablePath(parent, out path);
            return path;
        }

        static public Variable GetVariable(this SerializedProperty item)
        {
            return item.serializedObject.GetTargetType().GetVariableByPath(item.GetVariablePath());
        }
        static public bool TryGetRelativeVariable(this SerializedProperty item, SerializedProperty parent, out Variable variable)
        {
            string path;

            if (item.TryGetRelativeVariablePath(parent, out path))
            {
                variable = parent.GetVariableType().GetVariableByPath(path);
                return true;
            }

            variable = null;
            return false;
        }
        static public Variable GetRelativeVariable(this SerializedProperty item, SerializedProperty parent)
        {
            Variable variable;

            item.TryGetRelativeVariable(parent, out variable);
            return variable;
        }

        static public Type GetVariableType(this SerializedProperty item)
        {
            return item.GetVariable().IfNotNull(v => v.GetVariableType());
        }
    }
}