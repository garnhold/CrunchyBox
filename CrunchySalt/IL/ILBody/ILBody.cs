using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILBody
    {
        private MethodBase method;
        private ILStatement statement;

        static public ILBody Write(MethodBase method, ILGenerator generator, ILStatement statement)
        {
            ILBody body = new ILBody(method, statement);

            body.Write(generator);
            return body;
        }

        static public ILBody Write(DynamicMethod method, ILStatement statement)
        {
            return Write(method, method.GetILGenerator(), statement);
        }
        static public ILBody Write(ConstructorBuilderEX builder, ILStatement statement)
        {
            return Write(builder, builder.GetILGenerator(), statement);
        }
        static public ILBody Write(MethodBuilderEX builder, ILStatement statement)
        {
            return Write(builder, builder.GetILGenerator(), statement);
        }

        public ILBody(MethodBase m, ILStatement s)
        {
            method = m;
            statement = s;
        }

        public void Write(ILCanvas canvas)
        {
            statement.RenderIL_Execute(canvas);

            if (method.HasReturn())
            {
                new ILReturn(new ILDefault(method.GetReturnType()))
                    .RenderIL_Execute(canvas);
            }
            else
            {
                new ILReturn().RenderIL_Execute(canvas);
            }
        }

        public void Write(ILGenerator generator)
        {
            Write(new ILCanvas_ILGenerator(method, generator));
        }

        public void Write(ILTextCanvas text_canvas)
        {
            Write(new ILCanvas_ILTextCanvas(method, text_canvas));
        }

        public override string ToString()
        {
            ILTextCanvas canvas = new ILTextCanvas(method);

            canvas.AppendToLine(method.ToStringEX());
            canvas.AppendToNewline("{");
            canvas.Indent();

            statement.RenderText_Statement(canvas);

            canvas.Dedent();
            canvas.AppendToNewline("}");

            canvas.AppendNewline();
            canvas.AppendNewline();
            Write(canvas);

            return canvas.ToString();
        }
    }
}