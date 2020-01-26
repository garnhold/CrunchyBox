using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class TextGenerationSettingsExtensions_Mesh
    {
        static public Mesh CreateMesh(this TextGenerationSettings item, string text)
        {
            TextGenerator generator = new TextGenerator();

            generator.Populate(text, item);
            return generator.CreateMesh();
        }

        static public void CreateAndUseMesh(this TextGenerationSettings item, string text, Process<Mesh> process)
        {
            Mesh mesh = item.CreateMesh(text);

                process(mesh);

            Mesh.DestroyImmediate(mesh);
        }
    }
}