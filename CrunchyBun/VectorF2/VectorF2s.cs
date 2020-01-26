using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorF2s
	{
	
		static public IEnumerable<VectorF2> RadialFromRadians(IEnumerable<float> angles)
        {
            return angles.Convert(a => VectorF2Extensions.CreateDirectionFromRadians(a));
        }

		static public IEnumerable<VectorF2> RadialFromRadians(IEnumerable<float> angles, float magnitude)
        {
			return RadialFromRadians(angles).Convert(v => v * magnitude);
        }

		static public IEnumerable<VectorF2> RadialFromRadians(float angle, IEnumerable<float> magnitudes)
		{
			VectorF2 direction = VectorF2Extensions.CreateDirectionFromRadians(angle);

			return magnitudes.Convert(m => direction * m);
		}

		static public IEnumerable<VectorF2> RadialFromRadians(IEnumerable<float> angles, IEnumerable<float> magnitudes)
        {
			return angles.Convert(a => RadialFromRadians(a, magnitudes)).Flatten();
        }
	
		static public IEnumerable<VectorF2> RadialFromDegrees(IEnumerable<float> angles)
        {
            return angles.Convert(a => VectorF2Extensions.CreateDirectionFromDegrees(a));
        }

		static public IEnumerable<VectorF2> RadialFromDegrees(IEnumerable<float> angles, float magnitude)
        {
			return RadialFromDegrees(angles).Convert(v => v * magnitude);
        }

		static public IEnumerable<VectorF2> RadialFromDegrees(float angle, IEnumerable<float> magnitudes)
		{
			VectorF2 direction = VectorF2Extensions.CreateDirectionFromDegrees(angle);

			return magnitudes.Convert(m => direction * m);
		}

		static public IEnumerable<VectorF2> RadialFromDegrees(IEnumerable<float> angles, IEnumerable<float> magnitudes)
        {
			return angles.Convert(a => RadialFromDegrees(a, magnitudes)).Flatten();
        }
	
		static public IEnumerable<VectorF2> RadialFromPercent(IEnumerable<float> angles)
        {
            return angles.Convert(a => VectorF2Extensions.CreateDirectionFromPercent(a));
        }

		static public IEnumerable<VectorF2> RadialFromPercent(IEnumerable<float> angles, float magnitude)
        {
			return RadialFromPercent(angles).Convert(v => v * magnitude);
        }

		static public IEnumerable<VectorF2> RadialFromPercent(float angle, IEnumerable<float> magnitudes)
		{
			VectorF2 direction = VectorF2Extensions.CreateDirectionFromPercent(angle);

			return magnitudes.Convert(m => direction * m);
		}

		static public IEnumerable<VectorF2> RadialFromPercent(IEnumerable<float> angles, IEnumerable<float> magnitudes)
        {
			return angles.Convert(a => RadialFromPercent(a, magnitudes)).Flatten();
        }
	
	}
}

