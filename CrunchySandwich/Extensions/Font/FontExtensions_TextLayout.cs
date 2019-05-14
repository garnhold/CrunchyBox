using System;

using CrunchyDough;
using UnityEngine;

namespace CrunchySandwich
{
    static public class FontExtensions_TextLayout
    {
        static private readonly float TYPE_UNITS_PER_SPACE_UNIT = 10.0f;

        static public float GetTextLayoutWidth(this Font item, string text, int size)
        {
            CharacterInfo info;

            return text.GetLayoutWidth(delegate(char character) {
                item.GetCharacterInfo(character, out info, size);

                return info.advance;
            });
        }
        static public float GetTextLayoutWidth(this Font item, string text)
        {
            return item.GetTextLayoutWidth(text, 0);
        }

        static public string LayoutText(this Font item, string text, float max_width, int size)
        {
            CharacterInfo info;

            return text.Layout(max_width * TYPE_UNITS_PER_SPACE_UNIT, delegate(char character) {
                item.GetCharacterInfo(character, out info, size);

                return info.advance;
            });
        }
        static public string LayoutText(this Font item, string text, float max_width)
        {
            return item.LayoutText(text, max_width, 0);
        }
    }
}