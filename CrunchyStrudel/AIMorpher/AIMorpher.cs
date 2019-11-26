using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public class AIMorpher
    {
        private AIMorpherNode current_node;

        public AIMorpher(AIMorpherNode n)
        {
            current_node = n;
            current_node.IfNotNull(z => z.Resume());
        }

        public void Update(float step)
        {
            current_node = current_node.Transition(
                current_node.IfNotNull(n => n.Update(step)),
                n => n.Resume(),
                n => n.Suspend()
            );
        }
    }
}