using System;
using System.IO;
using System.Resources;

namespace CrunchyDough
{
    static public class ResourceManagerExtensions_Get
    {
        static public object GetObjectBasicEX(this ResourceManager item, string id)
        {
            try
            {
                return item.GetObject(id);
            }
            catch (Exception)
            {
            }

            return null;
        }
        static public object GetObjectEX(this ResourceManager item, string id)
        {
            return item.GetObjectBasicEX(id) ??
                item.GetStringBasicEX(id);
        }
        static public T GetObjectEX<T>(this ResourceManager item, string id)
        {
            return item.GetObjectEX(id).Convert<T>();
        }

        static public string GetStringBasicEX(this ResourceManager item, string id)
        {
            try
            {
                return item.GetString(id);
            }
            catch (Exception)
            {
            }

            return null;
        }
        static public string GetStringEX(this ResourceManager item, string id)
        {
            return item.GetStringBasicEX(id);
        }

        static public Stream GetStreamBasicEX(this ResourceManager item, string id)
        {
            try
            {
                return item.GetStream(id);
            }
            catch (Exception)
            {
            }

            return null;
        }
        static public Stream GetStreamEX(this ResourceManager item, string id)
        {
            return item.GetStreamBasicEX(id) ??
                item.GetStringBasicEX(id).IfNotNull(s => s.CreateStream()) ??
                item.GetObjectEX<byte[]>(id).IfNotNull(b => b.GetStream());
        }
    }
}