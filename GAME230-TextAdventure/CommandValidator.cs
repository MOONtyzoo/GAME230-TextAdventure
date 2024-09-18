namespace GAME230_TextAdventure;

public static class CommandValidator
{
    public static Command ValidateCommand(Command command)
    {
        if (Vocabulary.IsVerb(command.verb))
        {
            if (Vocabulary.IsStandaloneVerb(command.verb))
            {
                command.isValid = true;
            }
            else if (Vocabulary.isNoun(command.noun))
            {
                command.isValid = true;
            }
        }
        
        return command;
    }
}