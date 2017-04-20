using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace TextAdventure
{
    class Game
    {
        Location currentLocation;
        Item playerInv;
        NewLevels customLocation;

        public bool isRunning = true;
        bool customAdventure = false;

        String path;
        List<NewLevels> overview = new List<NewLevels>();

        private List<Item> inventory;
        private List<NewItems> customInventory;

        Location level4;
        Location level5;
        Location level6;
        Location level7;
        Location level8;
        Location level11;

        public Game()
        {
            //Initialises players inventory list and items

            inventory = new List<Item>();
            playerInv = new Item();
            customInventory = new List<NewItems>();

          
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nWelcome, prepare yourself for a journey.\n");

            Console.WriteLine("\n\nWould you like to load your custom map?\n");

            string Custom = Console.ReadLine();

            if (Custom == "yes" || Custom == "y")
            {

                Console.WriteLine("very well");
                try
                {
                    customAdventure = true;
                    path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
                    Console.WriteLine(path);
                    string[] dirs = Directory.GetFiles(path, "NewLevels.xml");
                    Console.WriteLine(dirs.Length + " file found");
                    XmlSerializer reader = new XmlSerializer(typeof(List<NewLevels>));

                    StreamReader file = new StreamReader(dirs[0]);

                    overview = (List<NewLevels>)reader.Deserialize(file);

                    for (int p = 0; p < overview.Count; p++)
                    {
                        NewLevels currentLevel = overview[p];
                        if (currentLevel.LevelNo == 1)
                        {
                            customLocation = currentLevel;
                        }
                    }
                    customAdventure = true;
                    Console.WriteLine("File Loaded\n");
                    file.Close();
                }
                catch
                {
                    Console.WriteLine("could not load. Starting standard adventure");
                    customAdventure = false;
                    Custom = "no";
                }
            }
            // builds the locations and adds all the items, and adds the desctiption to the item

            Location level1 = new Location("Cave entrance", "You stand at the entrance of a cave. The cave is dark.\ntheir is a flashing light in the distance.");
            Item brick = new Item();
            brick.name = "brick";
            brick.description = "This brick looks like it could be used to break something.";
            level1.addItem(brick);

            Location level2 = new Location("End of cave", "You have reached the end of the cave in fornt of you is a small candle. You can\nsee a ladder leading up.");         

            Location level3 = new Location("small shed", "This is a cluttered shed, could be something here.");
            Item crowbar = new Item();
            crowbar.name = "crowbar";
            crowbar.description = "A crowbar. It could break a lock.";
            level3.addItem(crowbar);

            level4 = new Location("Top of ladder", "You reach the top of the ladder. There is a\nwindow that leads outside, it could be smashed.");

            level5 = new Location("The Forest", "You are outside in the forest. There is something moving ahead.");
            Item stick = new Item();
            stick.name = "stick";
            stick.description = "You could craft this with something.";
            level5.addItem(stick);
            Item flint = new Item();
            flint.name = "flint";
            flint.description = "You could craft something with this.";
            level5.addItem(flint);

            level6 = new Location("Wolf den", "You walk deeper into the forest until a wolf attacks from behind.");

            level7 = new Location("Small shack", "You find a locked shack with wolf fur on the bottom, it could be in there!");

            level8 = new Location("Inside shack", "There is blood all over the shack. There is a door at the back.");


            Location level10 = new Location("Second shack room", "You see the wolf infront of you. There\nis blood all over the room and the wolf is badly hurt.");

            level11 = new Location("Trap door death", "You climb down the rope. You can't see anything down here.");


            //Add exits for lcoations

            level1.addExit(new Exit(Exit.Directions.North, level2));
            level1.addExit(new Exit(Exit.Directions.East, level3));

            level2.addExit(new Exit(Exit.Directions.South, level1));
            level2.addExit(new Exit(Exit.Directions.Up, level4));

            level3.addExit(new Exit(Exit.Directions.West, level1));

            level4.addExit(new Exit(Exit.Directions.Down, level2));

            level5.addExit(new Exit(Exit.Directions.North, level6));

            level7.addExit(new Exit(Exit.Directions.South, level6));            
            level8.addExit(new Exit(Exit.Directions.North, level10));            
            level10.addExit(new Exit(Exit.Directions.South, level8));


            currentLocation = level1;
            showLocation();      
        }

        public class NewLevels
        {
            private int levelNo;
            private string roomTitle;
            private string roomDescription;
            private List<NewExits> exitsToAdd;
            public List<NewItems> inventory;

            public NewLevels()
            {

            }
            public string RoomTitle
            {
                get
                {
                    return roomTitle;
                }
                set
                {
                    roomTitle = value;
                }
            }
            public string RoomDescription
            {
                get
                {
                    return roomDescription;
                }
                set
                {
                    roomDescription = value;
                }
            }
            public int LevelNo
            {
                get
                {
                    return levelNo;
                }
                set
                {
                    levelNo = value;
                }
            }
            public List<NewExits> ExitsToAdd
            {
                get
                {
                    return exitsToAdd;
                }
                set
                {
                    exitsToAdd = value;
                }
            }
            public List<NewItems> NewItems
            {
                get
                {
                    return inventory;
                }
                set
                {
                    inventory = value;
                }
            }
        }
        public class NewItems
        {
            private string itemName;
            private string itemDescription;

            public NewItems()
            {

            }
            public string ItemName
            {
                get
                {
                    return itemName;
                }
                set
                {
                    itemName = value;
                }
            }
            public string ItemDescription
            {
                get
                {
                    return itemDescription;
                }
                set
                {
                    itemDescription = value;
                }
            }
        }
        public enum Directions
        {
            North, South, East, West
        };
        public class NewExits
        {
            public static string[] shortDirections = { "N", "S", "E", "W" };
            private int leadsTo = 0;
            private Directions direction;

            public NewExits()
            {

            }
            public int LeadsTo
            {
                get
                {
                    return leadsTo;
                }
                set
                {
                    leadsTo = value;
                }
            }
            public Directions Direction
            {
                get
                {
                    return direction;
                }
                set
                {
                    direction = value;
                }
            }
        }

        public void showInstructions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("For all commands type 'help'!");
        }

        public void showLocation()
        {                  
            if (customAdventure == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + currentLocation.getTitle() + "\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(currentLocation.getDescription());

                if (currentLocation.getInventory().Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nThe room contains the following:\n");

                    for (int i = 0; i < currentLocation.getInventory().Count; i++)
                    {
                        Console.WriteLine(currentLocation.getInventory()[i].name);
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAvailable Exits: \n");
            //Write all available exits

            foreach (Exit exit in currentLocation.getExits())
            {
                Console.WriteLine(exit.getDirection());
            }

            Console.WriteLine();

            if (customAdventure == true)
            {
                Console.WriteLine(customLocation.RoomTitle + "\n");
                Console.WriteLine(customLocation.RoomDescription + "\n\n");

                Console.WriteLine("items in this area include\n\n");
                foreach (NewItems NewItems in customLocation.inventory)
                {
                    Console.WriteLine(NewItems.ItemName);
                }
                Console.WriteLine("\n\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void doAction(string command)
        {
            //Splits command into single word strings

            String[] input = command.Split(default(String[]), StringSplitOptions.RemoveEmptyEntries);

            //Checks every possible exit against where the player wants to move to (If either typed full direction or just a shortcut). If the player can move that way then set the new location.

            foreach (Exit exit in currentLocation.getExits())
            {
                if (input.Length > 0)
                {
                    if (input[0] == exit.ToString().ToLower() || input[0] == exit.ToString().ToLower().Remove(1, exit.ToString().Length - 1))
                    {
                        currentLocation = exit.getLeadsTo();
                        Console.Clear();
                        showLocation();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou moved " + exit + "\n");

                        return;
                    }
                }
            }

            //Gives the player options of input when looking at inventory

            if (input.Length > 0)
            {
                if (input[0] == "inventory" || input[0] == "inv" || input[0] == "i")
                {
                    showInventory();
                    return;
                }
            }

            #region Take 
            if (input.Length > 1)
            {
                if (input[0] == "take" || input[0] == "t")
                {
                    if (customAdventure == false)
                    {
                        for (int i = 0; i < currentLocation.getInventory().Count; i++)
                        {
                            if (currentLocation.getInventory()[i].name == input[1])
                            {
                                Item result = currentLocation.takeItem(input[1]);
                                playerInv.AddItems(result);
                                Console.Clear();
                                showLocation();
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (result != null)
                                    Console.WriteLine("\nYou have picked up a " + input[1] + "!\n");
                                else
                                    Console.WriteLine("Invalid item!");
                                return;
                            }
                        }
                    }
                    if (customAdventure == true)
                    {
                        Console.WriteLine("\n\n>A quick look in your bag reveals the following:\n");

                        for (int i = 0; i < customLocation.inventory.Count; i++)
                        {
                            if (command.Contains(customLocation.inventory[i].ItemName))
                            {
                                NewItems addItem = customLocation.inventory[i];
                                Console.WriteLine("\n>You take the " + addItem.ItemName + " and place it in your bag ");
                                customInventory.Add(addItem);
                                customLocation.inventory.Remove(addItem);
                                break;
                            }
                        }
                    }
                }
                Console.Clear();
                showLocation();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can't do that!");
                return;
            }
         
            #endregion

            #region Examine 
            //Allows players to examine an item thats in their inventory and writes the description written above 

            if (input.Length > 1)
            {
                if (input[0] == "examine" || input[0] == "e")
                {
                    if (customAdventure == false)
                    {

                        string desc = playerInv.GetDescription(input[1]);
                    Console.Clear();
                    showLocation();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n" + desc + "\n");
                    return;
                }
            }

                if (customAdventure == true)
                {
                    foreach (NewItems NewItems in customLocation.inventory)
                    {
                        if (command.Contains(" " + NewItems.ItemName))
                        {
                            Console.WriteLine("\n>" + NewItems.ItemName + "\n");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region craft
            //Craft command, most input 2 items that can carft together

            if (input.Length > 2)
            {
                if (input[0] == "craft")
                {
                    Item item1 = null;
                    Item item2 = null;

                    //Checks all items in player inv against the 2 items mentioned in use command. If they match then set the item to mentioned item

                    foreach (Item item in playerInv.getPlayerInventory())
                    {
                        if (input[1] == item.name)
                        {
                            item1 = item;
                        }

                        if (input[2] == item.name)
                        {
                            item2 = item;
                        }
                    }

                    if (item1 != null && item2 != null)
                    {
                        //Checks to make sure players are crafting the correct item, says can craft if wrong

                        if (item1.name == "flint" && item2.name == "stick" || item1.name == "stick" && item2.name == "flint")
                        {
                            playerInv.RemoveItems(item1);
                            playerInv.RemoveItems(item2);

                            Item spear = new Item();
                            spear.name = "spear";
                            spear.description = "This could be used to kill something.";

                            playerInv.AddItems(spear);

                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYou combine the flint and stick and make a spear!\n");
                            return;
                        }
                        else
                        {
                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nothing happens");
                            return;
                        }

                        Console.Clear();
                        showLocation();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't craft those items!");
                        return;
                    }
                }
            }
            #endregion

            #region Use
            if (input.Length > 1)
            {
                if (input[0] == "use")
                {
                    Item item1 = null;
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Use, checks if an iteam can be used in a certain location, and removes it from inventory after use also adds new exits

                    foreach (Item item in playerInv.getPlayerInventory())
                    {
                        if (input[1] == item.name)
                        {
                            item1 = item;
                            break;
                        }
                    }
                    if (item1 != null)
                    {
                        if (item1.name == "brick" && currentLocation.ToString() == "Top of ladder")
                        {

                            level6.addExit(new Exit(Exit.Directions.South, level5));
                            level4.addExit(new Exit(Exit.Directions.West, level5));
                            playerInv.RemoveItems(item1);

                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You smash the window with the brick.");

                            return;
                        }
                        else if (item1.name == "crowbar" && currentLocation.ToString() == "Small shack")
                        {

                            level7.addExit(new Exit(Exit.Directions.East, level8));

                            playerInv.RemoveItems(item1);

                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You try to brake the lock.");
                            Console.WriteLine("The crowbar brakes the lock, the door is now open.");
                            return;
                        }
                                               
                    }
                    Console.Clear();
                    showLocation();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can't do that!");

                    return;

                }
            }
            #endregion

            #region attack
            //checks if player is in the correct location to attack, make sure the player has the correct items in inventory. Also doesn't remove weapon from inventory

            if (input.Length > 0)
            {
                if (input[0] == "attack" || input[0] == "a")
                {

                    Console.Clear();
                    showLocation();
                    Console.ForegroundColor = ConsoleColor.Red;

                    foreach (Item item in playerInv.getPlayerInventory())
                    {
                        if (currentLocation.ToString() == "Wolf den")
                        {
                            if (item.name == "spear")
                            {
                                level6.addExit(new Exit(Exit.Directions.North, level7));
                                Console.Clear();
                                showLocation();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You attack the wolf with the spear. It's wounded but manages to escape");
                                level6.setDescription("You walk deeper into the forest. There is a blood trail left from the wolf.");
                                return;
                            }
                        }
                        else if (currentLocation.ToString() == "Second shack room")
                        {
                            if (item.name == "spear")
                            {
                                Console.Clear();
                                showLocation();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You attack the wolf again killing it!!");
                                Console.WriteLine("\nCongratulations you killed the wolf and completed the game!");
                                Console.WriteLine("Push any key to end the game.....");
                                Console.ReadLine();
                                isRunning = false;
                                return;
                            }
                        }
                    }

                    if (currentLocation.ToString() == "Second shack room" || currentLocation.ToString() == "Wolf den")
                    {
                        Console.Clear();
                        showLocation();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have nothing to attack with!");
                        return;
                    }

                    Console.WriteLine("There is nothing to attack here!");
                    return;

                }
            }
            #endregion

            #region help
            //Show possible command you can use

            if (input.Length > 0)
            {
                if (input[0] == "help" || input [0] == "h")
                {
                    Console.Clear();
                    Console.WriteLine(@"HELP!
_________

Attack: a or attack
Take: t ""itemName"" or take ""itemName""
Examine: e ""itemName"" or examine ""itemName""
Help: h or help
Move: North,East, South, West or n, e, s, w
Inventory: i, inv or Inventory
Quit: q or Quit 
Use: Use ""itemName""
Craft: Craft ""itemName"" ""itemName""


Push any key to return!");
                    Console.ReadLine();
                    Console.Clear();
                    showLocation();
                    return;
                }
            }
            #endregion

            Console.Clear();
            showLocation();
            Console.WriteLine("\nInvalid command, are you confused?\n");

            Console.ForegroundColor = ConsoleColor.White;

        }

        private void showInventory()
        {

            Console.Clear();
            showLocation();

            Console.ForegroundColor = ConsoleColor.Magenta;
            //shows the items in the players inventory, says its empty if you have nothing
            if (customAdventure == false)
            {          
                if (playerInv.getPlayerInventory().Count > 0)
            {
                Console.WriteLine("\nA quick look in your bag reveals the following:\n");

                foreach (Item item in playerInv.getPlayerInventory())
                {
                    Console.WriteLine(item.name);
                }
            }
            else
            {
                Console.WriteLine("Your bag is empty.");
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

                if (customAdventure == true)
                {
                    if (customInventory.Count > 0)
                    {
                        Console.WriteLine("\n\n>A quick look in your bag reveals the following:\n");

                        foreach (NewItems newItems in customInventory)
                        {
                            Console.WriteLine(newItems.ItemName);
                        }
                    }
                    else
                    {
                        Console.WriteLine(">Your bag is empty.");
                    }
                }
                Console.WriteLine("");
            }
        }

        public void Update()
        {
            string currentCommand = Console.ReadLine().ToLower();

            // instantly check for a quit

            if (currentCommand == "quit" || currentCommand == "q")
            {
                isRunning = false;
                return;
            }

            // otherwise, process commands.

            if (currentCommand != "")
                doAction(currentCommand);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}