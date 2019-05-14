using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        public class BufferDefermentException_MissingEntity : BufferDefermentException
        {
            private int id;

            private EntityManager manager;

            public BufferDefermentException_MissingEntity(int i, EntityManager m)
            {
                id = i;

                manager = m;
            }

            public override bool IsReadyForReattempt()
            {
                if (manager.CanDereferenceEntity(id))
                    return true;

                return false;
            }
        }
    }
}