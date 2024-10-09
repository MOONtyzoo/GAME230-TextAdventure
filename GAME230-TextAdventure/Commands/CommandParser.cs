namespace GAME230_TextAdventure;

public static class CommandParser
{
    private static int _expectedCommandLength = 2;
    public static Command Parse(string input)
    {
        Command parsedCommand = new Command();
        
        input = RemoveWhitespace(input);
        input = input.ToLower();
        string[] words = input.Split(' ');
        
        if (words.Length == 1)
        {
            parsedCommand.verb = words[0];
        }
        if (words.Length == _expectedCommandLength)
        {
            parsedCommand.verb = words[0];
            parsedCommand.noun = words[1];
        }
        
        return parsedCommand;
    }

    private static string RemoveWhitespace(string input)
    {
        input = input.Trim();
        // Replace double spaces with single spaces
        while (input.Contains("  "))
        {
            input = input.Replace("  ", " ");
        }

        return input;
    }
}