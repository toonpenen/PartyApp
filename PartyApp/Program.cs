using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyApp
{
    public enum TypeOfGuest
    {
        Family=1,
        Friend,
        colleague,
        Other
    }
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public TypeOfGuest GuesType { get; set; }
    }
    public class DishesCollection
    {
        public int Fork { get; set; }
        public int Knife { get; set; }
        public int Dish { get; set; }
        public int Spoon { get; set; }
        public int Napkin { get; set; }
    }

    class Program
    {
        static int size = 0;
        static Person[] people = new Person[size];

        static void Main(string[] args)
        {
            Person[] people = new Person[1];           

            string input = "";
            do
            {
                Person person = new Person();

                Console.WriteLine("Enter the first name of guest ");
                person.Name = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter the last name of guest ");
                person.SurName = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter your relationship" + "\n");
                string value = Console.ReadLine();
                Console.WriteLine();

                TypeOfGuest relation = (TypeOfGuest)Enum.Parse(typeof(TypeOfGuest), value);

                if ((int)relation < 1 ||(int)relation > 4)
                {
                    Console.WriteLine("The value is incorrect, press any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                    person.GuesType = relation;

                    switch (relation)
                    {
                        case TypeOfGuest.Family:
                            break;
                        case TypeOfGuest.Friend:
                            break;
                        case TypeOfGuest.colleague:
                            break;
                        case TypeOfGuest.Other:
                            break;
                        default:
                            break;
                    }                    
                }
                

                //size++;

                //foreach (var item in people)
                //{
                //    Console.WriteLine(item.Name);
                //}

                //person.GuesType = relation;
                people[size] = person;

                Console.WriteLine("More guests? y/n");
                input = Console.ReadLine();
              
                if (input == "y")
                {
                    size++;
                    Array.Resize(ref people,size+1);
                    Console.Clear();
                }
            } while (input.ToLower() == "y");
        }
    }
}
