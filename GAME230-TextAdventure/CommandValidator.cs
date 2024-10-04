namespace GAME230_TextAdventure;

public static class CommandValidator
{
    public static Command ValidateCommand(Command command)
    {
        if (Vocabulary.IsVerb(command.verb))
        {
            if (Vocabulary.IsStandaloneVerb(command.verb))
            {
                if (command.HasNoNoun())
                {
                    command.isValid = true;
                }
                else
                {
                    IO.Write("I don't know how to do that.");
                }
            }
            else if (Vocabulary.IsNoun(command.noun))
            {
                command.isValid = true;
            }
            else
            {
                IO.Write("I don't know the word '" + command.noun + "'.");
            }
        }
        else
        {
            IO.Write("I don't know the word '" + command.verb + "'.");
        }
        
        return command;
    }
}