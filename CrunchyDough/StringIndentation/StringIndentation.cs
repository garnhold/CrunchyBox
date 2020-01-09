using System;

namespace Crunchy.Dough
{
    public abstract class StringIndentation
    {
        private int level;
        private string indentation_string;
        private string indented_newline_string;

        protected abstract int CalculateLevel(string i);
        protected abstract string CalculateString(int l);

        public StringIndentation()
        {
            level = 0;
            indentation_string = "";
            indented_newline_string = "\n";
        }

        public void Clear()
        {
            level = 0;
            indentation_string = "";
            indented_newline_string = "\n";
        }

        public void SetLevel(int l)
        {
            if (l < 0)
                l = 0;

            if (level != l)
            {
                level = l;
                indentation_string = CalculateString(level);
                indented_newline_string = "\n" + indentation_string;
            }
        }
        public void SetLevel(string indent)
        {
            SetLevel(CalculateLevel(indent));
        }

        public void AdjustLevel(int amount)
        {
            SetLevel(level + amount);
        }

        public void IncreaseLevel(int amount)
        {
            if (amount > 0)
                AdjustLevel(amount);
        }
        public void IncreaseLevel(string indent)
        {
            IncreaseLevel(CalculateLevel(indent));
        }
        public void IncreaseLevel()
        {
            IncreaseLevel(1);
        }

        public void DecreaseLevel(int amount)
        {
            if (amount > 0)
                AdjustLevel(-amount);
        }
        public void DecreaseLevel(string indent)
        {
            DecreaseLevel(CalculateLevel(indent));
        }
        public void DecreaseLevel()
        {
            DecreaseLevel(1);
        }

        public int GetLevel()
        {
            return level;
        }

        public string GetIndentionString()
        {
            return indentation_string;
        }

        public string GetIndentedNewlineString()
        {
            return indented_newline_string;
        }

        public override string ToString()
        {
            return indentation_string;
        }
    }
}