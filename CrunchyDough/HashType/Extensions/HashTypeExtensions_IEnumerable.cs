using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class HashTypeExtensions_IEnumerable
    {
        static public ByteSequence Calculate(this HashType item, IEnumerable<byte> input)
        {
            return item.Calculate(input.ToArray());
        }
    }
}