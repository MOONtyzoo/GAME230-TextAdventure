namespace GAME230_TextAdventure;

public static class IO
{
    public const ConsoleColor defaultColor = ConsoleColor.Gray;
    public const ConsoleColor promptColor = ConsoleColor.White;
    public static void Write(string output, ConsoleColor color = defaultColor)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(output);
    }
    
    public static string Read()
    {
        Console.ForegroundColor = promptColor;
        Console.Write("> ");
        return Console.ReadLine();
    }
}