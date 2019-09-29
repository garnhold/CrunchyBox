using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public struct EditorGUIElementPlan
    {
        private float left_offset;
        private float right_offset;

        private float bottom_offset;
        private float top_offset;

        public EditorGUIElementPlan(float l, float r, float b, float t)
        {
            left_offset = l;
            right_offset = r;

            bottom_offset = b;
            top_offset = t;
        }

        public EditorGUIElementPlan(float width) : this(0.0f, width, 0.0f, 0.0f) { }

        public EditorGUIElementPlan Shrink(float l, float r, float b, float t)
        {
            return new EditorGUIElementPlan(
                left_offset + l,
                right_offset - r,
                bottom_offset + b,
                top_offset - t
            );
        }

        public void SplitAtHorizontalPosition(float position, out EditorGUIElementPlan left, out EditorGUIElementPlan right)
        {
            left = new EditorGUIElementPlan(left_offset, position, bottom_offset, top_offset);
            right = new EditorGUIElementPlan(position, right_offset, bottom_offset, top_offset);
        }
        public void SplitAtLeftOffset(float offset, out EditorGUIElementPlan left, out EditorGUIElementPlan right)
        {
            SplitAtHorizontalPosition(left_offset + offset, out left, out right);
        }
        public void SplitAtRightOffset(float offset, out EditorGUIElementPlan left, out EditorGUIElementPlan right)
        {
            SplitAtHorizontalPosition(right_offset - offset, out left, out right);
        }

        public void SplitAtVerticalPosition(float position, out EditorGUIElementPlan bottom, out EditorGUIElementPlan top)
        {
            bottom = new EditorGUIElementPlan(left_offset, right_offset, bottom_offset, position);
            top = new EditorGUIElementPlan(left_offset, right_offset, position, top_offset);
        }
        public void SplitAtBottomOffset(float offset, out EditorGUIElementPlan bottom, out EditorGUIElementPlan top)
        {
            SplitAtVerticalPosition(bottom_offset + offset, out bottom, out top);
        }
        public void SplitAtTopOffset(float offset, out EditorGUIElementPlan bottom, out EditorGUIElementPlan top)
        {
            SplitAtVerticalPosition(top_offset - offset, out bottom, out top);
        }

        public Rect Layout(Vector2 position, float footprint_height)
        {
            return RectExtensions.CreateMinMaxRect(
                position + new Vector2(left_offset, bottom_offset),
                position + new Vector2(right_offset, top_offset + footprint_height)
            );
        }

        public float GetWidth()
        {
            return right_offset - left_offset;
        }
    }
}