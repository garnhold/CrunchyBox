using System;

namespace CrunchyDough
{
    public abstract class StringIndentation_TabAndSpace : StringIndentation
    {
        private int spaces_per_tab;

        public StringIndentation_TabAndSpace(int s)
        {
            spaces_per_tab = s;
        }

        public int GetSpacesPerTab()
        {
            return spaces_per_tab;
        }
    }
}