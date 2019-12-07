using System;

namespace Crunchy.Dough
{
    public class StringIndentation_Tab : StringIndentation_TabAndSpace
    {
        static private OperationCache<string, int> GET_STRING = new OperationCache<string, int>("GET_STRING", delegate(int level) {
            return "\t".Repeat(level);
        });
        static public string GetString(int level)
        {
            return GET_STRING.Fetch(level);
        }

        protected override int CalculateLevel(string i)
        {
            return i.CalculateNumberTabs(GetSpacesPerTab());
        }

        protected override string CalculateString(int l)
        {
            return GetString(l);
        }

        public StringIndentation_Tab(int s) : base(s)
        {
        }
        public StringIndentation_Tab() : this(StringExtensions_Space.DEFAULT_NUMBER_SPACES_PER_TAB)
        {
        }
    }
}