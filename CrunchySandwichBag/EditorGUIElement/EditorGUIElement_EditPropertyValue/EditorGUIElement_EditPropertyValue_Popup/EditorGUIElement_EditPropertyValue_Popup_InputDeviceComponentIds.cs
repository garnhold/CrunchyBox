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
    public class EditorGUIElement_EditPropertyValue_Popup_InputDeviceComponentId : EditorGUIElement_EditPropertyValue_Popup<InputDeviceComponentId>
    {
        public EditorGUIElement_EditPropertyValue_Popup_InputDeviceComponentId(EditProperty_Value p) : base(p) { }

        public override IEnumerable<InputDeviceComponentId> GetOptions()
        {
            return InputDeviceComponentId.GetComponents();
        }
    }

    [EditorGUIElementForType(typeof(InputDeviceAxisId), true)]
    public class EditorGUIElement_EditPropertyValue_Popup_InputDeviceAxisId : EditorGUIElement_EditPropertyValue_Popup<InputDeviceAxisId>
    {
        public EditorGUIElement_EditPropertyValue_Popup_InputDeviceAxisId(EditProperty_Value p) : base(p) { }

        public override IEnumerable<InputDeviceAxisId> GetOptions()
        {
            return InputDeviceAxisId.GetAxiss();
        }
    }

    [EditorGUIElementForType(typeof(InputDeviceButtonId), true)]
    public class EditorGUIElement_EditPropertyValue_Popup_InputDeviceButtonId : EditorGUIElement_EditPropertyValue_Popup<InputDeviceButtonId>
    {
        public EditorGUIElement_EditPropertyValue_Popup_InputDeviceButtonId(EditProperty_Value p) : base(p) { }

        public override IEnumerable<InputDeviceButtonId> GetOptions()
        {
            return InputDeviceButtonId.GetButtons();
        }
    }

    [EditorGUIElementForType(typeof(InputDeviceStickId), true)]
    public class EditorGUIElement_EditPropertyValue_Popup_InputDeviceStickId : EditorGUIElement_EditPropertyValue_Popup<InputDeviceStickId>
    {
        public EditorGUIElement_EditPropertyValue_Popup_InputDeviceStickId(EditProperty_Value p) : base(p) { }

        public override IEnumerable<InputDeviceStickId> GetOptions()
        {
            return InputDeviceStickId.GetSticks();
        }
    }
}