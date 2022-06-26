using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1 : Variables
            Console.WriteLine("\n Hello !");
            Console.ReadKey();

            string name, surname;
            Console.Write("\n Enter your name :");
            name = Console.ReadLine();
            Console.Write("\n Enter your surname :");
            surname = Console.ReadLine();
            Console.Write("\n\n *** Info about You *** \n\n");
            Console.WriteLine("\n Your name is {0}, your surname is {1}", name, surname);
            Console.WriteLine($"\n {name} {surname} can also be displayed");
            Console.ReadKey();

            //Example 2 : Menu options
            Console.WriteLine("\n\n\t **************************** ");
            string input;
            int num;
            Console.WriteLine("\n\t *  List of fruits          *");
            Console.WriteLine("\n\t * 1 -> Apples              *");
            Console.WriteLine("\n\t * 2 -> Pears               *");
            Console.WriteLine("\n\t **************************** ");
            Console.Write("\n\n\t Choose one to eat : ");

            input = Console.ReadLine();
            num = Convert.ToInt32(input); //string value is converted to int

            if (num == 1)
            {
                Console.WriteLine("\n You wanted to eat Apples!");
            }
            else if (num == 2)
            {
                Console.WriteLine("\n You wanted to eat Pears");
            }
            else
            {
                Console.WriteLine("\n Invalid selection. Re-run the program to do a valid selection");
            }

            Console.ReadKey();

            //Example 3 : Array
            string[] fruits = new string[] { "Banana", "Apple", "Pears", "Watermelon", "Grapes" };
            Console.WriteLine("\n\t *** List of Fruits with for loop ***");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine("\n " + fruits[i]);
            }

            Console.WriteLine("\n\n\t **************************** ");

            for (int i = fruits.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\n " + fruits[i]);
            }

            Console.WriteLine("\n\t *** List of Fruits with for each loop ***");
            ListOfFruits(fruits);

            Console.ReadKey();
        }
        static void ListOfFruits(string[] fruits)
        {
            foreach (string eachFruit in fruits)
            {
                Console.WriteLine("\n " + eachFruit);
            }
        }
    }
}
