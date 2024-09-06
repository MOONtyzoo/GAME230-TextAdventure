namespace GAME230_TextAdventure;

public static class Game
{
    private static bool _isGameOver = false;
    public static void Play()
    {
        Console.WriteLine("Playing the game");

        while (_isGameOver == false)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (input == "exit")
            {
                _isGameOver = true;
            }
        }
    }
}