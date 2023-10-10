using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public enum JunkTokenBehaviour
    {
        Character,
        String
    }

    static public class JunkTokenBehaviourExtensions
    {
        static public string GetPsuedoRegEx(this JunkTokenBehaviour item)
        {
            switch (item)
            {
                case JunkTokenBehaviour.Character: return "<JUNK>";
                case JunkTokenBehaviour.String: return "<JUNK>+";
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}