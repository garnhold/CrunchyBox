using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class HingeJoint2DExtensions_Motor
    {
        static public void SetMotorMaxTorqueAndSpeed(this HingeJoint2D item, float max_torque, float speed)
        {
            item.motor = new JointMotor2D() {
                maxMotorTorque = max_torque,
                motorSpeed = speed
            };
        }

        static public void SetMotorMaxTorque(this HingeJoint2D item, float max_torque)
        {
            item.motor = item.motor.GetWithMaxTorque(max_torque);
        }

        static public void SetMotorSpeed(this HingeJoint2D item, float speed)
        {
            item.motor = item.motor.GetWithSpeed(speed);
        }

        static public float GetMotorMaxTorque(this HingeJoint2D item)
        {
            return item.motor.maxMotorTorque;
        }

        static public float GetMotorSpeed(this HingeJoint2D item)
        {
            return item.motor.motorSpeed;
        }
    }
}