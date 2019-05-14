using System;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class RepresentationInfo : RepresentationEngineComponent
    {
        public abstract Type GetRepresentationType();
    }
}