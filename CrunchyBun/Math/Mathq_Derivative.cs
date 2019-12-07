using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public partial class Mathq
    {
        static public Operation<float, float> GetDerivative(Operation<float, float> function, float delta)
        {
            return delegate(float x) {
                return (function(x + delta) - function(x)) / delta;
            };
        }
        static public Operation<float, float> GetDerivative(Operation<float, float> function)
        {
            return GetDerivative(function, 1e-6f);
        }
    }
}