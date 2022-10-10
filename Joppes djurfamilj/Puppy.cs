using System;
using System.Collections.Generic;
using System.Text;

namespace Joppes_hundar
{
    class Puppy : Dog
    {
        // fält
        public int months;

        // konstruktor
        public Puppy(int _age, int _months, string _name, string _fav_food, string _breed) : base(_age, _name, _fav_food, _breed)
        {
            this.months = _months;
        }

        // properties till fält
        public int Months { get; set; }

        public override void Interact(Ball ball) // skriver över basklassens metod
        {
            Console.WriteLine("Joppe kastar sin boll till {0}", name);

            if (hungry)
            {
                Hungry_animal(); // metodanrop
            }
            else
            {
                int damage = 1;
                ball.Quality -= damage;

                if (ball.Quality == 0)
                {
                    Console.WriteLine("Joppes boll är tyvärr trasig");
                }
                else
                {
                    Console.WriteLine("{0} Leker med Joppes boll", name);
                    ball.Lower_quality();
                }

            }

        }

        public override string ToString() // skriver över basklassens returvärden
        {
            return string.Format("Namn: {0}, Ålder: {1} månader, Ras: {2}", name, months, breed);

        }

    }
}
