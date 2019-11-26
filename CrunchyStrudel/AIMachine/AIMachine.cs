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
            current_node.IfNotNull(z => z.Resume());
        }

        public void Update()
        {
            current_node = current_node.Transition(
                current_node.IfNotNull(n => n.Update()),
                n => n.Resume(),
                n => n.Suspend()
            );
        }

        public override string ToString()
        {
            return "AIMachine(" + current_node.IfNotNull(n => n.GetName()) + ")";
        }
    }
}