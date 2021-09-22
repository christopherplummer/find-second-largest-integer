using System;

namespace FindSecondLargestInteger.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 44, 66, 3, 210 };
            
            CheckForSecondLargest(numbers);
        }

        private static void CheckForSecondLargest(int[] numbers)
        {
            // Check if array is null or empty
            if (IsNullOrEmpty(numbers))
            {
                Console.WriteLine("Array is null or empty");
                return;
            }

            // First number will be our first max
            int maxNumber = numbers[0];
            int secondToMaxNumber;

            // If we have more than 1 number, the second position in the array will be first secondToMax
            if (numbers.Length > 1)
            {
                secondToMaxNumber = numbers[1];

                // If we only have 2 numbers, calculate the secondToMax
                if (numbers.Length < 3)
                {
                    secondToMaxNumber = maxNumber > secondToMaxNumber ? secondToMaxNumber : maxNumber;
                    PrintResult(secondToMaxNumber);
                    return;
                }
            }
            else
            {
                Console.WriteLine("Only 1 number exists.");
                return;
            }
            
            // Iterate array to find true secondToMax
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    secondToMaxNumber = maxNumber;
                    maxNumber = numbers[i];
                }
                else if (numbers[i] > secondToMaxNumber)
                {
                    secondToMaxNumber = numbers[i];
                }
            }
            
            PrintResult(secondToMaxNumber);
        }

        private static bool IsNullOrEmpty(int[] numbers)
        {
            return numbers is not { Length: > 0 };
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine($"The second to largest integer is {result}");
        }
    }
}