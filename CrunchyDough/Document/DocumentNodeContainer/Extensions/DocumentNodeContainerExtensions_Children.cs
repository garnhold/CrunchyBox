using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class DocumentNodeContainerExtensions_Children
    {
        static public bool HasVisibleChild<DOCUMENT_NODE_TYPE, CANVAS_TYPE>(this DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> item) where DOCUMENT_NODE_TYPE : DocumentNode<CANVAS_TYPE>
        {
            return item.GetChildren().Has(c => c.IsVisible());
        }

        static public void RenderChildren<DOCUMENT_NODE_TYPE, CANVAS_TYPE>(this DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> item, CANVAS_TYPE canvas) where DOCUMENT_NODE_TYPE : DocumentNode<CANVAS_TYPE>
        {
            item.GetChildren().Narrow(c => c.IsVisible()).Process(c => c.Render(canvas));
        }

        static public IEnumerable<DOCUMENT_NODE_TYPE> GetDeepChildren<DOCUMENT_NODE_TYPE, CANVAS_TYPE>(this DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> item) where DOCUMENT_NODE_TYPE : DocumentNode<CANVAS_TYPE>
        {
            foreach (DOCUMENT_NODE_TYPE child in item.GetChildren())
            {
                yield return child;

                DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> child_container;
                if (child.Convert<DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE>>(out child_container))
                {
                    foreach (DOCUMENT_NODE_TYPE sub_child in child_container.GetDeepChildren())
                        yield return sub_child;
                }
            }
        }
    }
}