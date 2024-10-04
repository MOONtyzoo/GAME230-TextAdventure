namespace GAME230_TextAdventure;

public static class CommandHandler
{
    private static Dictionary<string, Action<Command>> _commandMap = new Dictionary<string, Action<Command>>()
    {
        {"toggle-debugger", ToggleDebugger},
        {"go", Move},
        {"take", Take},
        {"inventory", Inventory}
    };
    public static void HandleCommand(Command command)
    {
        if (_commandMap.ContainsKey(command.verb))
        {
            Action<Command> commandAction = _commandMap[command.verb];
            commandAction.Invoke(command);
        }
        else
        {
            Debugger.Write("This command is not supported yet! Add the code in CommandHandler!", true);
        }
                
        Debugger.Write("Print:\t"  + command.ToString());
    }

    private static void ToggleDebugger(Command command)
    {
        Debugger.Toggle();
    }

    private static void Move(Command command)
    {
        Player.Move(command);
    }

    private static void Take(Command command)
    {
        Player.Take(command);
    }

    private static void Inventory(Command command)
    {
        Player.DisplayInventory(command);
    }
}