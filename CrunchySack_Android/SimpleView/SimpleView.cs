using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Animation;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Noodle;
    using Bun;
    using Sack;
    
    public abstract class SimpleView : View
    {
        private RectF padded_rect;

        protected virtual void Initialize() { }
        protected virtual void OnPaddedRectChanged() { }
        protected virtual void OnMeasureInternal(ref int width, ref int height) { }

        protected override int SuggestedMinimumWidth { get { return 16; } }
        protected override int SuggestedMinimumHeight { get { return 16; } }

        protected int TotalSuggestedMinimumWidth { get { return SuggestedMinimumWidth + PaddingLeft + PaddingRight; } }
        protected int TotalSuggestedMinimumHeight { get { return SuggestedMinimumHeight + PaddingTop + PaddingBottom; } }

        protected override void OnSizeChanged(int width, int height, int old_width, int old_height)
        {
            base.OnSizeChanged(width, height, old_width, old_height);

            float pad_width = width - (PaddingLeft + PaddingRight);
            float pad_height = height - (PaddingBottom + PaddingTop);

            padded_rect = new RectF(0.0f, 0.0f, pad_width, pad_height);
            padded_rect.Offset(PaddingLeft, PaddingBottom);

            OnPaddedRectChanged();
        }

        protected override void OnMeasure(int width_measure_spec, int height_measure_spec)
        {
            int width = MeasureSpecExtensions.CalculateMeasurement(width_measure_spec, TotalSuggestedMinimumWidth);
            int height = MeasureSpecExtensions.CalculateMeasurement(height_measure_spec, TotalSuggestedMinimumHeight);

            OnMeasureInternal(ref width, ref height);
            SetMeasuredDimension(width, height);
        }

        public SimpleView(Context context) : base(context)
        {
            Initialize();   
        }

        public SimpleView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Initialize();
        }

        public SimpleView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {
            Initialize();
        }

        public RectF GetPaddedRect()
        {
            return padded_rect;
        }

        public float GetPaddedLeft()
        {
            return padded_rect.Left;
        }

        public float GetPaddedTop()
        {
            return padded_rect.Top;
        }

        public float GetPaddedRight()
        {
            return padded_rect.Right;
        }

        public float GetPaddedBottom()
        {
            return padded_rect.Bottom;
        }

        public float GetPaddedWidth()
        {
            return padded_rect.Width();
        }

        public float GetPaddedHeight()
        {
            return padded_rect.Height();
        }

        public VectorF2 GetPaddedSize()
        {
            return padded_rect.GetSize();
        }

        public float GetPaddedCenterX()
        {
            return padded_rect.CenterX();
        }

        public float GetPaddedCenterY()
        {
            return padded_rect.CenterY();
        }

        public VectorF2 GetPaddedCenter()
        {
            return padded_rect.GetCenter();
        }

        public float GetPaddedMinDimension()
        {
            return GetPaddedWidth().Min(GetPaddedHeight());
        }

        public float GetPaddedMaxDimension()
        {
            return GetPaddedWidth().Max(GetPaddedHeight());
        }
    }
}