using static t;
namespace A
{

    internal class SF  //look guide part 3 ( make shop )
    {
        public static void safefloor()
        {
            w("\n");
            w("Without a second to breath out u hear schreaching noise coming your way..\n");
            w("The path u most follow is behind the noise that is getting closer \n \t [1] stand ur ground \t [2] try to hide \n");
            string input = Console.ReadLine();


            if (input == "1")
            {
                w("you stand ur ground and get used to the darkness slowly.. you calm your breath and brace for the combat\n");
                combat.Combat(false, "swarm of rat", 3, 24, 72, 72);
            }
            else if (input == "2")
            {
                w("there is litteraly nothing to hide with but you look at the corpse and think you could lure away whatever is comming your way.\n What do you do?\n \t [1] Place the corpse \t [2] Prepare for battle\n");
                Console.ReadLine();
                if (input == "1")
                {
                    w("you use the body by placing it in the middle of the path and you hug tight with the wall while the numerous creatures are closing by.. you skip throught the side of a big rat swarm comming for the body and devouring it\n");
                    combat.Win();
                }
                else if (input == "2")
                {
                    w("you grasp your weapon firmly and get in position\n");
                    combat.Combat(false, "swarm of rat", 3, 24, 72, 72);
                    w("\n");
                }
            }
            w("Bloodymess.. so many dead rats.. your cloth are defiled and bloody");
            Console.Clear();
            Console.ReadKey();
        }
    }
}    

