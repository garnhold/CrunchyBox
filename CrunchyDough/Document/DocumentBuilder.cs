using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class DocumentBuilder<DOCUMENT_NODE_TYPE, CANVAS_TYPE> where DOCUMENT_NODE_TYPE : DocumentNode<CANVAS_TYPE>
    {
        private DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> root_container;
        private DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> active_container;

        public DocumentBuilder(DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE> c)
        {
            root_container = c;
            active_container = root_container;
        }

        public J Add<J>(J to_add) where J : DOCUMENT_NODE_TYPE
        {
            return active_container.AddAndGet(to_add);
        }

        public J Add<J>(J to_add, Process process) where J : DOCUMENT_NODE_TYPE, DocumentNodeContainer<DOCUMENT_NODE_TYPE, CANVAS_TYPE>
        {
            Add(to_add);
                to_add.PushPopInto(ref active_container, process);
            return to_add;
        }
    }
}