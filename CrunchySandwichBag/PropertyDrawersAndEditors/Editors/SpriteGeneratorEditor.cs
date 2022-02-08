using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Networking;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    [CustomEditor(typeof(SpriteGenerator), true)]
    public class SpriteGeneratorEditor : EditorEX_Simple<SpriteGenerator>
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, EditTarget target)
        {
            root.AddChild(new EditorGUIElement_Complex_EditTarget(target));

            SpriteGenerator sprite_generator;
            if (target.TryGetObject<SpriteGenerator>(out sprite_generator))
                root.AddChild(new EditorGUIElement_SpriteGeneratorTest(sprite_generator));
        }
    }
}