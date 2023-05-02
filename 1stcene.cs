using static t;
namespace A
{
    internal class Startscene
    {
        public static void startscene()
        {
            wBlue("Your new found friend looks at you seriously and he's say's.. to lay down and sleep, because tommorow will be the start of your journey\n\n");

            wCyan("Morning comes. and you start traveling with the old man..\n after a couple of days of traveling you arrive to the location.\n");
            wCyan("Theres is a door leading down the catacomb what do you do\n [1] open it \t [2] turn back\n");

            string input = Console.ReadLine();

            if (input == "1")
            {
                wDarkMagenta("You open the door and start going into the dungeon. It gets darker every step you take down towards the first floor.\n");
            }
            else if (input == "2")
            {
                wCyan("The old man insists you find the courage to go down the path as the world depends on it. What do you do?\n \t [1] Open it and prevail \t [2] Insist on turning back");
                Console.ReadLine();
                if (input == "1")
                {
                    wDarkMagenta("You open the door and unwillingly go down into the dungeon, shaking in fear as it gets darker every step towards the first floor\n");
                }
                else if (input == "2")
                {
                    wCyan("The old man firmly insists you find the courage. What do you do?\n \t [1] Open it \t [2] Turn back");
                   
                    string input1 = Console.ReadLine();
                    if (input1 == "1") 
                    {
                        wDarkMagenta("You open the door and take a step in, but the old man shoves you down the stairs with a herculean force and slams the door shut. \n you try and force it open.. \n After a while, you realize the door won't budge. Unwillingly, you start going down into the dungeon, shaking in fear and sobbing every step you take in the dark.\n");
                        Console.ReadKey();
                    }
                    else if (input1 == "2")
                    {
                        wRed("The old man's rage boil as he looks at you, and in a flash, you are now face to face with him.\n \t You feel numb and realize that you don't feel your lower part anymore.\n \t As you look down your body, his arms go through your stomach. \n \t \t You cough up blood before fainting.");
                        Console.ReadKey();
                        combat.gameover();
                    }
                    Console.WriteLine();
                }
            }                       
            Console.WriteLine("You open the next door but someone was waiting behind it");
            Console.ReadKey();
            combat.Combat(false, "Human rogue", 2, 6, 7, 12);
        }
       
    }
}
