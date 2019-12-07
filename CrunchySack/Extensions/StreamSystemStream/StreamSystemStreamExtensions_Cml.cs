using System;

namespace Crunchy.Sack
{
    using Dough;
    
    static public class StreamSystemStreamExtensions_Cml
    {
        static public AttemptResult AttemptReadCmlClassDefinition(this StreamSystemStream item, out CmlClassDefinition class_definition, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadCmlClassDefinition(item.GetPath(), out class_definition, milliseconds);
        }
        static public CmlClassDefinition ReadCmlClassDefinition(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().ReadCmlClassDefinition(item.GetPath(), milliseconds);
        }

        static public AttemptResult AttemptReadCmlFragmentDefinition(this StreamSystemStream item, out CmlFragmentDefinition fragment_definition, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadCmlFragmentDefinition(item.GetPath(), out fragment_definition, milliseconds);
        }
        static public CmlFragmentDefinition ReadCmlFragmentDefinition(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().ReadCmlFragmentDefinition(item.GetPath(), milliseconds);
        }
    }
}