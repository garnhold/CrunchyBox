using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_Sideboard : EditorGUIElement
    {
        private bool is_vertical;

        private EditorGUIFlowElement main_element;
        private EditorGUIFlowElement auxillary_element;

        protected override void InitializeInternal()
        {
            main_element.IfNotNull(e => e.Initialize());
            auxillary_element.IfNotNull(e => e.Initialize());
        }

        protected override float DoPlanInternal()
        {
            float total_width = GetContentsWidth();
            float total_weight = main_element.GetDimension().GetWeight() + auxillary_element.GetDimension().GetWeight();
            float total_minimum = main_element.GetDimension().GetMinimum() + auxillary_element.GetDimension().GetMinimum();

            float main_footprint_height = main_element.Plan(total_width, total_weight, total_minimum, GetLayoutState());
            float auxillary_footprint_height = auxillary_element.Plan(total_width, total_weight, total_minimum, GetLayoutState());

            if (main_footprint_height < auxillary_footprint_height * 2.0f)
            {
                is_vertical = false;
                return main_footprint_height.Max(auxillary_footprint_height);
            }

            main_footprint_height = main_element.Plan(total_width, GetLayoutState());
            auxillary_footprint_height = auxillary_element.Plan(total_width, GetLayoutState());

            is_vertical = true;
            return main_footprint_height + auxillary_footprint_height;
        }

        protected override void LayoutContentsInternal(Vector2 position)
        {
            if (is_vertical)
            {
                auxillary_element.Layout(position);
                position.y += auxillary_element.GetFootprintHeight();

                main_element.Layout(position);
            }
            else
            {
                main_element.Layout(position);
                position.x += main_element.GetFootprintWidth();

                auxillary_element.Layout(position);
            }
        }

        protected override void DrawContentsInternal(Rect view)
        {
            main_element.Draw(view);
            auxillary_element.Draw(view);
        }

        protected override void UnwindInternal()
        {
            main_element.Unwind();
            auxillary_element.Unwind();
        }

        public EditorGUIElement_Sideboard(EditorGUIFlowElement m, EditorGUIFlowElement a)
        {
            main_element = m;
            auxillary_element = a;

            main_element.SetParent(this);
            auxillary_element.SetParent(this);

            AddAttachment(new EditorGUIElementAttachment_Singular_Margin(0.0f));
        }
    }
}