namespace GAME230_TextAdventure;

public static class Player
{
    private static Location _currentLocation;
    public static List<Item> inventory = new List<Item>();

    public static void Initialize()
    {
        _currentLocation = Map.StartLocation;
        IO.Write(_currentLocation.GetDescription());
    }
    public static void Move(Command command)
    {
        string direction = command.noun;
        if (_currentLocation.CanMoveInDirection(direction))
        {
            _currentLocation = _currentLocation.GetLocationInDirection(direction);
            IO.Write("Moving " + command.noun + "...");
            IO.Write(_currentLocation.GetDescription());
        }
    }

    public static void Take(Command command)
    {
        string itemName = command.noun;
        if (!_currentLocation.HasItem(itemName))
        {
            IO.Write("There is no such item...");
            return;
        }
        
        Item? item = _currentLocation.TakeItem(itemName);
        if (item == null)
        {
            IO.Write("You can't take this item!");
            return;
        }
        
        inventory.Add(item);
        IO.Write("Taking " + itemName + "...");
    }

    public static void Drop(Command command)
    {
        string itemName = command.noun;

        Item? itemToDrop = inventory.FirstOrDefault(item => item.name.ToLower() == itemName.ToLower());

        if (itemToDrop == null)
        {
            IO.Write("You don't have this item...");
            return;
        }

        if (!itemToDrop.isDroppable)
        {
            IO.Write("You can't drop this item!");
            return;
        }

        inventory.Remove(itemToDrop);
        _currentLocation.AddItem(itemToDrop);
        IO.Write("You dropped the " + itemName);
    }

    public static void DisplayInventory(Command command)
    {
        string inventoryString = "[Inventory]: ";
        foreach (Item item in inventory)
        {
            inventoryString += "\n  - " + item.ToString();
        }

        IO.Write(inventoryString);
    }

    public static void Look(Command command)
    {
        IO.Write("You take a look at your surroundings...");
        IO.Write(_currentLocation.GetDescription());
    }
}