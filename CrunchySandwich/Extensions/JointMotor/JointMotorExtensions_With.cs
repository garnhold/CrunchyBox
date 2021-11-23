using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class JointMotorExtensions_With
    {
        static public JointMotor GetWithForce(this JointMotor item, float force)
        {
            return new JointMotor() {
                force = force,
                targetVelocity = item.targetVelocity,
                freeSpin = item.freeSpin
            };
        }
        static public JointMotor GetWithTargetVelocity(this JointMotor item, float target_velocity)
        {
            return new JointMotor() {
                force = item.force,
                targetVelocity = target_velocity,
                freeSpin = item.freeSpin
            };
        }
        static public JointMotor GetWithFreeSpin(this JointMotor item, bool free_spin)
        {
            return new JointMotor() {
                force = item.force,
                targetVelocity = item.targetVelocity,
                freeSpin = free_spin
            };
        }
    }
}