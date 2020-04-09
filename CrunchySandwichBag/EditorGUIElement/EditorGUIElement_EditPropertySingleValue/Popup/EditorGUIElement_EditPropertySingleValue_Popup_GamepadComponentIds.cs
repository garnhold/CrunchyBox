using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bread;
    using Sandwich;
    
    
    [EditorGUIElementForType(typeof(GamepadComponentId), true)]
    public class EditorGUIElement_EditPropertySingleValue_Popup_GamepadComponentId : EditorGUIElement_EditPropertySingleValue_Popup<GamepadComponentId>
    {
        public EditorGUIElement_EditPropertySingleValue_Popup_GamepadComponentId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<GamepadComponentId> GetOptions()
        {
            return GamepadComponentId.GetComponents();
        }
    }

    [EditorGUIElementForType(typeof(GamepadAxisId), true)]
    public class EditorGUIElement_EditPropertySingleValue_Popup_GamepadAxisId : EditorGUIElement_EditPropertySingleValue_Popup<GamepadAxisId>
    {
        public EditorGUIElement_EditPropertySingleValue_Popup_GamepadAxisId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<GamepadAxisId> GetOptions()
        {
            return GamepadAxisId.GetAxiss();
        }
    }

    [EditorGUIElementForType(typeof(GamepadButtonId), true)]
    public class EditorGUIElement_EditPropertySingleValue_Popup_GamepadButtonId : EditorGUIElement_EditPropertySingleValue_Popup<GamepadButtonId>
    {
        public EditorGUIElement_EditPropertySingleValue_Popup_GamepadButtonId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<GamepadButtonId> GetOptions()
        {
            return GamepadButtonId.GetButtons();
        }
    }

    [EditorGUIElementForType(typeof(GamepadStickId), true)]
    public class EditorGUIElement_EditPropertySingleValue_Popup_GamepadStickId : EditorGUIElement_EditPropertySingleValue_Popup<GamepadStickId>
    {
        public EditorGUIElement_EditPropertySingleValue_Popup_GamepadStickId(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<GamepadStickId> GetOptions()
        {
            return GamepadStickId.GetSticks();
        }
    }
}