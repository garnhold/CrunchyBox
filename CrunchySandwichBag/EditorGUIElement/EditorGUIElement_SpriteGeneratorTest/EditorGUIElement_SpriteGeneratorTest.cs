using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    public class EditorGUIElement_SpriteGeneratorTest : EditorGUIElement
    {
        private SpriteGenerator generator;

        private Timer preview_timer;
        private List<Sprite> preview_sprites;

        protected override float DoPlanInternal()
        {
            return LINE_HEIGHT * 10.0f;
        }

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            Rect rect = GetElementRect();

            Rect button_rect;

            rect.SplitByYBottomOffset(LINE_HEIGHT, out button_rect, out rect);

            if (generator != null)
            {
                if (GUI.Button(button_rect, "Preview"))
                {
                    SpriteGeneratorSheet sheet = generator.GenerateSheet();

                    preview_timer = new Timer(sheet.GetDuration());
                    preview_sprites = sheet
                        .GenerateSprites()
                        .ToList();

                    preview_timer.Restart();
                }
            }

            if (preview_timer != null && preview_timer.IsTimeUnder() && preview_sprites.IsNotEmpty())
            {
                Sprite sprite = preview_sprites.GetPercentCapped(preview_timer.GetTimeElapsedInPercent());

                GUIExtensions.DrawSprite(rect, sprite);
                Event.current.Use();
            }
        }

        public EditorGUIElement_SpriteGeneratorTest(SpriteGenerator v)
        {
            generator = v;
        }
    }
}