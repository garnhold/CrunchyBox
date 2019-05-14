using System;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class RepresentationModifier : RepresentationEngineComponent
    {
        public abstract Type GetRepresentationType();
    }
}