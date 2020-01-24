using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class JointExtensions_Connect
    {
        static public void ConnectAtWorld(this Joint item, Rigidbody target, Vector3 world_position)
        {
            item.autoConfigureConnectedAnchor = false;

            item.anchor = item.transform.InverseTransformPoint(world_position);

            item.connectedBody = target;
            item.connectedAnchor = target.IfNotNull(t => t.transform.InverseTransformPoint(world_position), world_position);
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

            item.autoConfigureConnectedAnchor = false;

            item.anchor = local_position;

            item.connectedBody = target;
            item.connectedAnchor = target.IfNotNull(t => t.transform.InverseTransformPoint(world_position), world_position);
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

            item.autoConfigureConnectedAnchor = false;

            item.anchor = item.transform.InverseTransformPoint(world_position);

            item.connectedBody = target;
            item.connectedAnchor = local_position;
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
    }
}