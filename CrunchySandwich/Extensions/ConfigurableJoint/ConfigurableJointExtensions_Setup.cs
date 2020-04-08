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

        static public ConfigurableJoint SetupAsLimitedBallJoint(this ConfigurableJoint item, float free_angle, float spring = 0.0f, float damper = 0.0f)
        {
            item.xMotion = ConfigurableJointMotion.Locked;
            item.yMotion = ConfigurableJointMotion.Locked;
            item.zMotion = ConfigurableJointMotion.Locked;

            item.angularXMotion = ConfigurableJointMotion.Limited;
            item.angularYMotion = ConfigurableJointMotion.Free;
            item.angularZMotion = ConfigurableJointMotion.Limited;

            item.lowAngularXLimit = new SoftJointLimit() { limit = free_angle * -0.5f };
            item.highAngularXLimit = new SoftJointLimit() { limit = free_angle * 0.5f };

            item.angularXLimitSpring = new SoftJointLimitSpring() {
                spring = spring,
                damper = damper
            };

            return item;
        }
    }
}