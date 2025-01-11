using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50


            var myArray = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50


            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                myArray[i] = rand.Next(0, 50);

            }


            //TODO: Print the first number of the array


            Console.WriteLine(myArray[0]);


            //TODO: Print the last number of the array  


            Console.WriteLine(myArray[49]);


            Console.WriteLine("All Numbers Original");


            NumberPrinter(myArray);


            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");


            Array.Reverse(myArray);

            ReverseArray(myArray);


            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");


            ThreeKiller(myArray);


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");


            Array.Sort(myArray);
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List


            var numbers = new List<int>(50);


            //TODO: Print the capacity of the list to the console


            Console.WriteLine(numbers.Capacity);


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            


            Random random = new Random();

            for (int i = 0; i <= 50; i++)
            {
                numbers.Add(i = random.Next(0, 51));
            }


            //TODO: Print the new capacity


            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");


            NumberChecker(numbers);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");


            NumberPrinter(numbers);


            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");


            OddKiller(numbers);


            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");


            OddKiller(numbers);
            numbers.Sort();
            
                    
                  



            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable


            int[] newArray = numbers.ToArray();


            //TODO: Clear the list


            numbers.Clear();


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                int answer = numbers[i];

                {
                    if (numbers[i] % 3 == 0)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                        Console.WriteLine($"{answer}");
                    }
                }
            }
        }
        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Capacity; i++)
            {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                
            }
        }

        private static void NumberChecker(List<int> numberList)
        {

            bool searchNumberNotAnInt = true;

            while (searchNumberNotAnInt)
            {
                Console.WriteLine("please input a number:");
                string searchNumber = Console.ReadLine();

                if (int.TryParse(searchNumber, out int value))
                {
                    searchNumberNotAnInt = false;
                    if (numberList.Contains(value))
                    {
                        Console.WriteLine($"{value} was in the list!");
                    }
                    else 
                    {
                        Console.WriteLine($"{value} was not in the list!");
                    }
                }
                else
                {
                    Console.WriteLine("Search number was not a valid integer. Please try inputting a valid integer again.");
                }
            }


        }
        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }

        private static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int answer = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = answer;

                Console.WriteLine(answer);
            }


        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class List
    {
    }
}
