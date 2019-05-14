using System;

namespace CrunchyDough
{
    public class LabeledAttribute : Attribute
    {
        private string label;

        public LabeledAttribute(string l)
        {
            label = l;
        }

        public bool IsLabeled(string l)
        {
            if (label == l)
                return true;

            return false;
        }

        public string GetLabel()
        {
            return label;
        }
    }
}