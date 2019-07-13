﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_SpriteVectorizerTest : EditorGUIElement
    {
        private SpriteVectorizer vectorizer;

        protected override void DrawElementInternal(Rect view)
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

                    Vector2 divisor = sprite.GetTextureSize() / rect.size.GetMinComponent();
                    List<List<Vector2>> paths = vectorizer.VectorizeSprite(sprite)
                        .Convert(l => l.Convert(p => p.GetWithFlippedY().GetComponentDivide(divisor) + rect.center).ToList())
                        .ToList();

                    EditorGUIExtensions.DrawSprite(rect, sprite);
                    GUI.Label(info_rect, "Number Vertexs: " + paths.Convert(p => p.Count).Sum());

                    GUI.color = Color.white;
                    paths.Process(p => GUIExtensions.DrawLoop(p, line_thickness, point_size));
                }
            }
        }

        protected override float CalculateElementHeightInternal()
        {
            return LINE_HEIGHT * 10.0f;
        }

        public EditorGUIElement_SpriteVectorizerTest(SpriteVectorizer v)
        {
            vectorizer = v;
        }
    }
}