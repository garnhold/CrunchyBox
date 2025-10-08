using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class NumberRealExtensions_ConvertFromVariance
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
        
        static public double ConvertFromVarianceToOffset(this double item, double value, double radius)
        {
            return (item - value) / radius;
        }
        static public double ConvertFromVarianceToOffset(this double item, DoubleVariance variance)
        {
            return item.ConvertFromVarianceToOffset(variance.value, variance.radius);
        }

        static public double ConvertFromVarianceToPercent(this double item, double value, double radius)
        {
            return item.ConvertFromVarianceToOffset(value, radius).ConvertFromOffsetToPercent();
        }
        static public double ConvertFromVarianceToPercent(this double item, DoubleVariance variance)
        {
            return item.ConvertFromVarianceToPercent(variance.value, variance.radius);
        }

        static public double ConvertFromVarianceToVariance(this double item, double src_value, double src_radius, double dst_value, double dst_radius)
        {
            return item.ConvertFromVarianceToOffset(src_value, src_radius)
                .ConvertFromOffsetToVariance(dst_value, dst_radius);
        }
        static public double ConvertFromVarianceToVariance(this double item, DoubleVariance src, DoubleVariance dst)
        {
            return item.ConvertFromVarianceToVariance(src.value, src.radius, dst.value, dst.radius);
        }
        
        static public decimal ConvertFromVarianceToOffset(this decimal item, decimal value, decimal radius)
        {
            return (item - value) / radius;
        }
        static public decimal ConvertFromVarianceToOffset(this decimal item, DecimalVariance variance)
        {
            return item.ConvertFromVarianceToOffset(variance.value, variance.radius);
        }

        static public decimal ConvertFromVarianceToPercent(this decimal item, decimal value, decimal radius)
        {
            return item.ConvertFromVarianceToOffset(value, radius).ConvertFromOffsetToPercent();
        }
        static public decimal ConvertFromVarianceToPercent(this decimal item, DecimalVariance variance)
        {
            return item.ConvertFromVarianceToPercent(variance.value, variance.radius);
        }

        static public decimal ConvertFromVarianceToVariance(this decimal item, decimal src_value, decimal src_radius, decimal dst_value, decimal dst_radius)
        {
            return item.ConvertFromVarianceToOffset(src_value, src_radius)
                .ConvertFromOffsetToVariance(dst_value, dst_radius);
        }
        static public decimal ConvertFromVarianceToVariance(this decimal item, DecimalVariance src, DecimalVariance dst)
        {
            return item.ConvertFromVarianceToVariance(src.value, src.radius, dst.value, dst.radius);
        }
        
    }
}

