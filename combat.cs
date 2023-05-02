using static t;
namespace A
{
    internal class combat
    {
        static Random rnd = new Random();
        //Scene win utility
        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            w("You are Victorious");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        //Scene Gameover utility
        public static void gameover()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            w("You are dead.. Game Over");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            w("All your progress are lost..");
            Environment.Exit(0);
        }

        //Scene combat utility

        public static void Combat(bool random, string name, int power, int vitality, int coins, int rewardexp)
        {
            string n = "";
            int p = 0;
            int h = 0;
            int c = 0;
            int Exp = p * h;

            if (random)
            {
                //n = GetName();
                p =  rnd.Next(1, 5); //GetP()
                h = rnd.Next(1, 8); //GetH()
                Exp = rewardexp;
                c = coins;
            }
            else
            {
                n = name;
                p = power;
                h = vitality;   
                Exp = rewardexp;
                c = coins;
            }
            do
            {
                while (h > 0)
                {
                    Console.Clear();
                    w("~~~~~~~~~~Ennemy~~~~~~~~~");
                    w("   " + n);
                    w("Power:[" + p + "] / HP:[" + h + "]");
                    w("~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    w("  " + cc.hero);
                    w("=========================");
                    w("| [1] Attack [2] Defend |");
                    w("| [3] Run    [4] Potion |");
                    w("=========================");
                    w("Potions: [" + cc.hero.Potion + "] Vitality: [" + cc.hero.HP + "]");

                    string input = Console.ReadLine();

                    if (input == "1")  //attack action
                    {
                        w("you attack with your weapon");
                        int damage = p - cc.hero.AC;
                        if (damage < 0)
                            damage = 0;
                        int attack = rnd.Next(1, (cc.hero.WMAX) + (cc.hero.StrMod));
                        w("you trade blows with ur opponent and deals him [" + attack + "] damage \n you also lose [" + damage + "] Vitality");
                        Console.ReadKey();
                        cc.hero.HP -= damage;
                        h -= attack;

                    }
                    else if (input == "2") //defense action
                    {
                        w("you take a defensive state");
                        Console.ReadKey();
                        int damage = (p / 2) - cc.hero.AC;
                        if (damage < 0)
                            damage = 0;
                        int attack = rnd.Next(1, ((cc.hero.WMAX) + (cc.hero.Str / 4)) / 2);
                        w("you trade blows with ur opponent and deals him [" + attack + "]damage \n you also lose [" + damage + "] Vitality");
                        Console.ReadKey();
                        cc.hero.HP -= damage;
                        h -= attack;
                    }
                    else if (input == "3") //run action
                    {
                        int damage = p - cc.hero.AC;
                        if (damage < 0)
                            damage = 0;

                        //run
                        if (rnd.Next(cc.hero.Spd, 11) >= 7)
                        {
                            w("you have managed to escape unscathed");
                            Console.ReadKey();
                        }
                        else
                        {
                            w("you are unable to distance your opponent and get hits for [" + damage + "] damage!");
                            Console.ReadKey();
                        }
                    }

                    else if (input == "4")  //potion action
                    {
                        int damage = p - cc.hero.AC;
                        if (damage < 0)
                            damage = 0;

                        if (cc.hero.Potion == 0)
                        {
                            w("Looks like your magic elixir is all used up.");
                            w("your opponent " + n + " see you preoccupied and attack \n he hit your for [" + damage + "] damage");
                            Console.ReadKey();

                        }
                        else
                        {
                            w("you grab your elixir and take a gulp");


                            int potionvalue = +5 + (cc.hero.MHP / 3);

                            if (cc.hero.HP + potionvalue > cc.hero.MHP)
                            {
                                cc.hero.HP = cc.hero.MHP;   //to not overlap hp max with bonus hp.      
                                w("its does you good u feel replenish");
                                Console.ReadKey();
                            }
                            else
                            {
                                cc.hero.HP += potionvalue;
                                w("its does you some good.. u feel replenish! *you gain [" + potionvalue + "]:[Vitality]");
                                w("\n while u drink your potion your ennemy [" + n + "] attacked you");
                                Console.ReadKey();
                                cc.hero.HP -= damage;
                            }
                        }
                        w("\n you gained [" + Exp + "]:[EXP] ",ConsoleColor.Black); //give Exp and Coins when winning
                        cc.hero.Exp += Exp;
                        cc.hero.Coins += Exp;
                        c = coins;
                       wDarkMagenta("you currently have [" + cc.hero.Exp + "]:[Exp]");
                        Win();
                        Console.ReadKey();
                    }
                }


                void Win()
                {
                    w("You terassed the " + n);
                    wYellow("You are Victorious");

                    Console.ReadKey();
                    Console.Clear();
                }

                void gameover()
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    w("The" + n + "finishes you with a mighty blow.. Game Over");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    Environment.Exit(0);
                }


            }
            while (cc.hero.HP > 0);
            {
                gameover();
            }

        }
    }
}



            

            

        
    


