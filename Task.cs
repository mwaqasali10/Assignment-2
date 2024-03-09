// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");


//Question # 01
class AirthmeticOperation
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"Division: {num1 / num2}");
            Console.WriteLine($"Modulus (Remainder): {num1 % num2}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}

//Question # 02

class Comparenumber
{
    static void value()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine($"{num1} is greater than {num2}");
        else if (num1 < num2)
            Console.WriteLine($"{num1} is less than {num2}");
        else
            Console.WriteLine($"{num1} is equal to {num2}");
    }
}

//Question #3

class Program
{
    static void num()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}

//Question # 4

class Program
{
    static void Integer()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

//Question # 5

class Program
{
    static void Add()
    {
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine($"Sum of even numbers between 1 and 100: {sum}");
    }
}

//Question # 6


class Reversed
{
    static void String()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);

        string reversedString = new string(charArray);

        Console.WriteLine($"Reversed string: {reversedString}");
    }
}

// Question # 7

class Program
{
    static void Primenumber()
    {
        Console.WriteLine("Prime numbers between 1 and 100:");

        for (int i = 2; i <= 100; i++)
        {
            bool isPrime = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write($"{i} ");
            }
        }
    }
}








