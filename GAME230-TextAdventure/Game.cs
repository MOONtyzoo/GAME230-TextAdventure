using System.Drawing;

namespace GAME230_TextAdventure;

public static class Game
{
    private static bool _isGameOver = false;
    public static void Play()
    {
        Console.WriteLine("Playing the game");

        while (_isGameOver == false)
        {
            Command command = CommandProcessor.ProcessCommand();
            if (command.isValid)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                IO.Write("-- Print: "  + command.ToString());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                IO.Write("!- Invalid command");
            }
        }
    }
}