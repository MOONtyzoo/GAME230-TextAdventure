namespace GAME230_TextAdventure;

public static class CommandProcessor
{
    public static Command ProcessCommand()
    {
        string input = IO.Read();
        Command inputCommand = CommandParser.Parse(input);
        inputCommand = CommandValidator.ValidateCommand(inputCommand);
        return inputCommand;
    }
}