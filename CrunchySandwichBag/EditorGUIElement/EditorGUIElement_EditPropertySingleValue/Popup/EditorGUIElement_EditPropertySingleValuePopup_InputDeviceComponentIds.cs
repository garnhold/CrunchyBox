using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{

    [EditorGUIElementForType(typeof(InputDeviceComponentId), true)]
    public class EditorGUIElement_EditPropertySingleValuePopup_InputDeviceComponentId : EditorGUIElement_EditPropertySingleValuePopup<InputDeviceComponentId>
    {
        public EditorGUIElement_EditPropertySingleValuePopup_InputDeviceComponentId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<InputDeviceComponentId> GetOptions()
        {
            return InputDeviceComponentId.GetComponents();
        }
    }

    [EditorGUIElementForType(typeof(InputDeviceAxisId), true)]
    public class EditorGUIElement_EditPropertySingleValuePopup_InputDeviceAxisId : EditorGUIElement_EditPropertySingleValuePopup<InputDeviceAxisId>
    {
        public EditorGUIElement_EditPropertySingleValuePopup_InputDeviceAxisId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<InputDeviceAxisId> GetOptions()
        {
            return InputDeviceAxisId.GetAxiss();
        }
    }

    [EditorGUIElementForType(typeof(InputDeviceButtonId), true)]
    public class EditorGUIElement_EditPropertySingleValuePopup_InputDeviceButtonId : EditorGUIElement_EditPropertySingleValuePopup<InputDeviceButtonId>
    {
        public EditorGUIElement_EditPropertySingleValuePopup_InputDeviceButtonId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<InputDeviceButtonId> GetOptions()
        {
            return InputDeviceButtonId.GetButtons();
        }
    }

    [EditorGUIElementForType(typeof(InputDeviceStickId), true)]
    public class EditorGUIElement_EditPropertySingleValuePopup_InputDeviceStickId : EditorGUIElement_EditPropertySingleValuePopup<InputDeviceStickId>
    {
        public EditorGUIElement_EditPropertySingleValuePopup_InputDeviceStickId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<InputDeviceStickId> GetOptions()
        {
            return InputDeviceStickId.GetSticks();
        }
    }
}