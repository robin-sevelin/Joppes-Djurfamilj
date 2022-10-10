using System;
using System.Collections.Generic;
using System.Text;

namespace Joppes_hundar
{
    class Petowner
    {
        // fält
        private int age;
        private Ball ball = new Ball("röd", 5);

        // lista
        private List<Animals> pets = new List<Animals>
        {
            new Dog(5, "Bosse", "Lasange", "Mops"),
            new Dog(10, "Lars", "Frasvåfflor", "Pitbull"),
            new Cat(11, "Fia", "Torrfoder", "Bondkatt"),
            new Puppy(0, 5, "Frida", "Torrfoder för valpar", "Tax"),
        };

        // konstruktor
        public Petowner(int _age)
        {
            age = _age;
        }

        // properties till fält
        public string Age { get; set; }

        public void Menu() // metod för huvudmenyn
        {
            int menu = 0;

            do
            {
                Console.WriteLine("Välkommen till Joppes djurfamilj");
                Console.WriteLine("................................");
                Console.WriteLine("Gör ett av följande val");
                Console.WriteLine("[1] Skriv ut lista på Joppes djur");
                Console.WriteLine("[2] Lek med ett djur");
                Console.WriteLine("[3] Mata ett djur");
                Console.WriteLine("[4] Info om Joppe");
                Console.WriteLine("[5] Titta på Joppes boll");
                Console.WriteLine("[6] Avsluta");
                try
                {
                    menu = int.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            Console.Clear();
                            List_animals();
                            break;
                        case 2:
                            Console.Clear();
                            Play();
                            break;
                        case 3:
                            Console.Clear();
                            Feed();
                            break;
                        case 4:
                            Console.Clear();
                            Print_joppe();
                            break;
                        case 5:
                            Console.Clear();
                            ball.Check_ball(); ;
                            break;
                        case 6:
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("..felaktigt menyval");
                            break;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("använd siffror");
                    Console.ReadLine();
                    Console.Clear();
                }



            } while (menu != 6);

        }

        public void Play() // metod för att anropa interact metoden
        {

            Console.WriteLine("Vilket av dina djur vill du leka med?");
            Console.WriteLine("[1] Bosse");
            Console.WriteLine("[2] Lars");
            Console.WriteLine("[3] Fia");
            Console.WriteLine("[4] Frida");
            try
            {
                int menyval = int.Parse(Console.ReadLine());

                switch (menyval)
                {
                    case 1:
                        Console.Clear();
                        pets[0].Interact(ball); // metodanrop med specifik index position
                        break;
                    case 2:
                        Console.Clear();
                        pets[1].Interact(ball);
                        break;
                    case 3:
                        Console.Clear();
                        pets[2].Interact(ball);
                        break;
                    case 4:
                        Console.Clear();
                        pets[3].Interact(ball);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("..felaktigt menyval");
                        break;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("använd siffror");
                Console.ReadLine();
                Console.Clear();

            }


        }

        public void Feed() // metod för att anropa eat metoden
        {
            Console.WriteLine("Vilket av dina djur vill du mata?");
            Console.WriteLine("[1] Bosse");
            Console.WriteLine("[2] Lars");
            Console.WriteLine("[3] Fia");
            Console.WriteLine("[4] Frida");
            try
            {
                int menyval = int.Parse(Console.ReadLine());

                switch (menyval)
                {
                    case 1:
                        Console.Clear();
                        pets[0].Eat(); // metodanrop med specifik indexpostion
                        break;
                    case 2:
                        Console.Clear();
                        pets[1].Eat();
                        break;
                    case 3:
                        Console.Clear();
                        pets[2].Eat();
                        break;
                    case 4:
                        Console.Clear();
                        pets[3].Eat();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("..felaktigt menyval");
                        break;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("använd siffror");
                Console.ReadLine();
                Console.Clear();
            }




        }
        public void List_animals() // metod för att skriva ut listan
        {
            Console.WriteLine("Här är alla Joppes djur");
            Console.WriteLine("................................");
            foreach (var pet in pets)
            {
                Console.WriteLine(pet);
            }
            Console.ReadLine();
            Console.Clear();

        }

        public void Print_joppe() // metod för att skriva ut Joppes ålder
        {
            Console.WriteLine("Joppe är {0} år gammal och gillar att samla på djur", age);
            Console.ReadLine();
            Console.Clear();
        }

        public override string ToString() // returvärden
        {
            return string.Format("{0}", age);
        }

    }
}
