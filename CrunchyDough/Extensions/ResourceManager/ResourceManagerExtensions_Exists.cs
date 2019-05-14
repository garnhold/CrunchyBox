using System;
using System.Resources;

namespace CrunchyDough
{
    static public class ResourceManagerExtensions_Exists
    {
        static public bool DoesResourceExist(this ResourceManager item, string id)
        {
            try
            {
                if(item.GetObject(id) != null)
                    return true;
            }
            catch (Exception)
            {
            }

            return false;
        }
    }
}