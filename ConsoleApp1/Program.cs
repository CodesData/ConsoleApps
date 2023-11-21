using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Example 1 : Variables
            Console.WriteLine(" Hello");

            // Ask the user to enter name.
            Console.Write(" Enter your name : ");
            string name = Console.ReadLine();

            // Ask the user to enter age.
            Console.Write(" Enter your age : ");
            int age = int.Parse(Console.ReadLine());

            // Ask the user to enter height in meters.
            Console.Write(" Enter your height (in meters) : ");
            double height = double.Parse(Console.ReadLine());

            // Display the information entered by the user.
            Console.WriteLine(" User information :");
            Console.WriteLine(" Name : " + name);
            Console.WriteLine(" Age : " + age + " years");
            Console.WriteLine(" Height : " + height + " meters");

            // View the results
            Console.ReadKey();

            // Example 2 : Menu
            Console.WriteLine("\n\t ********************* ");
            string input;
            int choice;
            Console.WriteLine("\t *  List of Options  *");
            Console.WriteLine("\t * 1 -> Option A     *");
            Console.WriteLine("\t * 2 -> Option B     *");
            Console.WriteLine("\t * 3 -> Option C     *");
            Console.WriteLine("\t ********************* ");
            Console.Write("\t Choose Option (1, 2, or 3): ");

            input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n You Chose Option A.");
                        break;
                    case 2:
                        Console.WriteLine("\n You Chose Option B.");
                        break;
                    case 3:
                        Console.WriteLine("\n You Chose Option C.");
                        break;
                    default:
                        Console.WriteLine("\n Invalid selection. Please choose 1, 2, or 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\n Invalid input. Please enter a number.");
            }

            Console.ReadKey();
        }
    }
}