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

		static public void InterpolateColor(this SpriteRenderer item, Color target, float amount)
        {
            item.color = item.color.GetInterpolate(target, amount);
        }

		static public void TowardsColor(this SpriteRenderer item, Color target, Color amount)
		{
			item.color = item.color.GetTowards(target, amount);
		}

		static public bool MoveTowardsColor(this SpriteRenderer item, Color target, Color amount)
		{
			Color output;
			bool result = item.color.GetMoveTowards(target, amount, out output);

			item.color = output;
			return result;
		}

	
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

		static public void TowardsRed(this SpriteRenderer item, float target, float amount)
		{
			item.SetRed(item.GetRed().GetTowards(target, amount));
		}

		static public bool MoveTowardsRed(this SpriteRenderer item, float target, float amount)
		{
			float output;
			bool result = item.GetRed().GetMoveTowards(target, amount, out output);

			item.SetRed(output);
			return result;
		}

		static public float GetRed(this SpriteRenderer item)
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

		static public void TowardsGreen(this SpriteRenderer item, float target, float amount)
		{
			item.SetGreen(item.GetGreen().GetTowards(target, amount));
		}

		static public bool MoveTowardsGreen(this SpriteRenderer item, float target, float amount)
		{
			float output;
			bool result = item.GetGreen().GetMoveTowards(target, amount, out output);

			item.SetGreen(output);
			return result;
		}

		static public float GetGreen(this SpriteRenderer item)
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

		static public void TowardsBlue(this SpriteRenderer item, float target, float amount)
		{
			item.SetBlue(item.GetBlue().GetTowards(target, amount));
		}

		static public bool MoveTowardsBlue(this SpriteRenderer item, float target, float amount)
		{
			float output;
			bool result = item.GetBlue().GetMoveTowards(target, amount, out output);

			item.SetBlue(output);
			return result;
		}

		static public float GetBlue(this SpriteRenderer item)
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

		static public void TowardsAlpha(this SpriteRenderer item, float target, float amount)
		{
			item.SetAlpha(item.GetAlpha().GetTowards(target, amount));
		}

		static public bool MoveTowardsAlpha(this SpriteRenderer item, float target, float amount)
		{
			float output;
			bool result = item.GetAlpha().GetMoveTowards(target, amount, out output);

			item.SetAlpha(output);
			return result;
		}

		static public float GetAlpha(this SpriteRenderer item)
        {
            return item.color.a;
        }
	
		static public void SetRGB(this SpriteRenderer item, float r, float g, float b)
		{
			item.color = item.color.GetWithRGB(r, g, b);
		}
		static public void SetRGB(this SpriteRenderer item, Color rgb)
		{
			item.color = item.color.GetWithRGB(rgb);
		}

		static public void InterpolateRGB(this SpriteRenderer item, Color target, float amount)
        {
            item.SetRGB(item.GetRGB().GetInterpolate(target, amount));
        }

		static public void TowardsRGB(this SpriteRenderer item, Color target, Color amount)
		{
			item.SetRGB(item.GetRGB().GetTowards(target, amount));
		}

		static public bool MoveTowardsRGB(this SpriteRenderer item, Color target, Color amount)
		{
			Color output;
			bool result = item.GetRGB().GetMoveTowards(target, amount, out output);

			item.SetRGB(output);
			return result;
		}

		static public Color GetRGB(this SpriteRenderer item)
        {
            return item.color.GetWithAlpha(1.0f);
        }
		static public void InterpolateColor(this TextMesh item, Color target, float amount)
        {
            item.color = item.color.GetInterpolate(target, amount);
        }

		static public void TowardsColor(this TextMesh item, Color target, Color amount)
		{
			item.color = item.color.GetTowards(target, amount);
		}

		static public bool MoveTowardsColor(this TextMesh item, Color target, Color amount)
		{
			Color output;
			bool result = item.color.GetMoveTowards(target, amount, out output);

			item.color = output;
			return result;
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

		static public void TowardsRed(this TextMesh item, float target, float amount)
		{
			item.SetRed(item.GetRed().GetTowards(target, amount));
		}

		static public bool MoveTowardsRed(this TextMesh item, float target, float amount)
		{
			float output;
			bool result = item.GetRed().GetMoveTowards(target, amount, out output);

			item.SetRed(output);
			return result;
		}

		static public float GetRed(this TextMesh item)
        {
            return item.color.r;
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

		static public void TowardsGreen(this TextMesh item, float target, float amount)
		{
			item.SetGreen(item.GetGreen().GetTowards(target, amount));
		}

		static public bool MoveTowardsGreen(this TextMesh item, float target, float amount)
		{
			float output;
			bool result = item.GetGreen().GetMoveTowards(target, amount, out output);

			item.SetGreen(output);
			return result;
		}

		static public float GetGreen(this TextMesh item)
        {
            return item.color.g;
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

		static public void TowardsBlue(this TextMesh item, float target, float amount)
		{
			item.SetBlue(item.GetBlue().GetTowards(target, amount));
		}

		static public bool MoveTowardsBlue(this TextMesh item, float target, float amount)
		{
			float output;
			bool result = item.GetBlue().GetMoveTowards(target, amount, out output);

			item.SetBlue(output);
			return result;
		}

		static public float GetBlue(this TextMesh item)
        {
            return item.color.b;
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

		static public void TowardsAlpha(this TextMesh item, float target, float amount)
		{
			item.SetAlpha(item.GetAlpha().GetTowards(target, amount));
		}

		static public bool MoveTowardsAlpha(this TextMesh item, float target, float amount)
		{
			float output;
			bool result = item.GetAlpha().GetMoveTowards(target, amount, out output);

			item.SetAlpha(output);
			return result;
		}

		static public float GetAlpha(this TextMesh item)
        {
            return item.color.a;
        }
	
		static public void SetRGB(this TextMesh item, float r, float g, float b)
		{
			item.color = item.color.GetWithRGB(r, g, b);
		}
		static public void SetRGB(this TextMesh item, Color rgb)
		{
			item.color = item.color.GetWithRGB(rgb);
		}

		static public void InterpolateRGB(this TextMesh item, Color target, float amount)
        {
            item.SetRGB(item.GetRGB().GetInterpolate(target, amount));
        }

		static public void TowardsRGB(this TextMesh item, Color target, Color amount)
		{
			item.SetRGB(item.GetRGB().GetTowards(target, amount));
		}

		static public bool MoveTowardsRGB(this TextMesh item, Color target, Color amount)
		{
			Color output;
			bool result = item.GetRGB().GetMoveTowards(target, amount, out output);

			item.SetRGB(output);
			return result;
		}

		static public Color GetRGB(this TextMesh item)
        {
            return item.color.GetWithAlpha(1.0f);
        }
	}
}
