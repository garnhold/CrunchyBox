using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Chunk
    {
        static public IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> item, int chunk_size, bool is_strict)
        {
            if (item != null)
            {
                using (IEnumerator<T> iter = item.GetEnumerator())
                {
                    while (true)
                    {
                        List<T> chunk = new List<T>();
                        for (int i = 0; i < chunk_size; i++)
                        {
                            if (iter.MoveNext() == false)
                            {
                                if (is_strict == false)
                                {
                                    if (chunk.IsNotEmpty())
                                        yield return chunk;
                                }

                                yield break;
                            }

                            chunk.Add(iter.Current);
                        }

                        yield return chunk;
                    }
                }
            }
        }

        static public IEnumerable<IEnumerable<T>> ChunkPermissive<T>(this IEnumerable<T> item, int chunk_size)
        {
            return item.Chunk(chunk_size, false);
        }

        static public IEnumerable<IEnumerable<T>> ChunkStrict<T>(this IEnumerable<T> item, int chunk_size)
        {
            return item.Chunk(chunk_size, true);
        }
    }
}