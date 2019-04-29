using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci Sequence by Angel Gutierrez
            // 4/29/2019

            // User Input -- then converted to an int
            Console.Write("Please input a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input: " + x);

            // Declaration of array
            var intArray = new int[x];
            int i = 0;
            foreach ( int index in intArray )
            {
                if (i == 0)
                    intArray[i] = i;
                else if (i == 1)
                    intArray[i] = i;
                else if (i > 1)
                {
                    int sum = intArray[i - 2] + intArray[i - 1];
                    intArray[i] = sum;
                }
                i++;
            }
            Console.Write("Output: ");
            Console.Write(string.Join(",", intArray));
        }
    }
}
