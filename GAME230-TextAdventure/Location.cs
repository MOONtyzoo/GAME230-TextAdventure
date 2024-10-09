namespace GAME230_TextAdventure;

public class Location
{
    public string name;
    public string description;

    private Dictionary<string, Location> connections;
    private List<Item> items;

    public Location(string _name, string _description)
    {
        name = _name;
        description = _description;
        
        connections = new Dictionary<string, Location>();
        items = new List<Item>();
    }

    public void AddConnection(string direction, Location connection)
    {
        connections[direction.ToLower()] = connection;
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public Location GetLocationInDirection(string direction)
    {
        return connections[direction.ToLower()];
    }

    public bool CanMoveInDirection(string direction)
    {
        return connections.ContainsKey(direction);
    }

    public string GetDescription()
    {
        string fullDescription = "--------------------\n[ " + name +  " ]\n--------------------\n";
        fullDescription += description + GetItemDescription();
        return fullDescription;
    }

    public string GetItemDescription()
    {
        string itemString = "";
        foreach (Item item in items)
        {
            itemString += " " + item.locationDescription;
        }

        return itemString;
    }

    public bool HasItem(string itemName)
    {
        foreach (Item item in items)
        {
            if (item.name.ToLower() == itemName.ToLower()) return true;
        }

        return false;
    }

    public Item? TakeItem(string itemName)
    {
        Item? itemToTake = items.FirstOrDefault(item => item.name.ToLower() == itemName.ToLower());
        if (itemToTake == null) return null;
        
        if (itemToTake.isTakeable)
        {
            items.Remove(itemToTake);
            return itemToTake;
        }

        return null;
    }
}