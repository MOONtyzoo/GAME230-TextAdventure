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
            IO.Write(_currentLocation.GetDescription());
            IO.Write("Moving " + command.noun + "...");
        }
    }

    public static void Take(Command command)
    {
        string itemName = command.noun;
        bool doesItemExist = _currentLocation.HasItem(itemName);
        if (!doesItemExist)
        {
            IO.Write("There is no such item...");
            return;
        }

        Item item = _currentLocation.TakeItem(itemName);
        inventory.Add(item);
        IO.Write("Taking " + itemName + "...");
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
}