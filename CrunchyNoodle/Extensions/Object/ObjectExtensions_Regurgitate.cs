using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_Regurgitate
    {
        static private void Regurgitate_Null(object item, TextDocumentCanvas canvas, int max_depth, bool verbose_exceptions)
        {
            canvas.AppendToLine("null");
        }
        static private void Regurgitate_Primitive(object item, TextDocumentCanvas canvas, int max_depth, bool verbose_exceptions)
        {
            canvas.AppendToLine(item.ToString());
        }
        static private void Regurgitate_IEnumerable(IEnumerable item, TextDocumentCanvas canvas, int max_depth, bool verbose_exceptions)
        {
            canvas.AppendToLine("[");
            canvas.Indent();

            foreach (object sub_item in item)
            {
                canvas.AppendNewline();
                sub_item.Regurgitate(canvas, max_depth - 1, verbose_exceptions);
                canvas.AppendToLine(";");
            }

            canvas.Dedent();
            canvas.AppendToNewline("]");
        }
        static private void Regurgitate_Object(object item, TextDocumentCanvas canvas, int max_depth, bool verbose_exceptions)
        {
            canvas.AppendToLine(item.GetType().ToString());
            canvas.AppendToLine("{");
            canvas.Indent();

            foreach (FieldInfoEX field in item.GetAllInstanceFields())
            {
                canvas.AppendNewline();
                canvas.AppendToLine(field.Name);
                canvas.AppendToLine(": ");
                field.GetValue(item).Regurgitate(canvas, max_depth - 1, verbose_exceptions);
                canvas.AppendToLine(";");
            }

            canvas.Dedent();
            canvas.AppendToNewline("}");
        }

        static public void Regurgitate(this object item, TextDocumentCanvas canvas, int max_depth, bool verbose_exceptions)
        {
            try
            {
                if (max_depth >= 1)
                {
                    if (item == null)
                        Regurgitate_Null(item, canvas, max_depth, verbose_exceptions);
                    else
                    {
                        Type type = item.GetTypeEX();

                        if (type.IsPrimitive())
                            Regurgitate_Primitive(item, canvas, max_depth, verbose_exceptions);
                        else if (type.IsTypicalIEnumerable())
                            Regurgitate_IEnumerable((IEnumerable)item, canvas, max_depth, verbose_exceptions);
                        else
                            Regurgitate_Object(item, canvas, max_depth, verbose_exceptions);
                    }
                }
                else
                {
                    canvas.AppendToLine("(Exceeded Depth)");
                }
            }
            catch (Exception ex)
            {
                if (verbose_exceptions)
                    canvas.AppendToLine(ex.Message);
                else
                    canvas.AppendToLine("(Exception)");
            }
        }
        static public string Regurgitate(this object item, int max_depth, bool verbose_exceptions)
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            item.Regurgitate(canvas, max_depth, verbose_exceptions);
            return canvas.ToString();
        }
    }
}