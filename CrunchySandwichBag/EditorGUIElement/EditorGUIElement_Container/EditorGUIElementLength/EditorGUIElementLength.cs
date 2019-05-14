using System;

namespace CrunchySandwichBag
{
    public abstract class EditorGUIElementLength
    {
        public virtual float GetWeight() { return 0.0f; }
        public virtual float GetFixedLength() { return 0.0f; }

        public float GetLength(float total_weighted_length, float total_weight)
        {
            return total_weighted_length * (GetWeight() / total_weight) + GetFixedLength();
        }
    }
}