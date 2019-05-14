using System;

namespace CrunchySandwichBag
{
    public class EditorGUIElementLength_Fixed : EditorGUIElementLength
    {
        private float fixed_length;

        public EditorGUIElementLength_Fixed(float f)
        {
            fixed_length = f;
        }

        public override float GetFixedLength()
        {
            return fixed_length;
        }
    }
}