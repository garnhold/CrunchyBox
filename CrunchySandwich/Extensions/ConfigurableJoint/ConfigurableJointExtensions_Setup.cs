using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;    
    static public partial class ConfigurableJointExtensions_Setup
    {
        static public ConfigurableJoint SetupAsBallJoint(this ConfigurableJoint item)
        {
            item.xMotion = ConfigurableJointMotion.Locked;
            item.yMotion = ConfigurableJointMotion.Locked;
            item.zMotion = ConfigurableJointMotion.Locked;

            item.angularXMotion = ConfigurableJointMotion.Free;
            item.angularYMotion = ConfigurableJointMotion.Free;
            item.angularZMotion = ConfigurableJointMotion.Free;

            return item;
        }
    }
}