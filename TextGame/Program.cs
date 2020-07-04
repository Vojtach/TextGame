using System;

namespace hra
{
    class Program
    {
        static void Main()
        {
            string choice = "null";
            bool repetition = false;
            string[] inventory = { "", "", "", "" }; //Crowbar 0, Knife 1, Steel rod 2, Bedroom key 3

            // Crowbar > Knife > Bedroom key > Steel rod > Attic
            //Game skip = "crowbarskip" while crowbar is in the inventory will skip to the bedroom part by prying open the door

            Console.WriteLine("Welcome to my game! Yeah! It's not your game! \nWhere did Timmy go? No one knows... You find him");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Controls: type [goto room name] to travel to selected room. Type inv for your inventory");
            do
            {
                Console.WriteLine("________________________________________________\nYour path: kitchen, living room, bedroom, attic");
                choice = Console.ReadLine();
                repetition = true;
                switch (choice)
                {
                    case "goto kitchen":

                        if (inventory[0] == "crowbar")
                        {
                            bool pryOpen = false;
                            Console.WriteLine("Pry the stuck drawer open with the crowbar? true/false");
                            bool.TryParse(Console.ReadLine(), out pryOpen);
                            if (pryOpen == true)
                            {
                                Console.WriteLine("Success! There is a single sharp knife in the drawer...");
                                inventory[1] = "knife";
                                Console.WriteLine("KNIFE ADDED TO INVENTORY");

                            }
                            else
                            {
                                Console.WriteLine("Okay then");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You look into the kitchen. While searching for something that could help you find Timmy you notice one drawer is stuck.");
                            Console.WriteLine("You'll need something to pry it open with");
                        }
                        break;
                    case "goto living room":
                        if (inventory[1] == "knife")
                        {
                            bool ropeCut = false;
                            Console.WriteLine("Use the knife to cut the rope to free the key? true/false");
                            bool.TryParse(Console.ReadLine(), out ropeCut);
                            if (ropeCut == true)
                            {
                                Console.WriteLine("Success! The key drops to the ground where you pick it up...");
                                inventory[3] = "key";
                                Console.WriteLine("KEY ADDED TO INVENTORY");

                            }
                            else
                            {
                                Console.WriteLine("Okay then");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You look into the living room. You see a key suspended in air with a rope system and a crowbar");
                            Console.WriteLine("You'll need something to cut the rope with");
                            inventory[0] = "crowbar";
                            Console.WriteLine("CROWBAR ADDED TO INVENTORY");
                        }
                        break;
                    case "goto bedroom":
                        if (inventory[3] == "key")
                        {
                            Console.WriteLine("After unlocking the bedroom you found a long curved steel rod. Might come in handy");
                            inventory[2] = "steel rod";
                            Console.WriteLine("STEEL ROD ADDED TO INVENTORY");
                        }
                        else
                        {
                            Console.WriteLine("The bedroom appears to be locked. I'll need to find a key for that...");
                        }
                        break;
                    case "goto attic":
                        if (inventory[2] == "steel rod")
                        {
                            bool pullDownAttic = false;
                            Console.WriteLine("Use the steel rod to pull down the attic stairs? true/false");
                            bool.TryParse(Console.ReadLine(), out pullDownAttic);
                            if (pullDownAttic == true)
                            {
                                Console.WriteLine("Success! You pull down the attic stairs");
                                Console.WriteLine("You head up the stairs");
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("You hear suspicious shifting in the darkness");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("You look behind some boxes... and...");
                                System.Threading.Thread.Sleep(5000);
                                Console.WriteLine("ITS TIMMY! He says he was lost and thanks you for his rescue.");
                                repetition = false;
                                // THE END
                            }
                            else
                            {
                                Console.WriteLine("Okay then");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You try to go to the attic but you cant reach the handle to pull the stairs down");
                            Console.WriteLine("You'll need something to pull them down with");
                        }
                        break;
                    case "inv":
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine(inventory[i]);
                        }
                        break;
                    case "crowbarskip":
                        if (inventory[0] == "crowbar")
                        {
                            Console.WriteLine("After completly destroying the bedroom door you found a long curved steel rod. Might come in handy");
                            inventory[2] = "steel rod";
                            Console.WriteLine("STEEL ROD ADDED TO INVENTORY");
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown command. Trying again...");
                        repetition = true;
                        break;
                }
            } while (repetition == true);
            Console.WriteLine("THE END");

        }
    }
}