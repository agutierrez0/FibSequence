using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // User Input -- then converted to an int
            Console.Write("Please input a number: ");
            int fibInputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input: " + fibInputNumber);

            // Declaration of array
            var intArray = new int[fibInputNumber];
            int i = 0;
            foreach ( int index in intArray )
            {
                if (i == 0) // When input is 0, output is nothing 
                    intArray[i] = i;
                else if (i == 1) // When input is 1, output is only one number, 0
                    intArray[i] = i;
                else if (i > 1) // When input is anything above 2, it takes the previous index
                {               // and the index before that one and adds them together.
                    int sum = intArray[i - 2] + intArray[i - 1];
                    intArray[i] = sum;
                }
                i++;
            }
            // Output
            Console.Write("Output: ");
            Console.Write(string.Join(",", intArray));
            Console.WriteLine(" ");
            Console.Write("If you would like to exit the application please type anything and press enter.");
            Console.Read();
        }
    }
}
