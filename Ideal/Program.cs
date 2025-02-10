using System;
using System.Numerics;

public class FibonacciSeries
{
    public static void PrintFibonacciSeries(int n)
    {
        // Input validation
        if (n < 0)
        {
            Console.WriteLine("Input must be a non-negative integer.");
            return;
        }

        if (n == 0)
        {
            return; // Nothing to print
        }

        BigInteger a = 0;
        BigInteger b = 1;

        Console.WriteLine(a); // Print the first Fibonacci number

        if (n == 1)
        {
            return; // Only the first Fibonacci number is printed
        }

        Console.WriteLine(b); // Print the second Fibonacci number

        for (int i = 2; i < n; i++)
        {
            BigInteger next = a + b;
            Console.WriteLine(next);
            a = b;
            b = next;
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number of Fibonacci numbers to generate: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            PrintFibonacciSeries(n);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}