using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create console application that read string from user and print the same string

            string x = Console.ReadLine();
            Console.WriteLine(x);

            //Define variables with kind of:
            // a) Double 

            double number1 = 2.34D;
            Console.WriteLine(number1);

            // b) String
            string name = "Aya";
            Console.WriteLine(name);

            // c) Character 
            char letter = 'A';
            Console.WriteLine(letter);
            
            // d) Boolean
            bool myBool = false;
            Console.WriteLine(myBool);

            // e) Integer
            int number2 = 0;
            Console.WriteLine(number2);

            // f) Const
            const int number3 = 4;
            Console.WriteLine(number3);


            // Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.

            string[] cars = { "BMW", "Volvo", "Hunda" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            //Write a program in C that reads a first name, surname and year of birth and display the names and the year one after another sequentially.
            Console.Write("Input your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("\nInput your last name: ");
            string lastName = Console.ReadLine();


            Console.Write("\nInput your year of birth: ");
            string yearBirth = Console.ReadLine();

            Console.WriteLine(firstName + " " +lastName + " " + yearBirth);

            // Write a program in C # to store elements in an array and print it.
            var element = new string[10];
            element[0] = Console.ReadLine();
            element[1] = Console.ReadLine();
            element[2] = Console.ReadLine();
            element[3] = Console.ReadLine();
            element[4] = Console.ReadLine();
            element[5] = Console.ReadLine();
            element[6] = Console.ReadLine();
            element[7] = Console.ReadLine();
            element[8] = Console.ReadLine();
            element[9] = Console.ReadLine();
            

            Console.Write(element[0]);
            Console.Write(element[1]);
            Console.Write(element[2]);
            Console.Write(element[3]);
            Console.Write(element[4]);
            Console.Write(element[5]);
            Console.Write(element[6]);
            Console.Write(element[7]);
            Console.Write(element[8]);
            Console.Write(element[9]);


            // Write a program in C# to find the sum of all elements of the array.

            int[] numbers = { 2, 5, 8 };
            int sumNumbers = numbers[0] + numbers[1] + numbers[2];
            Console.WriteLine("\nSum of all elements stored in the array is : " + sumNumbers);

            Console.ReadLine();
        }
    }
}
