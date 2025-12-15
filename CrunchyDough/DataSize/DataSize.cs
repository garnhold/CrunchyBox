using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    public struct DataSize
    {
        private readonly int number_bytes;

        static public bool TryParse(string input, out DataSize output)
        {
            Match match = input.RegexMatch("^\\s*([0-9\\.]+)\\s*([A-Za-z0-9_]+)?\\s*$");

            if (match.Success)
            {
                if (match.Groups[1].Value.TryParseDouble(out double number))
                {
                    if (match.Groups[2].Success)
                    {
                        switch (match.Groups[2].Value.ToLower())
                        {
                            case "b": output = Bytes(number); return true;
                            case "kb": output = Kilobytes(number); return true;
                            case "mb": output = Megabytes(number); return true;
                            case "gb": output = Gigabytes(number); return true;
                            case "tb": output = Terabytes(number); return true;
                        }
                    }
                    else
                    {
                        output = Bytes(number);
                        return true;
                    }
                }
            }

            output = DataSize.Zero;
            return false;
        }
        static public DataSize Parse(string input)
        {
            DataSize.TryParse(input, out DataSize output);
            return output;
        }

        static public DataSize Bytes(double bytes)
        {
            return new DataSize((int)Math.Ceiling(bytes));
        }
        static public DataSize Kilobytes(double kilobytes)
        {
            return DataSize.Bytes(kilobytes * 1024);
        }
        static public DataSize Megabytes(double megabytes)
        {
            return DataSize.Kilobytes(megabytes * 1024);
        }
        static public DataSize Gigabytes(double gigabytes)
        {
            return DataSize.Megabytes(gigabytes * 1024);
        }
        static public DataSize Terabytes(double terabytes)
        {
            return DataSize.Gigabytes(terabytes * 1024);
        }

        static readonly public DataSize Zero = new DataSize(0);

        public DataSize(int n)
        {
            number_bytes = n;
        }

        public int GetNumberBytes()
        {
            return number_bytes;
        }

        public double GetAsBytes()
        {
            return number_bytes;
        }
        public double GetAsKilobytes()
        {
            return GetAsBytes() / 1024;
        }
        public double GetAsMegabytes()
        {
            return GetAsKilobytes() / 1024;
        }
        public double GetAsGigabytes()
        {
            return GetAsMegabytes() / 1024;
        }
        public double GetAsTerabytes()
        {
            return GetAsGigabytes() / 1024;
        }
    }
}
