using System.Drawing;

namespace GAME230_TextAdventure;

public static class Game
{
    private static bool _isGameOver = false;

    private static void InitializeGame()
    {
        Map.Initialize();
        Player.Initialize();
    }
    
    public static void Play()
    {
        InitializeGame();
        Debugger.TurnOn();

        while (_isGameOver == false)
        {
            Command command = CommandProcessor.ProcessCommand();
            if (command.isValid)
            {
                CommandHandler.HandleCommand(command);
            }
        }
    }
}