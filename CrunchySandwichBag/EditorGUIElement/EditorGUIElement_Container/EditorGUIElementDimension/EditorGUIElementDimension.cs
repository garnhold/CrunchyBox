using System;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    public struct EditorGUIElementDimension
    {
        private float weight;
        private float minimum;

        static public EditorGUIElementDimension Fixed(float length)
        {
            return new EditorGUIElementDimension(0.0f, length);
        }

        static public EditorGUIElementDimension Atleast(float weight, float minimum)
        {
            return new EditorGUIElementDimension(weight, minimum);
        }

        private EditorGUIElementDimension(float w, float m)
        {
            weight = w;
            minimum = m;
        }

        public float Calculate(float width, float total_weight, float total_minimum)
        {
            float flux_total = width - total_minimum;
            float weight_percent = weight / total_weight;

            return (weight_percent * flux_total) + minimum;
        }

        public float GetWeight()
        {
            return weight;
        }

        public float GetMinimum()
        {
            return minimum;
        }
    }
}