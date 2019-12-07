using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class TextDocumentNode_Container : TextDocumentNode, DocumentNodeContainer<TextDocumentNode, TextDocumentCanvas>
    {
        private List<TextDocumentNode> children;
        private TextDocumentNodeType child_text_document_node_type;

        public TextDocumentNode_Container(TextDocumentNodeType t, TextDocumentNodeType c) : base(t)
        {
            children = new List<TextDocumentNode>();

            child_text_document_node_type = c;
        }

        public void Clear()
        {
            children.Clear();
        }

        public void Add(TextDocumentNode to_add)
        {
            if (to_add != null)
            {
                if (to_add.GetTextDocumentNodeType() == child_text_document_node_type)
                    children.Add(to_add);
            }
        }

        public bool Remove(TextDocumentNode to_remove)
        {
            return children.Remove(to_remove);
        }

        public override bool IsVisible()
        {
            if (this.HasVisibleChild())
                return true;

            return false;
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            this.RenderChildren(canvas);
        }

        public IEnumerable<TextDocumentNode> GetChildren()
        {
            return children;
        }
    }
}