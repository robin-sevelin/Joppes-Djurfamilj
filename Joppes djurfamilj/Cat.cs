using System;
using System.Collections.Generic;
using System.Text;

namespace Joppes_hundar
{
    class Cat : Animals
    {
        //konstruktor
        public Cat(int _age, string _name, string _fav_food, string _breed) : base(_age, _name, _fav_food, _breed)
        {

        }

        // skriver över basklassens metod
        public override void Interact(Ball ball)
        {
            Console.WriteLine("Joppe kastar sin boll till {0}", name);

            if (hungry)
            {
                Hungry_animal(); // metod anrop

            }
            else
            {
                Console.WriteLine("{0} Leker hellre med sitt snöre", name);

            }


        }

        public override void Hungry_animal() // skriver över basklassens metod
        {
            Console.WriteLine("{0} fräser och visar att hon är hungrig", name);
            Console.ReadLine();
            Console.Clear();
        }

        public override void Eat() // metod för att mata djuret
        {
            Console.WriteLine("Vill du vara extra snäll mot {0}?", name);
            Console.WriteLine("I så fall kan du mata {0} med {1}", name, fav_food);
            Console.WriteLine("svara [j] och [n] för nej");
            try
            {
                string input = Console.ReadLine();

                if (input == "j")
                {
                    Console.WriteLine("{0} äter glatt {1}", name, fav_food);
                    Console.ReadLine();
                    Console.Clear();
                    hungry = false;

                }
                else
                {
                    Console.WriteLine("{0} tittar snett på Joppe, maten duger inte", name);
                    Hunt(); // metodanrop

                }
            }
            catch (Exception)
            {
                Console.WriteLine("använd bokstäver");
            }


        }


        public void Hunt() // metod om katten jagar en mus
        {
            Console.WriteLine("Lite missnöjd beger sig {0} på jakt efter en mus att äta istället", name);
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("..{0} jagar", name);
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("..{0} jagar mera", name);
            System.Threading.Thread.Sleep(1500);

            Random slumptal = new Random();
            int hunt = slumptal.Next(0, 2);
            if (hunt == 0)
            {
                Console.WriteLine("{0} fångande en mus och är mätt för stunden", name);
                Console.ReadLine();
                Console.Clear();
                hungry = false;
            }
            else
            {
                Console.WriteLine("{0} lyckades inte fånga något", name);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("beskiven och hungrig går {0} och gömmer sig", name);
                Console.ReadLine();
                Console.Clear();
                hungry = true;
            }


        }
        public override string ToString() // basklassens returvärden
        {
            return base.ToString();
        }
    }
}
