using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    [EditorGUIElementForType(typeof(InputDeviceComponentId), true)]
    public class EditorGUIElement_EditPropertySingleValue_Popup_InputDeviceComponentId : EditorGUIElement_EditPropertySingleValue_Popup<InputDeviceComponentId>
    {
        public EditorGUIElement_EditPropertySingleValue_Popup_InputDeviceComponentId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<InputDeviceComponentId> GetOptions()
        {
            return InputDeviceComponentId.GetComponents();
        }
    }

    [EditorGUIElementForType(typeof(InputDeviceAxisId), true)]
    public class EditorGUIElement_EditPropertySingleValue_Popup_InputDeviceAxisId : EditorGUIElement_EditPropertySingleValue_Popup<InputDeviceAxisId>
    {
        public EditorGUIElement_EditPropertySingleValue_Popup_InputDeviceAxisId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<InputDeviceAxisId> GetOptions()
        {
            return InputDeviceAxisId.GetAxiss();
        }
    }

    [EditorGUIElementForType(typeof(InputDeviceButtonId), true)]
    public class EditorGUIElement_EditPropertySingleValue_Popup_InputDeviceButtonId : EditorGUIElement_EditPropertySingleValue_Popup<InputDeviceButtonId>
    {
        public EditorGUIElement_EditPropertySingleValue_Popup_InputDeviceButtonId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<InputDeviceButtonId> GetOptions()
        {
            return InputDeviceButtonId.GetButtons();
        }
    }

    [EditorGUIElementForType(typeof(InputDeviceStickId), true)]
    public class EditorGUIElement_EditPropertySingleValue_Popup_InputDeviceStickId : EditorGUIElement_EditPropertySingleValue_Popup<InputDeviceStickId>
    {
        public EditorGUIElement_EditPropertySingleValue_Popup_InputDeviceStickId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<InputDeviceStickId> GetOptions()
        {
            return InputDeviceStickId.GetSticks();
        }
    }
}