using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    public interface Surface<T>
    {
        void MixPigmentAt(int x, int y, T pigment, float coverage, Mixer<T> pigment_mixer);

        void SetPigmentAt(int x, int y, T pigment);
        T GetPigmentAt(int x, int y);

        int GetWidth();
        int GetHeight();

        IEnumerable<SurfacePoint> GetSurfacePoints();
    }
}