using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    
    [AttributeUsage(AttributeTargets.Field)]
    public class AttachEditGadgetAttribute : Attribute
    {
        private string editor_scene_element_edit_gadget_instance_type_name;

        private Dictionary<string, string> action_paths;
        private Dictionary<string, string> variable_paths;

        public AttachEditGadgetAttribute(string g, string[] a, string[] v)
        {
            editor_scene_element_edit_gadget_instance_type_name = g;

            action_paths = a.PairPermissive().ConvertToKeyValuePairs().ToDictionary();
            variable_paths = v.PairPermissive().ConvertToKeyValuePairs().ToDictionary();
        }

        public AttachEditGadgetAttribute(string s) : this(s, new string[] { }, new string[] { }) { }

        public string GetEditorSceneElementEditGadgetInstanceTypeName()
        {
            return editor_scene_element_edit_gadget_instance_type_name;
        }

        public IEnumerable<KeyValuePair<string, string>> GetActionPaths()
        {
            return action_paths;
        }

        public IEnumerable<KeyValuePair<string, string>> GetVariablePaths()
        {
            return variable_paths;
        }
    }
}