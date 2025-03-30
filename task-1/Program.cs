using System;

class Program
{
    static int factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * factorial(n - 1);
    }
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input > 0)
        {
            Console.WriteLine("Yes!, You have entered a positive number.");
        }
        else if (input < 0)
        {
            Console.WriteLine("No!, You have entered a negative number.");
            return;
        }
        Console.WriteLine("The factorial of " + input + " is " + factorial(input));
    }
}
