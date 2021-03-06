using System;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class HashType
    {
        public abstract HashAlgorithm CreateAlgorithm();

        public ByteSequence Calculate(byte[] input)
        {
            using(HashAlgorithm algorithm = CreateAlgorithm())
                return new ByteSequence(algorithm.ComputeHash(input));
        }

        public ByteSequence Calculate(Stream input)
        {
            using(HashAlgorithm algorithm = CreateAlgorithm())
                return new ByteSequence(algorithm.ComputeHash(input));
        }
    }
}