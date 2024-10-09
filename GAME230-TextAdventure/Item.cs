namespace GAME230_TextAdventure;

public class Item
{
    public string name;
    public string description;
    public string locationDescription;
    public bool isTakeable;
    public bool isDroppable;

    public Item(string _name, string _description, string _locationDescription, bool _isTakeable, bool _isDroppable)
    {
        name = _name;
        description = _description;
        locationDescription = _locationDescription;
        isTakeable = _isTakeable;
        isDroppable = _isDroppable;
    }

    public string ToString()
    {
        return name + ": " + description;
    }
}