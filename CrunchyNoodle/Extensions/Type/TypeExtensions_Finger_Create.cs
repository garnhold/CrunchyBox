using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public delegate int FingerPrintOperation(object obj);
    public delegate bool IsFingerEquivolentOperation(object obj1, object obj2);

    static public class TypeExtensions_Finger_Create
    {
        static private int GetHashCodeEX(object obj)
        {
            return obj.GetHashCodeEX();
        }
        static public FingerPrintOperation CreateFingerPrintOperation(this Type item)
        {
            MethodInfoEX get_hash_code_ex_method = typeof(TypeExtensions_Finger_Create).GetStaticMethod<object>("GetHashCodeEX");

            return item.CreateDynamicMethodDelegate<FingerPrintOperation>("FingerPrint_" + item.Name, delegate(MethodBase method){
                ILBlock body = new ILBlock();

                ILLocal obj = body.CreateLocal(item, "this");
                ILLocal hash = body.CreateLocal(typeof(int), "hash");

                body.AddStatement(new ILAssign(obj, method.GetTechnicalILParameter(0)));
                body.AddStatement(new ILAssign(hash, 17));

                foreach (FieldInfo field in item.GetAllInstanceFields())
                {
                    body.AddStatement(
                        new ILAssign(
                            hash,
                            hash * 23 + get_hash_code_ex_method.GetStaticILMethodInvokation(obj.GetILField(field))
                        )
                    );
                }

                body.AddStatement(new ILReturn(hash));
                return body;
            });
        }

        static private bool EqualsEX(object obj1, object obj2)
        {
            return obj1.EqualsEX(obj2);
        }
        static public IsFingerEquivolentOperation CreateIsFingerEquivolentOperation(this Type item)
        {
            MethodInfoEX equals_ex_method = typeof(TypeExtensions_Finger_Create).GetStaticMethod<object, object>("EqualsEX");

            return item.CreateDynamicMethodDelegate<IsFingerEquivolentOperation>("IsFingerEquivolent_" + item.Name, delegate(MethodBase method) {
                ILBlock body = new ILBlock();

                ILLocal obj1 = body.CreateLocal(item, "obj1", method.GetTechnicalILParameter(0), true);
                ILLocal obj2 = body.CreateLocal(item, "obj2", method.GetTechnicalILParameter(1), true);

                body.AddStatement(new ILIf(
                    obj1.GetILIsNotNull() & obj2.GetILIsNotNull(),

                    new ILBlock(delegate(ILBlock block) {
                        foreach (FieldInfo field in item.GetAllInstanceFields())
                        {
                            block.AddStatement(new ILIf(
                                equals_ex_method.GetStaticILMethodInvokation(
                                    obj1.GetILField(field),
                                    obj2.GetILField(field)
                                ).GetILIsFalse(),
                                new ILReturn(false)
                            ));
                        }

                        block.AddStatement(new ILReturn(true));
                    })
                ));

                body.AddStatement(new ILReturn(false));
                return body;
            });
        }
    }
}