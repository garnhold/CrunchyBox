using System;

namespace Crunchy.Salt
{
    static public class ProgrammingEntityName
    {
        static private int NEXT_ENTITY_NUMBER = 1;
        static public string GenerateEntityName()
        {
            return ("_auto" + (NEXT_ENTITY_NUMBER++)).StyleAsEntity();
        }

        static public string GenerateFunctionName()
        {
            return GenerateEntityName().StyleAsFunctionName();
        }

        static public string GenerateClassName()
        {
            return GenerateEntityName().StyleAsClassName();
        }

        static public string GenerateInterfaceName()
        {
            return GenerateEntityName().StyleAsInterfaceName();
        }

        static public string GenerateVariableName()
        {
            return GenerateEntityName().StyleAsVariableName();
        }
    }
}