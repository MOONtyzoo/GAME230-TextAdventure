namespace GAME230_TextAdventure;

public class Command
{
    public string noun = String.Empty;
    public string verb = String.Empty;
    public bool isValid = false;

    public string ToString()
    {
        return "[Command] " + "\n\tNoun: " + noun + "\n\tVerb: " + verb;
    }

    public bool HasNoNoun()
    {
        return (noun == String.Empty);
    }
}