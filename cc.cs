using static A.cc;
using static t;
namespace A
{
   
    internal class cc
    {

        public static Hero hero = new Hero();
        public class Weapon
        {
            public int WMIN { get; set; }
            public int WMAX { get; set; }
            public string WeaponName { get; set; }

            public Weapon(int wmin, int wmax, string name)
            {
                WMIN = wmin;
                WMAX = wmax;
                WeaponName = name;
            }
        }
        public class Hero

        //   hero class with a name and some attribute 
        {
            internal string Name = hero.Name;
            internal string title = " the Hero";

            //general stats
            internal int MHP = 12;
            internal int HP = 12;
            internal int AC = 10;

            internal int Reg = 1;
            internal int Spd = 1;

            internal int Weight = 130;

            //possesion 
            internal int Exp = 0;
            internal int Coins = 0;
            internal int WMIN = 1;
            internal int WMAX = 4;
            internal string WeaponN = "fist";
            internal int Potion = 3;

            //stats
            internal int Str = 1; internal int StrMod = 1;
            internal int Dex = 1; internal int DexMod = 1;
            internal int Con = 1; internal int ConMod = 1;
            internal int Int = 1; internal int IntMod = 1;
            internal int Cha = 1; internal int ChaMod = 1;
            internal int Wis = 1; internal int WisMod = 1;

            internal class Rogue : Hero
            {
                //   rogue class with starting attribute and title
                public Rogue()
                {
                    title = cc.hero.title + " the Bandit";
                    MHP = 8;
                    HP = 8;
                    AC = 1;
                    Exp = 0;
                    Reg = 2;
                    Spd = 3;
                    Str = 2;
                    Dex = 3;
                    Int = 1;

                    WMIN = 1;
                    WMAX = 6;
                    WeaponN = "Dagger";
                    Weight = 165;
                    Coins = 0;
                }
            }
            internal class Warrior : Hero
            {
                //   Warrior class with starting attribute and title
                public Warrior()
                {
                    title = hero + " the Warrior";
                    MHP = 12;
                    HP = 12;
                    AC = 2;
                    Exp = 0;
                    Reg = 3;
                    Spd = 2;

                    Str = 5;
                    Dex = 1;
                    Con = 1;
                    Int = 1;
                    Cha = 1;
                    Wis = 1;

                    WMIN = 1;
                    WMAX = 8;
                    WeaponN = "Longsword";
                    Weight = 225;
                    Coins = 0;
                }
            }
            internal class Wizard : Hero
            {
                //  Wizard class with starting attribute and title
                public Wizard()
                {
                    title = hero.title + " the Mage";
                    MHP = 6;
                    HP = 6;
                    AC = 0;
                    Exp = 0;
                    Reg = 1;
                    Spd = 1;

                    Str = 1;
                    Dex = 1;
                    Con = 1;
                    Int = 1;
                    Cha = 1;
                    Wis = 1;

                    WMIN = 1;
                    WMAX = 8;
                    WeaponN = "Quarterstaff";
                    Weight = 145;
                    Coins = 0;
                }
            }

            public class Weapon
            {
                public int WMIN { get; set; }
                public int WMAX { get; set; }
                public string WeaponName { get; set; }

                public Weapon(int wmin, int wmax, string name)
                {
                    WMIN = wmin;
                    WMAX = wmax;
                    WeaponName = name;
                }
            }
            public static void Start()
            {
                wCyan("Welcome adventurer! \nMay one has a name\n*Choose your name, hero!*");
                hero.Name = Console.ReadLine();                
                wCyan("Welcome to the adventure " + hero.Name);

                Console.WriteLine("\nChoose your class adventurer! \n[1] if you are a Warrior! \n[2] if you are a Rogue!\n[3] if you are a a Wizard!\n[4] if you are a true hero (Hard)");
                
                string input = Console.ReadLine();

                if (input == "1")
                {
                    cc.hero = new cc.Hero.Warrior();
                    Console.Clear();
                    Console.WriteLine(hero.Name + " is your title");
                    cc.Hero.Stats();
                }
                else if (input == "2")
                {
                    cc.hero = new cc.Hero.Rogue();
                    Console.Clear();
                    Console.WriteLine(cc.hero.Name + " is your current title\n\n");
                    cc.Hero.Stats();
                }
                else if (input == "3")
                {
                    cc.hero = new cc.Hero.Wizard();
                    Console.Clear();
                    Console.WriteLine(cc.hero.title + " is your title");
                    cc.Hero.Stats();
                    Console.ReadKey();
                }
                else if (input == "4")
                {
                    cc.hero = new cc.Hero();
                    Console.Clear();
                    cc.Hero.Stats();
                }
            }

            public static void Stats()
            {
                Console.Write("[" + hero.HP + "]  [Vitality]\t");
                Console.Write("[" + hero.AC + "]  [Defense]\t");
                Console.WriteLine("[" + hero.Reg + "]  [Regeneration]");
                Console.Write("[" + hero.Spd + "]  [Speed]\t");


                Console.Write("[" + hero.Str + "]  [Strenght]\t");
                Console.Write("[" + hero.Dex + "]  [Intelligence]\n");
                Console.WriteLine("[" + hero.Con + "]  [Dexterity]\t");
                Console.Write("[" + hero.Dex + "]  [Dexterity]\t");


                Console.WriteLine("you posess x [" + hero.Potion + "] Vitality potions");

                Console.WriteLine("you carry a [" + hero.WeaponN + "] and is currently equipped and its can deals up to as much as [1d" + hero.WMAX + "]");

                Console.WriteLine("you weight approximately " + hero.Weight + " Lbs with your current equipement");

                Console.WriteLine("you have currently [" + hero.Exp + "]:[EXP]\n");

                Console.WriteLine("press space to continue");
                Console.ReadKey();
                Console.Clear();

            }


        }
    }
}
    
