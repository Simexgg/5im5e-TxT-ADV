namespace A
{
    internal class Thirdscene
    {
        public static void thirdscene()
        {
                Console.WriteLine("a growling can be heard.. those rats where clearly running from something *THUMMM* *THUMMM* \n");
                Console.WriteLine("This is the last push you tell yourself");
                Console.WriteLine("there is a ladder bringing to a higher ground.. maybe this could give you and advantage..\n What do you do?\n \t [1] stand ur ground \t [2] rush to the ladder");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("you stand ur ground and prepare to taunt the Hobgoblin with your trustworthy [" + cc.hero.WMAX + "]");
                    Console.WriteLine("The Hobgoblin charge at you");
                    combat.Combat(false, "Hobgoblin", 6, 36, 0, 216);                    
                }
                else if (input == "2")
                {
                    t.w("u start climbing the ladder and it doesnt seems extremly solid..\n What do you do?\n \t [1] keep climbing \t [2] take cover on the wall next to the direction of the Monster");
                    Console.ReadLine();
                    if (input == "1")
                    {
                        if(cc.hero.Weight >= 200)
                        {
                            Console.WriteLine("as you are climbing the ladder snap.. you fall to the ground and the hobgoblin see's it");
                            Console.WriteLine("The Hobgoblin charge at you while you are still on the floor");
                            cc.hero.HP -= (cc.hero.HP / 2);
                            combat.Combat(false, "Hobgoblin", 6, 36, 0,216);
                        }
                        else
                        {
                            Console.WriteLine("as you finish climbing the ladder you can clearly see the hobgoblin but he doesnt see's you\n you are in a advantegous position and the hobgoblin will suffer additionnal damage");
                            Console.WriteLine("The Hobgoblin is at the bottom of your position now is the time to strike!!");
                            Console.WriteLine("You strike!! and suprise him.. it deals 1/3 of his [Vitality] point and u take off 1 of his Power stats.");
                            combat.Combat(false, "Hobgoblin", 5, 24, 0,216);
                        }
                       
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("you are ready to pounce anytime now.. you swing your weapon get him by suprised 1/6 of his [Vitality] point");
                        combat.Combat(false, "Hobgoblin", 6, 30, 0,216);                    
                    }
                }
                combat.Win();
                Console.ReadKey();
                Console.WriteLine("you won a amulet!!! \n what does it do?");            
        }
    }
}
