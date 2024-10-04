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
        string fullDescription = "--------------------\n[ " + name +  "]\n--------------------\n" + description + "\n-----\n";
        return fullDescription + GetItems();
    }

    public string GetItems()
    {
        string itemString = "[Items]: ";
        foreach (Item item in items)
        {
            itemString += "\n  - " + item.locationDescription;
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

    public Item TakeItem(string itemName)
    {
        Item itemToTake = new Item("NULL ITEM", "you took an item that doesn't exist", "uh oh");
        foreach (Item item in items)
        {
            if (item.name.ToLower() == itemName.ToLower()) itemToTake = item;
        }
        
        items.Remove(itemToTake);
        return itemToTake;
    }
}