using System;

namespace BranchesLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            //int b = 6;
            int b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");

            int aa = 5;
            int bb = 3;
            int cc = 4;
            //if ((aa + bb + cc > 10) && (aa > bb))
            //{
            //    Console.WriteLine("The answer is greater than 10");
            //    Console.WriteLine("And the first number is greater than the second");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //    Console.WriteLine("Or the first number is not greather than the second");
            //}

            if ((aa + bb + cc > 10) || (aa > bb))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greather than the second");
            }

            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! the counter is {counter}");
                counter++;
            } while (counter < 10);

            for (int counterB = 7; counterB < 42; counterB++)
            {
                Console.WriteLine($"Hello World! The counter is {counterB}");
            }

            int sum = 0;
            for (int loopCount = 1; loopCount <= 20; loopCount++)
            {
                if (loopCount % 3 == 0)

                    sum += loopCount;
                


            }
            Console.WriteLine(sum);
        }
    }
}
