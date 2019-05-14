using System;

namespace CrunchySandwichBag
{
    public class EditorGUIElementLength_Weighted : EditorGUIElementLength
    {
        private float weight;

        public EditorGUIElementLength_Weighted(float w)
        {
            weight = w;
        }

        public override float GetWeight()
        {
            return weight;
        }
    }
}