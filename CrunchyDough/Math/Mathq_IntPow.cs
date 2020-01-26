using System;

namespace Crunchy.Dough
{
    static public partial class Mathq
    {
        static public float IntPow(float x1, int pow)
        {
            float x2;
            float x4;
            float x8;
            float x16;
            float x32;

            switch (pow)
            {
                case 0:
                    return 1.0f;

                case 1:
                    return x1;

                case 2:
                    x2 = x1 * x1;
                    return x2;

                case 3:
                    x2 = x1 * x1;
                    return x1 * x2;

                case 4:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    return x4;

                case 5:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    return x1 * x4;

                case 6:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    return x2 * x4;

                case 7:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    return x1 * x2 * x4;

                case 8:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    return x8;

                case 9:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    return x1 * x8;

                case 10:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    return x2 * x8;

                case 11:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    return x1 * x2 * x8;

                case 12:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    return x4 * x8;

                case 13:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    return x1 * x4 * x8;

                case 14:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    return x2 * x4 * x8;

                case 15:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    return x1 * x2 * x4 * x8;

                case 16:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x16;

                case 17:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x1 * x16;

                case 18:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x2 * x16;

                case 19:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x1 * x2 * x16;

                case 20:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x4 * x16;

                case 21:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x1 * x4 * x16;

                case 22:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x2 * x4 * x16;

                case 23:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x1 * x2 * x4 * x16;

                case 24:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x8 * x16;

                case 25:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x1 * x8 * x16;

                case 26:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x2 * x8 * x16;

                case 27:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x1 * x2 * x8 * x16;

                case 28:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x4 * x8 * x16;

                case 29:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x1 * x4 * x8 * x16;

                case 30:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x2 * x4 * x8 * x16;

                case 31:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    return x1 * x2 * x4 * x8 * x16;

                case 32:
                    x2 = x1 * x1;
                    x4 = x2 * x2;
                    x8 = x4 * x4;
                    x16 = x8 * x8;
                    x32 = x16 * x16;
                    return x32;
            }

            return (float)Math.Pow(x1, pow);
        }
    }
}