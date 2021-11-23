using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class HingeJointExtensions_Motor
    {
        static public void SetMotorForceTargetVelocityAndFreeSpin(this HingeJoint item, float force, float target_velocity, bool free_spin)
        {
            item.motor = new JointMotor() {
                force = force,
                targetVelocity = target_velocity,
                freeSpin = free_spin
            };
        }

        static public void SetMotorForce(this HingeJoint item, float force)
        {
            item.motor = item.motor.GetWithForce(force);
        }
        static public void SetMotorTargetVelocity(this HingeJoint item, float target_velocity)
        {
            item.motor = item.motor.GetWithTargetVelocity(target_velocity);
        }
        static public void SetMotorFreeSpin(this HingeJoint item, bool free_spin)
        {
            item.motor = item.motor.GetWithFreeSpin(free_spin);
        }

        static public float GetMotorForce(this HingeJoint item)
        {
            return item.motor.force;
        }
        static public float GetMotorTargetVelocity(this HingeJoint item)
        {
            return item.motor.targetVelocity;
        }
        static public bool GetMotorFreeSpin(this HingeJoint item)
        {
            return item.motor.freeSpin;
        }
    }
}