using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public abstract class InspectTypeSourceAttribute : Attribute
    {
        public abstract IEnumerable<Type> GetTypes();
    }
}