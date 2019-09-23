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

		static public string LayoutBoxText(this GUISkin item, string text, float max_width)
		{
			if (item.box.font != null)
				return item.box.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetButtonTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.button.font != null)
                return item.button.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutButtonText(this GUISkin item, string text, float max_width)
		{
			if (item.button.font != null)
				return item.button.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetHorizontalScrollbarTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalScrollbar.font != null)
                return item.horizontalScrollbar.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutHorizontalScrollbarText(this GUISkin item, string text, float max_width)
		{
			if (item.horizontalScrollbar.font != null)
				return item.horizontalScrollbar.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetHorizontalScrollbarLeftButtonTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalScrollbarLeftButton.font != null)
                return item.horizontalScrollbarLeftButton.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutHorizontalScrollbarLeftButtonText(this GUISkin item, string text, float max_width)
		{
			if (item.horizontalScrollbarLeftButton.font != null)
				return item.horizontalScrollbarLeftButton.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetHorizontalScrollbarRightButtonTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalScrollbarRightButton.font != null)
                return item.horizontalScrollbarRightButton.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutHorizontalScrollbarRightButtonText(this GUISkin item, string text, float max_width)
		{
			if (item.horizontalScrollbarRightButton.font != null)
				return item.horizontalScrollbarRightButton.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetHorizontalScrollbarThumbTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalScrollbarThumb.font != null)
                return item.horizontalScrollbarThumb.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutHorizontalScrollbarThumbText(this GUISkin item, string text, float max_width)
		{
			if (item.horizontalScrollbarThumb.font != null)
				return item.horizontalScrollbarThumb.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetHorizontalSliderTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalSlider.font != null)
                return item.horizontalSlider.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutHorizontalSliderText(this GUISkin item, string text, float max_width)
		{
			if (item.horizontalSlider.font != null)
				return item.horizontalSlider.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetHorizontalSliderThumbTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.horizontalSliderThumb.font != null)
                return item.horizontalSliderThumb.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutHorizontalSliderThumbText(this GUISkin item, string text, float max_width)
		{
			if (item.horizontalSliderThumb.font != null)
				return item.horizontalSliderThumb.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetLabelTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.label.font != null)
                return item.label.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutLabelText(this GUISkin item, string text, float max_width)
		{
			if (item.label.font != null)
				return item.label.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetScrollViewTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.scrollView.font != null)
                return item.scrollView.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutScrollViewText(this GUISkin item, string text, float max_width)
		{
			if (item.scrollView.font != null)
				return item.scrollView.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetTextAreaTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.textArea.font != null)
                return item.textArea.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutTextAreaText(this GUISkin item, string text, float max_width)
		{
			if (item.textArea.font != null)
				return item.textArea.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetTextFieldTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.textField.font != null)
                return item.textField.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutTextFieldText(this GUISkin item, string text, float max_width)
		{
			if (item.textField.font != null)
				return item.textField.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetToggleTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.toggle.font != null)
                return item.toggle.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutToggleText(this GUISkin item, string text, float max_width)
		{
			if (item.toggle.font != null)
				return item.toggle.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetVerticalScrollbarTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalScrollbar.font != null)
                return item.verticalScrollbar.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutVerticalScrollbarText(this GUISkin item, string text, float max_width)
		{
			if (item.verticalScrollbar.font != null)
				return item.verticalScrollbar.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetVerticalScrollbarDownButtonTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalScrollbarDownButton.font != null)
                return item.verticalScrollbarDownButton.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutVerticalScrollbarDownButtonText(this GUISkin item, string text, float max_width)
		{
			if (item.verticalScrollbarDownButton.font != null)
				return item.verticalScrollbarDownButton.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetVerticalScrollbarThumbTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalScrollbarThumb.font != null)
                return item.verticalScrollbarThumb.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutVerticalScrollbarThumbText(this GUISkin item, string text, float max_width)
		{
			if (item.verticalScrollbarThumb.font != null)
				return item.verticalScrollbarThumb.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetVerticalScrollbarUpButtonTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalScrollbarUpButton.font != null)
                return item.verticalScrollbarUpButton.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutVerticalScrollbarUpButtonText(this GUISkin item, string text, float max_width)
		{
			if (item.verticalScrollbarUpButton.font != null)
				return item.verticalScrollbarUpButton.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetVerticalSliderTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalSlider.font != null)
                return item.verticalSlider.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutVerticalSliderText(this GUISkin item, string text, float max_width)
		{
			if (item.verticalSlider.font != null)
				return item.verticalSlider.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetVerticalSliderThumbTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.verticalSliderThumb.font != null)
                return item.verticalSliderThumb.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutVerticalSliderThumbText(this GUISkin item, string text, float max_width)
		{
			if (item.verticalSliderThumb.font != null)
				return item.verticalSliderThumb.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

		static public float GetWindowTextLayoutWidth(this GUISkin item, string text)
        {
            if (item.window.font != null)
                return item.window.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }

		static public string LayoutWindowText(this GUISkin item, string text, float max_width)
		{
			if (item.window.font != null)
				return item.window.LayoutText(text, max_width);

			return item.LayoutDefaultText(text, max_width);
		}

	}
}

