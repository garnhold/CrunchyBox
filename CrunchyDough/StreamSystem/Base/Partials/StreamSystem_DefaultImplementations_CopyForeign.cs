using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract partial class StreamSystem
    {
        public virtual AttemptResult CopyDirectoryForeign(string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            if (dst.CreateDirectory(dst_path, milliseconds).IsDesired())
            {
                AttemptResult result = AttemptResult.Succeeded;

                result = GetStreamNames(src_path).Apply(result,
                    (r, n) => r.GetAbsorbed(
                        CopyStreamForeign(
                            Filename.ForwardCombine(src_path, n),
                            dst, 
                            Filename.ForwardCombine(dst_path, n), 
                            overwrite, 
                            milliseconds
                        )
                    )
                );

                result = GetDirectoryNames(src_path).Apply(result,
                    (r, n) => r.GetAbsorbed(
                        CopyDirectoryForeign(
                            Filename.ForwardCombine(src_path, n),
                            dst,
                            Filename.ForwardCombine(dst_path, n),
                            overwrite,
                            milliseconds
                        )
                    )
                );

                return result;
            }

            return AttemptResult.Failed;
        }

        public virtual AttemptResult CopyStreamForeign(string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            if (overwrite || dst.DoesStreamExist(dst_path) == false)
            {
                return dst.Write(dst_path, delegate(Stream stream) {
                    return this.AttemptReadIntoStream(src_path, stream, milliseconds);
                }, milliseconds);
            }

            return AttemptResult.Failed;
        }
    }
}