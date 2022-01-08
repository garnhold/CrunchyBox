using System;

namespace Crunchy.Dough
{
    static public class BasicEaseTypeExtensions
    {
        static public float Calculate(this BasicEaseType item, float x)
        {
            return Ease.Basic(item, x);
        }
    }
}