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
    
    [CustomEditor(typeof(SpriteVectorizer), true)]
    public class SpriteVectorizerEditor : EditorEX_Simple<SpriteVectorizer>
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, EditTarget target)
        {
            root.AddChild(new EditorGUIElement_Complex_EditTarget(target));

            SpriteVectorizer sprite_vectorizer;
            if (target.TryGetObject<SpriteVectorizer>(out sprite_vectorizer))
                root.AddChild(new EditorGUIElement_SpriteVectorizerTest(sprite_vectorizer));
        }
    }
}