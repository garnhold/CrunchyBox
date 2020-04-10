using System;
using System.IO;

using Crunchy.Dough;
using Crunchy.Noodle;
using Crunchy.Lunch;
using Crunchy.Recipe;

class MainClass
{
    public static void Main(string[] args)
    {
        CmdProgram.Run<GamepadGenerator>(args);
    }
}

public class GamepadGenerator : CmdProgram
{
    [ConfigurationVariable_Interpret("input_filename", "The filename of the tyon file", "gamepad.tyon", "i")]
    private string input_filename;

    [ConfigurationVariable_Interpret("output_filename", "The filename of the cs file", "GeneratedGamepad.cs", "o")]
    private string output_filename;

    protected override void RunInternal()
    {
        GamepadDefinition definition = TyonSettings_General.INSTANCE.Deserialize<GamepadDefinition>(
            File.ReadAllText(input_filename),
            TyonHydrationMode.Strict
        );

        definition.GenerateCode(output_filename);
    }
}
