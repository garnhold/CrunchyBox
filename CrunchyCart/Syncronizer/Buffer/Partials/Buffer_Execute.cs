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
        public partial class Buffer
        {
            public void ExecuteWrite(MessageType type)
            {
                WriteEnum(type);
            }

            public bool ExecuteRead(Process<MessageType> process)
            {
                if (deferment_exception == null || deferment_exception.IsReadyForReattempt())
                {
                    buffer.Position = 0;

                    try
                    {
                        MessageType message_type = ReadEnum<MessageType>();

                        process(message_type);
                        return true;
                    }
                    catch (BufferDefermentException ex)
                    {
                        deferment_exception = ex;
                    }
                }

                return false;
            }
        }
    }
}