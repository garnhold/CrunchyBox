using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public interface DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> where DOCUMENT_NODE_TYPE : DocumentNode<CANVAS_TYPE>
    {
        void Clear();

        void Add(DOCUMENT_NODE_TYPE to_add);
        bool Remove(DOCUMENT_NODE_TYPE to_remove);

        IEnumerable<DOCUMENT_NODE_TYPE> GetChildren();
    }
}