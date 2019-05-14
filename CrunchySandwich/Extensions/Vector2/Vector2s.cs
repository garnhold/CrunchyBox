using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Vector2s
	{
	
		static public IEnumerable<Vector2> RadialFromRadians(IEnumerable<float> angles)
        {
            return angles.Convert(a => Vector2Extensions.CreateDirectionFromRadians(a));
        }

		static public IEnumerable<Vector2> RadialFromRadians(IEnumerable<float> angles, float magnitude)
        {
			return RadialFromRadians(angles).Convert(v => v * magnitude);
        }

		static public IEnumerable<Vector2> RadialFromRadians(float angle, IEnumerable<float> magnitudes)
		{
			Vector2 direction = Vector2Extensions.CreateDirectionFromRadians(angle);

			return magnitudes.Convert(m => direction * m);
		}

		static public IEnumerable<Vector2> RadialFromRadians(IEnumerable<float> angles, IEnumerable<float> magnitudes)
        {
			return angles.Convert(a => RadialFromRadians(a, magnitudes));
        }
	
		static public IEnumerable<Vector2> RadialFromDegrees(IEnumerable<float> angles)
        {
            return angles.Convert(a => Vector2Extensions.CreateDirectionFromDegrees(a));
        }

		static public IEnumerable<Vector2> RadialFromDegrees(IEnumerable<float> angles, float magnitude)
        {
			return RadialFromDegrees(angles).Convert(v => v * magnitude);
        }

		static public IEnumerable<Vector2> RadialFromDegrees(float angle, IEnumerable<float> magnitudes)
		{
			Vector2 direction = Vector2Extensions.CreateDirectionFromDegrees(angle);

			return magnitudes.Convert(m => direction * m);
		}

		static public IEnumerable<Vector2> RadialFromDegrees(IEnumerable<float> angles, IEnumerable<float> magnitudes)
        {
			return angles.Convert(a => RadialFromDegrees(a, magnitudes));
        }
	
		static public IEnumerable<Vector2> RadialFromPercent(IEnumerable<float> angles)
        {
            return angles.Convert(a => Vector2Extensions.CreateDirectionFromPercent(a));
        }

		static public IEnumerable<Vector2> RadialFromPercent(IEnumerable<float> angles, float magnitude)
        {
			return RadialFromPercent(angles).Convert(v => v * magnitude);
        }

		static public IEnumerable<Vector2> RadialFromPercent(float angle, IEnumerable<float> magnitudes)
		{
			Vector2 direction = Vector2Extensions.CreateDirectionFromPercent(angle);

			return magnitudes.Convert(m => direction * m);
		}

		static public IEnumerable<Vector2> RadialFromPercent(IEnumerable<float> angles, IEnumerable<float> magnitudes)
        {
			return angles.Convert(a => RadialFromPercent(a, magnitudes));
        }
	
	}
}

