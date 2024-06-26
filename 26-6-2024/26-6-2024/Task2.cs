using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26_6_2024
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            //  Write a C# program that accept two integers and display the smaller.

            Console.Write("The smallest number: ");
            int[] numbers = { 84, 35 };
            Array.Sort(numbers);
            Console.WriteLine(numbers[0]);

            //// Write a C# conditional statement to find the sign  of input  number. Display sign.

            //Console.Write("Enter a number:");
            //int numberSign = Convert.ToInt32(Console.ReadLine());
            //int sign = Math.Sign(numberSign);
            //Console.WriteLine($"The sign of number: {sign}");

            //// Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            //int[] numbers1 = { 0, -1, 4 };
            //Array.Sort(numbers1);
            //Console.WriteLine($"Sort three numbers ascending: {numbers1[0]} {numbers1[1]} {numbers1[2]} ");

            //// Write a C# conditional statement to find the max of five numbers. Use console to display the result.

            //int[] numbers2 = { -5, -2, -6, 0, -1 };
            //Array.Sort(numbers2);
            //Console.WriteLine($"The max number is: {numbers2[numbers2.Length - 1]}");

            //// Write a C# program that converts kilometers per hour to miles per hour
            //Console.Write("kilometers per hour: ");
            //int Kilometer = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"miles per hour: {Kilometer * 0.621371192}");

            //// Write a C# program that takes hours and minutes as input and calculates the total number of minutes.

            //Console.Write("input hours: ");
            //int hour = Convert.ToInt32(Console.ReadLine()) * 60;

            //Console.Write("input minutes: ");
            //int min = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Total minutes: {hour + min} ");


            //// Write a program in C# that takes minutes as input and display the total number of hours and minutes. 

            //Console.Write("Inter Hours:");
            //int inputMin = Convert.ToInt32(Console.ReadLine());

            //int hours = inputMin / 60;
            //int remainingMinutes = inputMin % 60;

            //Console.WriteLine($"{hours} Hours, {remainingMinutes} Minutes");


            // Create string of array that contains 5 element of different sentence with different length .Print all elements with fixed length for each sentence.

            //string[] words = {"The sun set over the horizon, casting a warm glow across the tranquil sea.",
            //                  "She found an old photograph in the attic, bringing back a flood of childhood memories.",
            //                  "The cat perched on the windowsill, watching the world go by with keen, curious eyes.",
            //                  "A sudden gust of wind sent the autumn leaves swirling in a vibrant dance.",
            //                  "He took a deep breath, steeling himself for the challenging task ahead." };

            //Console.WriteLine(words[0].Substring(0, 25));
            //Console.WriteLine(words[1].Substring(0, 25));
            //Console.WriteLine(words[2].Substring(0, 25));
            //Console.WriteLine(words[3].Substring(0, 25));
            //Console.WriteLine(words[4].Substring(0, 25));



        }
    }
}
