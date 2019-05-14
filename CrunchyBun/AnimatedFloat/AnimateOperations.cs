using System;

using CrunchyDough;

namespace CrunchyBun
{
    public delegate float AnimateOperation(float current, float target, float delta_time);

    static public class AnimateOperations
    {
        static public AnimateOperation CreateLinear(float speed)
        {
            return delegate(float current, float target, float delta_time) {
                return current.GetTowards(target, speed * delta_time);
            };
        }

        static public AnimateOperation CreateEase(float speed)
        {
            return delegate(float current, float target, float delta_time) {
                return current.GetInterpolate(target, speed * delta_time);
            };
        }
    }
}