using System;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            string Gröt = "Gröt";
            int Lifeplayer = 100;
            int Lifegröt = 100;

            int Rageplayer = 0;
            int Ragegröt = 0;

            int playerdamage;
            int grötdamage;

            Random generator = new Random();

            Console.WriteLine("November projekt");
            Console.WriteLine("Klicka enter för att starta");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Skriv in ditt namn");
            string Player = Console.ReadLine();
            Console.Clear();

            while (Lifeplayer > 0 && Lifegröt > 0)
            {
                Console.WriteLine(Gröt + " " + Lifegröt + "HP & " + Ragegröt + " Rage");
                Console.WriteLine(Player + " " + Lifeplayer + "HP & " + Rageplayer + " Rage");
                Console.WriteLine("Klicka Enter För Att Slåss!");
                Console.ReadLine();

                playerdamage = generator.Next(0, 16);
                Lifegröt = Lifegröt - playerdamage;
                if (playerdamage == 0)
                {
                    Console.WriteLine(Gröt + "Blev inte träffad!");
                }

                else
                {
                    Console.WriteLine(Gröt + " tog " + playerdamage + " Skada");
                    Ragegröt++;
                }


                grötdamage = generator.Next(0, 16);
                Lifeplayer = Lifeplayer - grötdamage;
                if (grötdamage == 0)
                {
                    Console.WriteLine(Player + " Blev inte träffad!");
                }
                else
                {
                    Console.WriteLine(Player + " tog " + grötdamage + " Skada");
                    Rageplayer++;
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Välkommen till affären");
                Console.WriteLine("Du har " + Rageplayer + " Rage Points");
                Console.WriteLine("Skriv (1) 4 rage points för slumpat antal HP 10 till 40");
                Console.WriteLine("Skriv (2) 2 rage points för 10 HP");
                Console.WriteLine("Enter för att skippa");
                string Shop = Console.ReadLine();
                if (Shop == "1")
                {
                    Console.WriteLine("Du har nu " + Lifeplayer + " HP");
                    Rageplayer = Rageplayer - 5;
                    Lifeplayer = generator.Next(10, 40);

                }
                else if (Shop == "2")
                {
                    Console.WriteLine("Du fick 10 HP");
                    Rageplayer = Rageplayer - 3;
                    Lifeplayer = Lifeplayer + 10;
                }


            }
            if (Lifegröt > 0)
            {
                Console.WriteLine("Du förlorade!");
            }
            else if (Lifeplayer > 0)
            {
                int Lifeplayer2 = 100;
                int LifeSpenat = 100;

                int rageplayer2 = 0;
                int ragespenat = 0;

                int spenatdamage;
                int player2damage;

                Console.WriteLine("Grattis du vann!");
                Console.WriteLine("Fortsätt till nästa match? klicka enter");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Välkommen till match 2");
                Console.ReadLine();
                Console.Clear();

                while (Lifeplayer2 > 0 && LifeSpenat > 0)
                {
                    Random generator2 = new Random();

                    Console.WriteLine(Player + " " + Lifeplayer2 + " HP & " + rageplayer2 + " Rage");
                    Console.WriteLine("Spenat " + LifeSpenat + " HP & " + ragespenat + " Rage");

                    Console.WriteLine("Klicka enter för att slåss!");
                    Console.ReadLine();

                    player2damage = generator2.Next(0, 16);
                    LifeSpenat = LifeSpenat - player2damage;
                    if (player2damage == 0)
                    {
                        Console.WriteLine("Spenat blev inte träffad!");
                    }
                    else
                    {
                        Console.WriteLine("Spenat tog " + player2damage + " Skada");
                    }

                    spenatdamage = generator2.Next(0, 16);
                    Lifeplayer2 = Lifeplayer2 - spenatdamage;
                    if (spenatdamage == 0)
                    {
                        Console.WriteLine(Player + " blev inte träffad!");
                    }

                    else
                    {
                        Console.WriteLine(Player + " tog " + spenatdamage + " Skada");
                    }


                }









            }

            Console.ReadLine();
        }
    }
}
