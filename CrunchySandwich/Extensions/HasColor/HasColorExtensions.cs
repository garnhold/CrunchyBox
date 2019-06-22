using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class HasColorExtensions
    {
	
		static public void SetRed(this SpriteRenderer item, float value)
        {
            item.color = item.color.GetWithRed(value);
        }

		static public void AdjustRed(this SpriteRenderer item, float amount)
        {
            item.SetRed(item.GetRed() + amount);
        }

		static public void InterpolateRed(this SpriteRenderer item, float target, float amount)
        {
            item.SetRed(item.GetRed().GetInterpolate(target, amount));
        }

		static public float GetRed(this SpriteRenderer item)
        {
            return item.color.r;
        }
	
		static public void SetRed(this TextMesh item, float value)
        {
            item.color = item.color.GetWithRed(value);
        }

		static public void AdjustRed(this TextMesh item, float amount)
        {
            item.SetRed(item.GetRed() + amount);
        }

		static public void InterpolateRed(this TextMesh item, float target, float amount)
        {
            item.SetRed(item.GetRed().GetInterpolate(target, amount));
        }

		static public float GetRed(this TextMesh item)
        {
            return item.color.r;
        }
		
		static public void SetGreen(this SpriteRenderer item, float value)
        {
            item.color = item.color.GetWithGreen(value);
        }

		static public void AdjustGreen(this SpriteRenderer item, float amount)
        {
            item.SetGreen(item.GetGreen() + amount);
        }

		static public void InterpolateGreen(this SpriteRenderer item, float target, float amount)
        {
            item.SetGreen(item.GetGreen().GetInterpolate(target, amount));
        }

		static public float GetGreen(this SpriteRenderer item)
        {
            return item.color.g;
        }
	
		static public void SetGreen(this TextMesh item, float value)
        {
            item.color = item.color.GetWithGreen(value);
        }

		static public void AdjustGreen(this TextMesh item, float amount)
        {
            item.SetGreen(item.GetGreen() + amount);
        }

		static public void InterpolateGreen(this TextMesh item, float target, float amount)
        {
            item.SetGreen(item.GetGreen().GetInterpolate(target, amount));
        }

		static public float GetGreen(this TextMesh item)
        {
            return item.color.g;
        }
		
		static public void SetBlue(this SpriteRenderer item, float value)
        {
            item.color = item.color.GetWithBlue(value);
        }

		static public void AdjustBlue(this SpriteRenderer item, float amount)
        {
            item.SetBlue(item.GetBlue() + amount);
        }

		static public void InterpolateBlue(this SpriteRenderer item, float target, float amount)
        {
            item.SetBlue(item.GetBlue().GetInterpolate(target, amount));
        }

		static public float GetBlue(this SpriteRenderer item)
        {
            return item.color.b;
        }
	
		static public void SetBlue(this TextMesh item, float value)
        {
            item.color = item.color.GetWithBlue(value);
        }

		static public void AdjustBlue(this TextMesh item, float amount)
        {
            item.SetBlue(item.GetBlue() + amount);
        }

		static public void InterpolateBlue(this TextMesh item, float target, float amount)
        {
            item.SetBlue(item.GetBlue().GetInterpolate(target, amount));
        }

		static public float GetBlue(this TextMesh item)
        {
            return item.color.b;
        }
		
		static public void SetAlpha(this SpriteRenderer item, float value)
        {
            item.color = item.color.GetWithAlpha(value);
        }

		static public void AdjustAlpha(this SpriteRenderer item, float amount)
        {
            item.SetAlpha(item.GetAlpha() + amount);
        }

		static public void InterpolateAlpha(this SpriteRenderer item, float target, float amount)
        {
            item.SetAlpha(item.GetAlpha().GetInterpolate(target, amount));
        }

		static public float GetAlpha(this SpriteRenderer item)
        {
            return item.color.a;
        }
	
		static public void SetAlpha(this TextMesh item, float value)
        {
            item.color = item.color.GetWithAlpha(value);
        }

		static public void AdjustAlpha(this TextMesh item, float amount)
        {
            item.SetAlpha(item.GetAlpha() + amount);
        }

		static public void InterpolateAlpha(this TextMesh item, float target, float amount)
        {
            item.SetAlpha(item.GetAlpha().GetInterpolate(target, amount));
        }

		static public float GetAlpha(this TextMesh item)
        {
            return item.color.a;
        }
		}
}
