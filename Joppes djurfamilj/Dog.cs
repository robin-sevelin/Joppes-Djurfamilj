using System;
using System.Collections.Generic;
using System.Text;

namespace Joppes_hundar
{
    class Dog : Animals
    {
        // konstruktor
        public Dog(int _age, string _name, string _fav_food, string _breed) : base(_age, _name, _fav_food, _breed)
        {

        }

        
        public override void Interact(Ball ball) // skriver över basklassens metod
        {
            Console.WriteLine("Joppe kastar sin boll till {0}", name);

            if (hungry)
            {
                Hungry_animal(); // metodanrop
            }
            else
            {
                int damage = 2;
                ball.Quality -= damage;

                if(ball.Quality == 0)
                {
                    Console.WriteLine("Joppes boll är tyvärr trasig");

                }
                else
                {
                    Console.WriteLine("{0} Leker med joppes boll", name);

                    ball.Lower_quality(); //metod anrop
                }

            }

        }


        public override string ToString() // basklassens returvärden
        {
            return base.ToString();
        }


    }
}
