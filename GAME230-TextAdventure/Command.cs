namespace GAME230_TextAdventure;

public class Command
{
    public string noun;
    public string verb;
    public bool isValid = false;

    public string ToString()
    {
        return "[Command] " + "\n\tNoun: " + noun + "\n\tVerb: " + verb;
    }
}