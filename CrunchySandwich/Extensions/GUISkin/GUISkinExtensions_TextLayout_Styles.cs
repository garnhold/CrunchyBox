using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GUISkinExtensions_TextLayout_Styles
    {
		static public float GetBoxTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.box.font != null)
                return item.box.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetButtonTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.button.font != null)
                return item.button.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetHorizontalScrollbarTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalScrollbar.font != null)
                return item.horizontalScrollbar.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetHorizontalScrollbarLeftButtonTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalScrollbarLeftButton.font != null)
                return item.horizontalScrollbarLeftButton.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetHorizontalScrollbarRightButtonTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalScrollbarRightButton.font != null)
                return item.horizontalScrollbarRightButton.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetHorizontalScrollbarThumbTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalScrollbarThumb.font != null)
                return item.horizontalScrollbarThumb.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetHorizontalSliderTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalSlider.font != null)
                return item.horizontalSlider.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetHorizontalSliderThumbTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalSliderThumb.font != null)
                return item.horizontalSliderThumb.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetLabelTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.label.font != null)
                return item.label.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetScrollViewTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.scrollView.font != null)
                return item.scrollView.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetTextAreaTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.textArea.font != null)
                return item.textArea.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetTextFieldTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.textField.font != null)
                return item.textField.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetToggleTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.toggle.font != null)
                return item.toggle.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetVerticalScrollbarTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalScrollbar.font != null)
                return item.verticalScrollbar.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetVerticalScrollbarDownButtonTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalScrollbarDownButton.font != null)
                return item.verticalScrollbarDownButton.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetVerticalScrollbarThumbTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalScrollbarThumb.font != null)
                return item.verticalScrollbarThumb.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetVerticalScrollbarUpButtonTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalScrollbarUpButton.font != null)
                return item.verticalScrollbarUpButton.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetVerticalSliderTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalSlider.font != null)
                return item.verticalSlider.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetVerticalSliderThumbTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalSliderThumb.font != null)
                return item.verticalSliderThumb.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public float GetWindowTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.window.font != null)
                return item.window.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

	}
}

