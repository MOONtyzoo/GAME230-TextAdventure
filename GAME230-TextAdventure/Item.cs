namespace GAME230_TextAdventure;

public class Item
{
    public string name;
    public string description;
    public string locationDescription;
    public bool isEdible;

    public Item(string _name, string _description, string _locationDescription)
    {
        name = _name;
        description = _description;
        locationDescription = _locationDescription;
    }

    public string ToString()
    {
        return name + ": " + description;
    }
}