using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class RigidBodyExtensions_Roll
    {
        static public void AddRoll(this Rigidbody item, Vector3 direction, float force, ForceMode force_mode, Vector3 down)
        {
            Quaternion q = Quaternion.FromToRotation(direction, down);

            item.AddTorque(q.x * force, q.y * force, q.z * force, force_mode);
        }
        static public void AddRoll(this Rigidbody item, Vector3 direction, float force, ForceMode force_mode)
        {
            item.AddRoll(direction, force, force_mode, Vector3.down);
        }
        static public void AddRoll(this Rigidbody item, Vector3 direction, float force)
        {
            item.AddRoll(direction, force, ForceMode.VelocityChange);
        }

        static public void AddRoll(this Rigidbody item, Vector3 magnitude, ForceMode force_mode, Vector3 down)
        {
            float force;
            Vector3 direction = magnitude.GetNormalized(out force);

            item.AddRoll(direction, force, force_mode, down);
        }
        static public void AddRoll(this Rigidbody item, Vector3 magnitude, ForceMode force_mode)
        {
            item.AddRoll(magnitude, force_mode, Vector3.down);
        }
        static public void AddRoll(this Rigidbody item, Vector3 magnitude)
        {
            item.AddRoll(magnitude, ForceMode.VelocityChange);
        }
    }
}