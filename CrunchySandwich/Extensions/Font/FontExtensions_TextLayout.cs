using System;

using CrunchyDough;
using UnityEngine;

namespace CrunchySandwich
{
    static public class FontExtensions_TextLayout
    {
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
            return item.GetTextLayoutWidth(text, item.fontSize);
        }

        static public string LayoutText(this Font item, string text, float max_width, int size)
        {
            CharacterInfo info;

            return text.Layout(max_width, delegate(char character) {
                item.GetCharacterInfo(character, out info, size);

                return info.advance;
            });
        }
        static public string LayoutText(this Font item, string text, float max_width)
        {
            return item.LayoutText(text, max_width, item.fontSize);
        }
    }
}