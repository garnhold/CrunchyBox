using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    static public class NetworkActorExtensions_SyncronizerEntity
    {
        static public bool HasAuthorityOver(this NetworkActor item, Syncronizer.Entity entity)
        {
            return item.HasAuthorityOver(entity.GetAuthority());
        }
    }
}