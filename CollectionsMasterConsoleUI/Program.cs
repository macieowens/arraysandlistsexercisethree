using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            var numbers = new int[50];

            Populater(numbers);

            Console.WriteLine($"{numbers[0]}");

            Console.WriteLine($"{numbers[numbers.Length - 1]}");

            Array.Sort(numbers);
            NumberPrinter(numbers);

            ReverseArray(numbers);

            ThreeKiller(numbers);

            var numList = new List<int>();

            Console.WriteLine($"Capacity: {numList.Capacity}");

            Populater(numList);

            Console.WriteLine($"New Capacity: {numList.Capacity}");

            int userNumber;
            bool IsANumer;

            do
            {
                Console.WriteLine("What number will you search for on the list?");
                IsANumer = int.TryParse(Console.ReadLine(), out userNumber);


            } while (IsANumer == false);

            NumberChecker(numList, userNumber);

            OddKiller(numList);

            numList.Sort();
            NumberPrinter(numList);

            var myArray = numList.ToArray();

            numList.Clear();
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++);
            {
                int i = 0;
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }

            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int i = numberList.Count - 1; i < -1; i--)   
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            var evens = numberList.Where(x => x % 2 != 0);

            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if(numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes we have the number you're looking for");
            }
            else
            {
                Console.WriteLine($"These aren't the droids you're looking for");
            }
        }

        private static void Populater(List<int> numbersList)
        {
            while(numbersList.Count < 51)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);

                numbersList.Add(number);
            }

            Console.WriteLine(numbersList);

           NumberPrinter(numbersList);
        }
        

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
            }

        }        
        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);

            NumberPrinter(array);
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
}
