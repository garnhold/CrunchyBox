using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberRealExtensions_Binding
    {
        static public float BindMagnitudeBelow(this float item, float bound)
        {
            if(item > 0.0f)
            {
                float positive = bound.GetPositive();
                
                if(item > positive)
                    return positive;
            }
            else
            {
                float negative = bound.GetNegative();
                
                if(item < negative)
                    return negative;
            }
            
            return item;
        }
        static public float BindMagnitudeAbove(this float item, float bound)
        {
        
            if(item > 0.0f)
            {
                float positive = bound.GetPositive();
                
                if(item < positive)
                    return positive;
            }
            else
            {
                float negative = bound.GetNegative();
                
                if(item > negative)
                    return negative;
            }
            
            return item;
        }
        static public double BindMagnitudeBelow(this double item, double bound)
        {
            if(item > 0.0)
            {
                double positive = bound.GetPositive();
                
                if(item > positive)
                    return positive;
            }
            else
            {
                double negative = bound.GetNegative();
                
                if(item < negative)
                    return negative;
            }
            
            return item;
        }
        static public double BindMagnitudeAbove(this double item, double bound)
        {
        
            if(item > 0.0)
            {
                double positive = bound.GetPositive();
                
                if(item < positive)
                    return positive;
            }
            else
            {
                double negative = bound.GetNegative();
                
                if(item > negative)
                    return negative;
            }
            
            return item;
        }
        static public decimal BindMagnitudeBelow(this decimal item, decimal bound)
        {
            if(item > 0.0m)
            {
                decimal positive = bound.GetPositive();
                
                if(item > positive)
                    return positive;
            }
            else
            {
                decimal negative = bound.GetNegative();
                
                if(item < negative)
                    return negative;
            }
            
            return item;
        }
        static public decimal BindMagnitudeAbove(this decimal item, decimal bound)
        {
        
            if(item > 0.0m)
            {
                decimal positive = bound.GetPositive();
                
                if(item < positive)
                    return positive;
            }
            else
            {
                decimal negative = bound.GetNegative();
                
                if(item > negative)
                    return negative;
            }
            
            return item;
        }
	}
}

