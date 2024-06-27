using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////// Correct the syntax error: //////////

            //string[] ARR = [1, 7  9  45,]
            int[] ARP = { 1, 7, 9, 45 };

            //int arr2 = ["Str" "alex","moh"
            string[] arr2 = { "Str", "alex", "moh" };


            //string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            ////////// What the index of "Banana","Tomato" //////////

            //String[] fruits = {"Tomato", "Banana", "Watermelon"};
            //Console.Write("The index of Banana is: ");
            //Console.WriteLine(Array.IndexOf(fruits,"Banana"));

            //Console.Write("The index of Tomato is: ");
            //Console.WriteLine(Array.IndexOf(fruits,"Tomato"));

            ////////// Create an multiple arrays that represents your: //////////

            // •Favorite Food 

            //string[] food = { "Mansaf", "Kabsa", "Kobah", "Makmora", "Pizza" };
            //Console.Write("My Favorite Food are: ");
            //foreach (string i in food)
            //{
            //    Console.Write($"{i}, ");
            //}

            // •Favorite Sport 

            //string[] sport = { "Soccer", "Tenis", "Basketball" };
            //Console.Write("\nMy Favorite Sport are: ");

            //foreach (string i in sport)
            //{
            //    Console.Write($"{i}, ");
            //}

            // •Favorite Movie  

            //string[] Movie = { "John Wick", "Sherlock Holmes", "Interstellar" };
            //Console.Write("\nMy Favorite Movie are: ");

            //foreach (string i in Movie)
            //{
            //    Console.Write($"{i}, ");
            //}

            ////////// Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma //////////

            //Console.Write("\nInput three numbers separated by comma: ");

            //string numbers = Console.ReadLine();
            //string[] numbersArray = numbers.Split(',');

            //int sum = 0;
            //foreach (string i in numbersArray)
            //{
            //    sum = sum + Convert.ToInt32(i);
            //}

            //Console.WriteLine($"The sum of three numbers: {sum}");

            ////////// Write a program in C# to display the n terms of odd number and their sum from [1- 100] //////////

            //Console.Write("Odd Numbers: ");
            //int sum = 0;
            //for (int i = 1; i <= 100; i += 2)
            //{
            //    Console.Write($"{i}, ");
            //    sum = sum + i;
            //}

            //Console.WriteLine($"\nThe Sum of Odd numbers is: {sum}");


            ////////// Write a program in C# to display the pattern like right angle triangle using an asterisk.//////////
            string x = "*";
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(x);
                x = x + "*";
            }

            ////////// Write a program in C# to make such a pattern like right angle triangle with number increased by 1.//////////

            int row = 1;
            int num = 1;
            while (row <= 4)
            {
                int j = 1;
                while (j <= row)
                {
                    Console.Write($"{num} ");
                    j++;
                    num++;
                }
                Console.WriteLine("\n");
                row++;
            }

        }
    }
}
