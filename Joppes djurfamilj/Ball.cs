using System;
using System.Collections.Generic;
using System.Text;

namespace Joppes_hundar
{
    class Ball
    {
        // fält
        private string color;
        private int quality;

        // kostruktor
        public Ball(string _color, int _quality)
        {
            color = _color;
            quality = _quality;
        }

        // properties till fält
        public string Color { get; set; } public int Quality { get; set; }

        // metod för att titta på bollen
        public void Check_ball()
        {
            Console.WriteLine("Bollen har färgen {0}", color);
            if (quality == 5)
            {
                Console.WriteLine("bollens skick är top notch");
            }
            else if(quality == 4)
            {
                Console.WriteLine("bollen är lite använt skick");
            }
            else if(quality == 3)
            {
                Console.WriteLine("bollen är lite sliten");
            }
            else if(quality == 2)
            {
                Console.WriteLine("bollen är väldigt sliten");
            }
            else if(quality == 1)
            {
                Console.WriteLine("bollen är nästan helt förstörd");
            }
            else if(quality == 0)
            {
                Console.WriteLine("Joppes boll är trasig, ska Joppe köpa en ny boll?");
                Console.WriteLine("svara [j] eller [n]");
                try
                {
                    string input = Console.ReadLine();
                    if (input == "j")
                    {
                        quality = 5;
                        Console.WriteLine("Nu har Joppe en ny boll");
                    }
                    else
                    {
                        Console.WriteLine("Bollen förblir trasig");

                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("använd bokstäver");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            Console.ReadLine();
            Console.Clear();
        }

        // metod för att minka bollens kvalitet
        public void Lower_quality()
        {
            Console.WriteLine("bollens kvalitet minskar");
            quality--;
        }


        public override string ToString() // returvärden
        {
            return string.Format("{0}{1}", color, quality);
        }

    }
}
