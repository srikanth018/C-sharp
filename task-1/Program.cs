using System;

class Program
{
    static void fibonacii(int n)
    {
        int num_1 = 0;
        int num_2 = 1;
            System.Console.WriteLine(num_1);
            System.Console.WriteLine(num_2);
        for (int i =0 ;i<n;i++){

            int num_3 = num_2+num_1; 
            System.Console.WriteLine(num_3);
            num_1 = num_2;
            num_2 = num_3;
        }
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
        fibonacii(input);
    }
}
