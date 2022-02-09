using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElement_SpriteVectorizerTest : EditorGUIElement
    {
        private SpriteVectorizer vectorizer;

        protected override float DoPlanInternal()
        {
            return LINE_HEIGHT * 10.0f;
        }

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            Rect rect = GetElementRect();

            if (vectorizer != null)
            {
                Sprite sprite = vectorizer.GetTestSprite();

                if (sprite != null)
                {
                    Rect info_rect;

                    rect.SplitByYTopOffset(LINE_HEIGHT, out rect, out info_rect);

                    float line_thickness = vectorizer.GetTestLineThickness();
                    float point_size = vectorizer.GetTestPointSize();

                    Vector2 divisor = sprite.GetTextureSize() / rect.size.GetComponentsMin();
                    List<List<Vector2>> paths = vectorizer.VectorizeSprite(sprite)
                        .Convert(l => l.Convert(p => p.GetWithFlippedY().GetComponentDivide(divisor) + rect.center).ToList())
                        .ToList();

                    GUIExtensions.DrawSprite(rect, sprite);
                    GUI.Label(info_rect, "Number Vertexs: " + paths.Convert(p => p.Count).Sum());

                    GUI.color = Color.white;
                    paths.Process(p => GUIExtensions.DrawLoop(p, line_thickness, point_size));
                }
            }
        }

        public EditorGUIElement_SpriteVectorizerTest(SpriteVectorizer v)
        {
            vectorizer = v;
        }
    }
}