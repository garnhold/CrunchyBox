using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyBroth
{
    static public class MethodInfoExtensions_Override
    {
        static public void OverrideMethod(this MethodInfo item, MethodInfo new_method)
        {
            if(new_method.CanReturnInto(item.ReturnType))
            {
                if(new_method.CanTechnicalParametersHold(item.GetTechnicalParameterTypes()))
                {
                    IntPtr item_address = item.GetFunctionPointerEX();
                    IntPtr new_method_address = new_method.GetFunctionPointerEX();

                    int offset = (int)((long)new_method_address - (long)item_address) - 4 - 1;

                    byte[] jump_instruction = new byte[] {
                        0xE9,
                        offset.GetNthByte(0),
                        offset.GetNthByte(1),
                        offset.GetNthByte(2),
                        offset.GetNthByte(3)
                    };

                    Marshal.Copy(jump_instruction, 0, item_address, jump_instruction.Length);
                }
            }
        }
        static public void OverrideMethod(this MethodInfo item, Delegate new_method)
        {
            item.OverrideMethod(new_method.Method);
        }
    }
}