using System.Security.Cryptography.X509Certificates;

namespace GAME230_TextAdventure;

public static class Map
{
    public static Location StartLocation;
    
    public static void Initialize()
    {
        Location entranceHall = new Location("Central Room", "A grand hall. Doors lead to the West and East. A grand staircase leads North");
        Location library = new Location("Library", "Books and more books. The door you came in is to the East");
        Location treasureRoom = new Location("Treasure Room", "TREASURE!?!?!? The exit is to the South, but a shiny treasure chest lies directly North");
        Location storageRoom = new Location("Storage Room", "There is stuff being stored here. The door you came in is to the West");
        Location frontYard = new Location("Front Yard", "To the north of you are the doors of a great castle");
        Location treasureHole = new Location("Treasure Hole",
            "You reach for the shiny chest, but a trapdoor opens underneath your feet and you fall into a deep hole. There is no way out.");
        
        entranceHall.AddConnection("North", treasureRoom);
        entranceHall.AddConnection("South", frontYard);
        entranceHall.AddConnection("West", library);
        entranceHall.AddConnection("East", storageRoom);
        
        library.AddConnection("East", entranceHall);
        
        storageRoom.AddConnection("West", entranceHall);
        
        frontYard.AddConnection("North", entranceHall);
        
        treasureRoom.AddConnection("South", entranceHall);
        treasureRoom.AddConnection("North", treasureHole);
        
        StartLocation = frontYard;

        
        
        Item key = new Item("Key", "Maybe I can unlock something with this...", "There is a key here.");
        entranceHall.AddItem(key);
        Vocabulary.AddNoun(key.name);
        
        Item beer = new Item("Beer", "Alcoholism.", "There is a beer here.");
        entranceHall.AddItem(beer);
        Vocabulary.AddNoun(beer.name);
    }
}