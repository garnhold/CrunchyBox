using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class Painter : Subsystem<Painter>, ISerializationCallbackReceiver
    {
        [SerializeField]private PainterToolType tool_type;

        [SerializeFieldEX][PolymorphicField]private PainterBrush brush;
        [SerializeFieldEX][Range(0.3f, 128.0f)]private float brush_size;

        [SerializeFieldEX][PolymorphicField]private Mixer_Color mixer;
        [SerializeFieldEX]private Color primary_color;
        [SerializeFieldEX]private Color secondary_color;

        private Utensil<Color> utensil;

        private Utensil<Color> CreateUtensil()
        {
            if (brush != null && mixer != null)
            {
                switch (tool_type)
                {
                    case PainterToolType.Brush:
                        return new Utensil_InkedBrush<Color>(
                            new Ink_Basic<Color>(primary_color, mixer),
                            brush.CreateBrush(brush_size)
                        );

                    case PainterToolType.Eraser:
                        return new Utensil_InkedBrush<Color>(
                            new Ink_Basic<Color>(Color.clear, new Mixer_Color_Simple_Overwrite()),
                            brush.CreateBrush(brush_size)
                        );
                }
            }

            return null;
        }

        public void OnBeforeSerialize() { }
        public void OnAfterDeserialize()
        {
            utensil = CreateUtensil();
        }

        [InspectorAction]
        public void SwapColors()
        {
            Color temp = primary_color;

            primary_color = secondary_color;
            secondary_color = temp;
        }

        public float GetBrushSize()
        {
            return brush_size;
        }

        public Utensil<Color> GetUtensil()
        {
            return utensil;
        }
    }
}