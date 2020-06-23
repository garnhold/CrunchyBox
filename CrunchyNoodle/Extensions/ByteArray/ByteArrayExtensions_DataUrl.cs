using System;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;

    static public class ByteArrayExtensions_DataUrl
    {
        static public string ToBase64DataUrl(this byte[] item, MIMEType mime_type)
        {
            return "data:{0};base64,{1}".Inject(
                mime_type,
                item.ToBase64String()
            );
        }
    }
}