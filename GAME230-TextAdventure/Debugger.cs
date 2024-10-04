namespace GAME230_TextAdventure;

public static class Debugger
{
    private static bool isEnabled = false;
    private static ConsoleColor debuggerColor = ConsoleColor.DarkCyan;
    private static ConsoleColor warningColor = ConsoleColor.Red;
    
    public static void Write(string message, bool warning = false)
    {
        ConsoleColor outputColor = warning  == true ? warningColor : debuggerColor;
        if (isEnabled)
        {
            IO.Write(message, outputColor);
        }
    }

    public static void TurnOn()
    {
        isEnabled = true;
        IO.Write("// Debugger Enabled //", debuggerColor);
    }

    public static void TurnOff()
    {
        isEnabled = false;
        IO.Write("// Debugger Disabled //", debuggerColor);
    }

    public static void Toggle()
    {
        if (isEnabled)
        {
            TurnOff();
        }
        else
        {
            TurnOn();
        }
    }
}