using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class JointExtensions_Connect
    {
        static public void ConnectAtLocals(this Joint item, Vector3 self_position, Rigidbody target, Vector3 target_position)
        {
            item.autoConfigureConnectedAnchor = false;

            item.anchor = self_position;

            item.connectedBody = target;
            item.connectedAnchor = target_position;
        }
        static public void ConnectAtLocals(this Joint item, Vector3 self_position, Component target, Vector3 target_position)
        {
            item.ConnectAtLocals(self_position, target.GetComponentUpward<Rigidbody>(), target_position);
        }
        static public void ConnectAtLocals(this Joint item, Vector3 self_position, GameObject target, Vector3 target_position)
        {
            item.ConnectAtLocals(self_position, target.GetComponentUpward<Rigidbody>(), target_position);
        }

        static public void ConnectAtWorld(this Joint item, Rigidbody target, Vector3 world_position)
        {
            item.ConnectAtLocals(
                item.transform.InverseTransformPoint(world_position),
                target,
                target.IfNotNull(t => t.transform.InverseTransformPoint(world_position), world_position)
            );
        }
        static public void ConnectAtWorld(this Joint item, Component target, Vector3 position)
        {
            item.ConnectAtWorld(target.GetComponentUpward<Rigidbody>(), position);
        }
        static public void ConnectAtWorld(this Joint item, GameObject target, Vector3 position)
        {
            item.ConnectAtWorld(target.GetComponentUpward<Rigidbody>(), position);
        }

        static public void ConnectAtSelfLocal(this Joint item, Rigidbody target, Vector3 local_position)
        {
            Vector3 world_position = item.transform.TransformPoint(local_position);

            item.ConnectAtLocals(
                local_position,
                target,
                target.IfNotNull(t => t.transform.InverseTransformPoint(world_position), world_position)
            );
        }
        static public void ConnectAtSelfLocal(this Joint item, Component target, Vector3 local_position)
        {
            item.ConnectAtSelfLocal(target.GetComponentUpward<Rigidbody>(), local_position);
        }
        static public void ConnectAtSelfLocal(this Joint item, GameObject target, Vector3 local_position)
        {
            item.ConnectAtSelfLocal(target.GetComponentUpward<Rigidbody>(), local_position);
        }

        static public void ConnectAtTargetLocal(this Joint item, Rigidbody target, Vector3 local_position)
        {
            Vector3 world_position = target.IfNotNull(t => t.transform.TransformPoint(local_position), local_position);

            item.ConnectAtLocals(
                item.transform.InverseTransformPoint(world_position),
                target,
                local_position
            );
        }
        static public void ConnectAtTargetLocal(this Joint item, Component target, Vector3 local_position)
        {
            item.ConnectAtTargetLocal(target.GetComponentUpward<Rigidbody>(), local_position);
        }
        static public void ConnectAtTargetLocal(this Joint item, GameObject target, Vector3 local_position)
        {
            item.ConnectAtTargetLocal(target.GetComponentUpward<Rigidbody>(), local_position);
        }

        static public void ConnectToWorld(this Joint item, Vector3 world_position)
        {
            item.ConnectAtWorld((Rigidbody)null, world_position);
        }

        static public void ConnectTo(this Joint item, Component target)
        {
            item.ConnectAtWorld(target, item.GetSpacarPosition());
        }
        static public void ConnectTo(this Joint item, GameObject target)
        {
            item.ConnectAtWorld(target, item.GetSpacarPosition());
        }
        static public void UpdateConnection(this Joint item)
        {
            item.ConnectTo(item.connectedBody);
        }
    }
}