using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Layout
    {
        static public float GetLayoutWidth(this string item, Operation<float, char> operation)
        {
            float width = 0.0f;

            for (int i = 0; i < item.Length; i++)
                width += operation(item[i]);

            return width;
        }

        static public string Layout(this string item, float max_width, Operation<float, char> operation)
        {
            float space_width = operation(' ');
            StringBuilder builder = new StringBuilder();

            item.GetLines().ProcessWithInterleaving(delegate(string line) {
                float current_width = 0.0f;

                foreach (string island in line.GetIslands())
                {
                    float island_width = island.GetLayoutWidth(operation);
                    float new_width = current_width + island_width;

                    if (new_width <= max_width)
                        current_width = new_width;
                    else
                    {
                        builder.Append("\n");
                        current_width = island_width;
                    }

                    builder.Append(island);
                    builder.Append(" ");
                    current_width += space_width;
                }
            }, delegate() {
                builder.Append("\n");
            });

            return builder.ToString();
        }
    }
}