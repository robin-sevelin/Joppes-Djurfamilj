using System;
using System.Collections.Generic;
using System.Text;

namespace Joppes_hundar
{
    abstract class Animals
    {
        // fält med defaulta värden
        protected int age;
        protected string name;
        protected string fav_food;
        protected string breed;
        protected bool hungry = true;


        // konstruktor
        public Animals(int _age, string _name, string _fav_food, string _breed)
        {
            this.age = _age;
            this.name = _name;
            this.fav_food = _fav_food;
            this.breed = _breed;
        }

        // properties till fält
        public int Age { get; set; } public string Name { get; set; } public string Fav_food { get; set; } public string Breed { get; set; } public bool Hungry { get; set; }



        public virtual void Interact(Ball ball) // metod för att leka med djuret
        {

        }


        public virtual void Eat() // metod för att mata djuret
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
                    Console.ReadLine();
                    Console.Clear();
                    hungry = true;

                }
            }
            catch(Exception)
            {
                Console.WriteLine("använd bokstäver");
            }


        }

        public virtual void Hungry_animal() // metod om djuret är hungrigt
        {

            Console.WriteLine("{0} gnyr och visar sig vara hungrig", name);
            Console.ReadLine();
            Console.Clear();
            hungry = true;
        }



        public override string ToString() // basklassens returvärden
        {
            return string.Format("Namn: {0}, Ålder: {1} år, Ras: {2}", name, age, breed);
        }
    }
}
