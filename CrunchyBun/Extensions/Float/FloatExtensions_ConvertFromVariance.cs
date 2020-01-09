using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class FloatExtensions_ConvertFromVariance
    {
        static public float ConvertFromVarianceToOffset(this float item, float value, float radius)
        {
            return (item - value) / radius;
        }
        static public float ConvertFromVarianceToOffset(this float item, FloatVariance variance)
        {
            return item.ConvertFromVarianceToOffset(variance.value, variance.radius);
        }

        static public float ConvertFromVarianceToPercent(this float item, float value, float radius)
        {
            return item.ConvertFromVarianceToOffset(value, radius).ConvertFromOffsetToPercent();
        }
        static public float ConvertFromVarianceToPercent(this float item, FloatVariance variance)
        {
            return item.ConvertFromVarianceToPercent(variance.value, variance.radius);
        }

        static public float ConvertFromVarianceToVariance(this float item, float src_value, float src_radius, float dst_value, float dst_radius)
        {
            return item.ConvertFromVarianceToOffset(src_value, src_radius)
                .ConvertFromOffsetToVariance(dst_value, dst_radius);
        }
        static public float ConvertFromVarianceToVariance(this float item, FloatVariance src, FloatVariance dst)
        {
            return item.ConvertFromVarianceToVariance(src.value, src.radius, dst.value, dst.radius);
        }
    }
}