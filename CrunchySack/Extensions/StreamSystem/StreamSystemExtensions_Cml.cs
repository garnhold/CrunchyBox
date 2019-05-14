using System;

using CrunchyDough;

namespace CrunchySack
{
    static public class StreamSystemExtensions_Cml
    {
        static public AttemptResult AttemptReadCmlClassDefinition(this StreamSystem item, string path, out CmlClassDefinition class_definition, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptReadText<CmlClassDefinition>(path, delegate(string text) {
                return CmlClassDefinition.DOMify(text);
            }, out class_definition, milliseconds);
        }
        static public CmlClassDefinition ReadCmlClassDefinition(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            CmlClassDefinition output;

            item.AttemptReadCmlClassDefinition(path, out output, milliseconds);
            return output;
        }

        static public AttemptResult AttemptReadCmlFragmentDefinition(this StreamSystem item, string path, out CmlFragmentDefinition fragment_definition, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptReadText<CmlFragmentDefinition>(path, delegate(string text) {
                return CmlFragmentDefinition.DOMify(text);
            }, out fragment_definition, milliseconds);
        }
        static public CmlFragmentDefinition ReadCmlFragmentDefinition(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            CmlFragmentDefinition output;

            item.AttemptReadCmlFragmentDefinition(path, out output, milliseconds);
            return output;
        }
    }
}