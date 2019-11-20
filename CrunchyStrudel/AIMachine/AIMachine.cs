using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public class AIMachine
    {
        private AIMachineNode current_node;

        public AIMachine(AIMachineNode n)
        {
            current_node = n;
        }

        public void Update()
        {
            current_node = current_node.Transition(
                current_node.IfNotNull(n => n.Update()),
                n => n.Resume(),
                n => n.Suspend()
            );
        }
    }
}