using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class DocumentNodeContainerExtensions_Add
    {
        static public J AddAndGet<DOCUMENT_NODE_TYPE, CANVAS_TYPE, J>(this DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> item, J to_add) where J : DOCUMENT_NODE_TYPE where DOCUMENT_NODE_TYPE : DocumentNode<CANVAS_TYPE>
        {
            item.Add(to_add);
            return to_add;
        }

        static public void Add<DOCUMENT_NODE_TYPE, CANVAS_TYPE>(this DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> item, IEnumerable<DOCUMENT_NODE_TYPE> to_add) where DOCUMENT_NODE_TYPE : DocumentNode<CANVAS_TYPE>
        {
            to_add.Process(n => item.Add(n));
        }
        static public void Add<DOCUMENT_NODE_TYPE, CANVAS_TYPE>(this DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> item, params DOCUMENT_NODE_TYPE[] to_add) where DOCUMENT_NODE_TYPE : DocumentNode<CANVAS_TYPE>
        {
            item.Add<DOCUMENT_NODE_TYPE, CANVAS_TYPE>((IEnumerable<DOCUMENT_NODE_TYPE>)to_add);
        }
    }
}